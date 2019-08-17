using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using theWall.Models;

namespace theWall.Controllers
{
    public class HomeController : Controller
    {
        private MyContext dbContext;
        public HomeController(MyContext context)
        {
            dbContext = context;
        }

        [Route("")]
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost("register")]
        public IActionResult Register(User user)
        {
            if(ModelState.IsValid)
            {
                if(dbContext.Users.Any(u => u.Email == user.Email))
                {
                    ModelState.AddModelError("Email", "That Email already exists!");
                    return View("Index");
                }
                else if (dbContext.Users.Any(u => u.UserName == user.UserName))
                {
                    ModelState.AddModelError("UserName", "That user name already exists!");
                    return View("Index");
                }
                else
                {
                    PasswordHasher<User> Hasher = new PasswordHasher<User>();
                    user.Password = Hasher.HashPassword(user, user.Password);
                    dbContext.Add(user);

                    Group group = dbContext.Groups.FirstOrDefault(n => n.Name == "All");
                    if(group == null)
                    {
                        Group newgroup = new Group("All");
                        dbContext.Groups.Add(newgroup);
                        UserGroup addSelf = new UserGroup(user.UserID, newgroup.GroupID);
                        dbContext.UserGroups.Add(addSelf);
                    }
                    else
                    {
                        UserGroup addSelf = new UserGroup(user.UserID, group.GroupID);
                        dbContext.UserGroups.Add(addSelf);
                    }
                    

                    dbContext.SaveChanges();
                    int userID = user.UserID;
                    HttpContext.Session.SetInt32("loggeduser", userID);
                    System.Console.WriteLine("Success");
                    return RedirectToAction("Dashboard", new{userID = userID});
                }
            }
            else
            {
                return View("Index");
            }
        }

        [HttpPost("login")]
        public IActionResult Login(UserLogin userSubmission)
        {
            if(ModelState.IsValid)
            {
                var userInDb = dbContext.Users.FirstOrDefault(u => u.Email == userSubmission.logEmail);
                if(userInDb == null)
                {
                    ModelState.AddModelError("logEmail", "Invalid Email/Password");
                    return View("Index");
                }
                var hasher = new PasswordHasher<UserLogin>();
                var result = hasher.VerifyHashedPassword(userSubmission, userInDb.Password, userSubmission.Password);
                if(result == 0)
                {
                    return View("Index");
                }
                else
                {
                    int userID = userInDb.UserID;
                    HttpContext.Session.SetInt32("loggeduser", userID);
                    return RedirectToAction("Dashboard", new{userID = userID});
                }
            }
            else 
            {
                return View("Index");
            }
        }
        
        [HttpGet("Dashboard/{userID:int}")]
        public IActionResult Dashboard(int userID)
        {
            if(HttpContext.Session.GetInt32("loggeduser") != null)
            {
                User user = dbContext.Users.FirstOrDefault(u => u.UserID == userID);
                ViewBag.CurrentUser = user;

                List<Message> allMessages = dbContext.Messages
                    .Include(m => m.Creator)
                    .Include(m => m.Comments)
                    .ThenInclude(c => c.User)
                    .Where(gid => gid.GroupID == 1)
                    .OrderByDescending(m => m.CreatedAt)
                    .ToList();
                ViewBag.allMessages = allMessages;
                return View("Dashboard");
            }
            else
            {
                return RedirectToAction("Index");
            }
        }

        [HttpPost("createmessage")]
        public IActionResult CreateMessage(Message message)
        {
            int? id = HttpContext.Session.GetInt32("loggeduser");
            int userID = id ?? default(int);
            if(ModelState.IsValid)
            {
                dbContext.Messages.Add(message);
                dbContext.SaveChanges();
                return RedirectToAction("Dashboard", new{userID = userID});
            }
            else
            {
                ModelState.AddModelError("message", "Unable to create message :|");
                User user = dbContext.Users.FirstOrDefault(u => u.UserID == userID);
                ViewBag.CurrentUser = user;
                return View("Dashboard");
            }
        }

        [HttpPost("createcomment")]
        public IActionResult CreateComment(Comment comment)
        {

            int? id = HttpContext.Session.GetInt32("loggeduser");
            int userID = id ?? default(int);
            if(ModelState.IsValid)
            {
                dbContext.Comments.Add(comment);
                dbContext.SaveChanges();
                return RedirectToAction("Dashboard", new{userID = userID});
            }
                
            else
            {
                User user = dbContext.Users.FirstOrDefault(u => u.UserID == userID);
                ViewBag.CurrentUser = user;

                List<Message> allMessages = dbContext.Messages
                .Include(m => m.Creator)
                .OrderByDescending(m => m.CreatedAt)
                .ToList();
                ViewBag.allMessages = allMessages;
                
                List<Comment> allComments = dbContext.Comments
                .Include(c => c.Message)
                .ToList();
                ViewBag.allComments = allComments;

                return View("Dashboard");
            }
        }

        [HttpGet("logout")]
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }

        [HttpGet("/account/{userID:int}")]
        public IActionResult Account(int userID)
        {
            User viewUser = dbContext.Users.FirstOrDefault(u => u.UserID == userID);
            ViewBag.ViewUser = viewUser;
            int? currentUserID = HttpContext.Session.GetInt32("loggeduser");
            User currentUser = dbContext.Users.FirstOrDefault(u => u.UserID == currentUserID);
            System.Console.WriteLine("currentUser: " + currentUser);
            ViewBag.CurrentUser = currentUser;
            int sessionID = currentUserID ?? default(int);
            ViewBag.sessionID = sessionID;

            List<Message> allMessages = dbContext.Messages
                .Where(m => m.Creator.UserID == userID)
                .Include(m => m.Creator)
                .Include(m => m.Comments)
                .ThenInclude(c => c.User)
                .OrderByDescending(m => m.CreatedAt)
                .ToList();
            ViewBag.allMessages = allMessages;
            return View("accountPage");
        }
        [HttpGet("/account/edit/{userID:int}")]
        public IActionResult Edit(int userID)
        {
            if(HttpContext.Session.GetInt32("loggeduser") == userID)
            {
                User user = dbContext.Users.FirstOrDefault(u => u.UserID == userID);
                ViewBag.CurrentUser = user;
                // int? currentUser = HttpContext.Session.GetInt32("loggeduser");
                // ViewBag.CurrentUser = currentUser;  
                List<User> allConnections = dbContext.Users.ToList(); //needs to change from all users to all user connections
                ViewBag.allConn = allConnections;
                return View("editAccount", user);
            }
            else
            {
                return RedirectToAction("Index");
            }
        }
        [HttpPost("/editUser/{ID}")]
        public IActionResult EditUser(int ID, User user) 
        {
            if(user.UserName != null && user.FirstName != null && user.LastName != null) {
                if(dbContext.Users.Where(u => u.UserID != ID).Any(u => u.UserName == user.UserName))
                {
                    ModelState.AddModelError("UserName", "That user name already exists!");
                    User currentUser = dbContext.Users.FirstOrDefault(u => u.UserID == ID);
                    ViewBag.CurrentUser = currentUser;  
                    List<User> allConnections = dbContext.Users.ToList(); //needs to change from all users to all user connections
                    ViewBag.allConn = allConnections;
                    return View("editAccount", currentUser);
                } else {
                    User currentUser = dbContext.Users.FirstOrDefault(u => u.UserID == ID);
                    currentUser.UserName = user.UserName;
                    currentUser.FirstName = user.FirstName;
                    currentUser.LastName = user.LastName;
                    currentUser.Bio = user.Bio;
                    dbContext.SaveChanges();
                    return RedirectToAction("Account", new {userID = ID});
                }
            } else {
                User currentUser = dbContext.Users.FirstOrDefault(u => u.UserID == ID);
                ViewBag.CurrentUser = currentUser;
                return View("editAccount", currentUser);
            }
        }
        [HttpGet("/account/color/{userID:int}")]
        public IActionResult changeColor(int userID)
        {
            if(HttpContext.Session.GetInt32("loggeduser") == userID)
            {
                User user = dbContext.Users.FirstOrDefault(u => u.UserID == userID);
                ViewBag.CurrentUser = user;  
                return View("changeColor", user);
            }
            else
            {
                return RedirectToAction("Index");
            }
        }
        [HttpPost("/updateColor/{userID:int}")]
        public IActionResult updateColor(int userID, User user)
        {
            if(HttpContext.Session.GetInt32("loggeduser") == userID)
            {
                System.Console.WriteLine("YEE BUDDYY!");
                User currentUser = dbContext.Users.FirstOrDefault(u => u.UserID == userID);
                // ViewBag.CurrentUser = currentUser;
                currentUser.ColorRed = user.ColorRed;
                currentUser.ColorGreen = user.ColorGreen;
                currentUser.ColorBlue = user.ColorBlue;
                dbContext.SaveChanges();
                // return View("changeColor", user);
                return RedirectToAction("Account", new {userID = userID});
            } else {
                return RedirectToAction("Index");
            }
        }


        [HttpGet("connections/{userID:int}")]
        public IActionResult Connections(int userID)
        {
            if(HttpContext.Session.GetInt32("loggeduser") == userID)
            {
                User user = dbContext.Users.FirstOrDefault(u => u.UserID == userID);
                ViewBag.CurrentUser = user;

                List<Connection> UserConn = dbContext.Connections.Where(cid => cid.UserID == user.UserID).ToList();
                List<User> allConnections = new List<User>();
                foreach(Connection con in UserConn)//puts all user connections into a list
                {
                    if(con.isConnected)
                    {
                        User u = dbContext.Users.FirstOrDefault(fid => fid.UserID == con.FriendID);
                        allConnections.Add(u);
                    }
                }
                ViewBag.allConn = allConnections;

                List<Connection> pending = dbContext.Connections
                .Where(cid => cid.UserID == user.UserID)
                .Where(cic => cic.isConnected == false)
                .Where(uid => uid.creatorID == user.UserID).ToList();
                List<User> pendingUsers = new List<User>();
                foreach(Connection con in pending)
                {
                    User u = dbContext.Users.FirstOrDefault(fid => fid.UserID == con.FriendID);
                    pendingUsers.Add(u);
                }
                ViewBag.pending = pendingUsers;

                List<Connection> accept = dbContext.Connections
                .Where(cid => cid.UserID == userID)
                .Where(cic => cic.isConnected == false)
                .Where(uid => uid.creatorID != user.UserID).ToList();
                List<User> acceptUsers = new List<User>();
                foreach(Connection con in accept)
                {
                    User u = dbContext.Users.FirstOrDefault(fid => fid.UserID == con.FriendID);
                    acceptUsers.Add(u);
                }
                ViewBag.accept = acceptUsers;

                List<User> allUsers = dbContext.Users.ToList();
                List<User> NotConnected = new List<User>();
                foreach(User person in allUsers)//adds any user that isnt loggedin or in the loggedin list<connection> into a list<user>
                {
                    if(user.UserID == person.UserID)
                    {
                        continue;
                    }
                    else if(allConnections == null)
                    {
                        NotConnected.Add(person);
                    }
                    else if(!allConnections.Contains(person))
                    {
                        NotConnected.Add(person);
                    }
                }
                ViewBag.notConn = NotConnected;
                return View("Connections");
            }
            else
            {
                return RedirectToAction("Index");
            }
        }

        [HttpGet("addConnection/{userID:int}/{connectionID:int}")]
        public IActionResult AddConnection(int userID, int connectionID)
        {
            if(HttpContext.Session.GetInt32("loggeduser") == userID)
            {
                User user = dbContext.Users.FirstOrDefault(u => u.UserID == userID);
                ViewBag.CurrentUser = user;
                User newConnection = dbContext.Users.FirstOrDefault(cID => cID.UserID == connectionID);
                
                Connection newConn = new Connection(userID, userID, connectionID);
                dbContext.Connections.Add(newConn);
                Connection newConn2 = new Connection(userID, connectionID, userID);
                dbContext.Connections.Add(newConn2);
                dbContext.SaveChanges();
                
                return RedirectToAction("Connections", new{userID = userID});
            }
            else
            {
                return RedirectToAction("Index");
            }
        }

        [HttpGet("acceptConnection/{userID:int}/{connectionID:int}")]
        public IActionResult AcceptConnection(int userID, int connectionID)
        {
            if(HttpContext.Session.GetInt32("loggeduser") == userID)
            {
                User user = dbContext.Users.FirstOrDefault(u => u.UserID == userID);
                ViewBag.CurrentUser = user;
                User newConnection = dbContext.Users.FirstOrDefault(cID => cID.UserID == connectionID);

                Connection userConn = dbContext.Connections.Where(uid => uid.UserID == userID).FirstOrDefault(fid => fid.FriendID == connectionID);
                Connection requestConn = dbContext.Connections.Where(uid => uid.UserID == connectionID).FirstOrDefault(fid => fid.FriendID == userID);
                
                userConn.isConnected = true;
                requestConn.isConnected = true;
                dbContext.SaveChanges();
                
                return RedirectToAction("Connections", new{userID = userID});
            }
            else
            {
                return RedirectToAction("Index");
            }
        }

        [HttpGet("declineConnection/{userID:int}/{connectionID:int}")]
        public IActionResult DeclineConnection(int userID, int connectionID)
        {
            if(HttpContext.Session.GetInt32("loggeduser") == userID)
            {
                User user = dbContext.Users.FirstOrDefault(u => u.UserID == userID);
                ViewBag.CurrentUser = user;
                User newConnection = dbContext.Users.FirstOrDefault(cID => cID.UserID == connectionID);

                Connection userConn = dbContext.Connections.Where(uid => uid.UserID == userID).FirstOrDefault(fid => fid.FriendID == connectionID);
                Connection requestConn = dbContext.Connections.Where(uid => uid.UserID == connectionID).FirstOrDefault(fid => fid.FriendID == userID);
                
                dbContext.Remove(userConn);
                dbContext.Remove(userConn);
                dbContext.SaveChanges();
                
                return RedirectToAction("Connections", new{userID = userID});
            }
            else
            {
                return RedirectToAction("Index");
            }
        }

        [HttpGet("directMessaging/{userID:int}")]
        public IActionResult DirectMessaging(int userID)
        {
            if(HttpContext.Session.GetInt32("loggeduser") == userID)
            {
                User user = dbContext.Users.FirstOrDefault(u => u.UserID == userID);
                ViewBag.CurrentUser = user;

                List<Connection> UserConn = dbContext.Connections.Where(cid => cid.UserID == user.UserID).ToList();
                List<User> allConnections = new List<User>();
                foreach(Connection con in UserConn)//puts all user connections into a list
                {
                    if(con.isConnected)
                    {
                        User u = dbContext.Users.FirstOrDefault(fid => fid.UserID == con.FriendID);
                        allConnections.Add(u);
                    }
                }
                ViewBag.allConn = allConnections;
                return View("DMs");
            }
            else
            {
                return RedirectToAction("Index");
            }
        }

        [HttpGet("myNetwork/{userID:int}")]
        public IActionResult MyNetwork(int userID)
        {
            if(HttpContext.Session.GetInt32("loggeduser") == userID)
            {
                User user = dbContext.Users.FirstOrDefault(u => u.UserID == userID);
                ViewBag.CurrentUser = user;

                List<Connection> UserConn = dbContext.Connections.Where(cid => cid.UserID == user.UserID).ToList();
                List<User> allConnections = new List<User>();
                foreach(Connection con in UserConn)//puts all user connections into a list
                {
                    if(con.isConnected)
                    {
                        User u = dbContext.Users.FirstOrDefault(fid => fid.UserID == con.FriendID);
                        allConnections.Add(u);
                    }
                }
                ViewBag.allConn = allConnections;
                ViewBag.message = HttpContext.Session.GetString("Message");

                List<UserGroup> allGroupsConnections = dbContext.UserGroups.Where(uid => uid.UserID == userID).ToList();
                List<Group> allMyGroups = new List<Group>();
                foreach(UserGroup ug in allGroupsConnections)
                {
                    Group thisGroup = dbContext.Groups.FirstOrDefault(gid => gid.GroupID == ug.GroupID);
                    if(thisGroup.Name == "All")
                    {}
                    else
                    {
                        allMyGroups.Add(thisGroup);
                    }
                }
                ViewBag.allMyGroups = allMyGroups;

                List<Group> allCreatedGroups = dbContext.Groups.Where(oid  => oid.OwnerID == userID).ToList();
                ViewBag.usersGroups = allCreatedGroups;

                return View("NetworkPage");
            }
            else
            {
                return RedirectToAction("Index");
            }
        }

        [HttpPost("createNewGroup/{userID:int}")]
        public IActionResult CreateNewGroup(int userID, Group newgroup)
        {
            if(HttpContext.Session.GetInt32("loggeduser") == userID)
            {
                dbContext.Groups.Add(newgroup);
                UserGroup addSelf = new UserGroup(userID, newgroup.GroupID);
                dbContext.UserGroups.Add(addSelf);
                dbContext.SaveChanges();
                return RedirectToAction("MyNetwork", new {userID = userID});
            }
            else
            {
                return RedirectToAction("Index");
            }
        }

        [HttpPost("addToGroup/{userID:int}/{newAddID:int}")]
        public IActionResult AddToGroup(int userID, int newAddID, UserGroup newJoin)
        {
            UserGroup check = dbContext.UserGroups.Where(uid => uid.UserID == newJoin.UserID).FirstOrDefault(gid => gid.GroupID == newJoin.GroupID);
            if(check != null)
            {
                HttpContext.Session.SetString("Message", "User already in group.");
                int? uuserID = HttpContext.Session.GetInt32("loggeduser");
                return RedirectToAction("MyNetwork", new {userID = uuserID});
            }
            else
            {
                HttpContext.Session.SetString("Message", "");
                dbContext.UserGroups.Add(newJoin);
                User groupJoin = dbContext.Users.Include(ug => ug.allGroups).ThenInclude(g => g.Group).FirstOrDefault(uid => uid.UserID == userID);
                dbContext.SaveChanges();
                int? uuserID = HttpContext.Session.GetInt32("loggeduser");
                return RedirectToAction("MyNetwork", new {userID = uuserID});
            }
        }

        [HttpGet("groupChat/{userID:int}/{groupID:int}")]
        public IActionResult GroupChat(int userID, int groupID)
        {
            if(HttpContext.Session.GetInt32("loggeduser") == userID)
            {
                User user = dbContext.Users.Include(ag => ag.allGroups).FirstOrDefault(u => u.UserID == userID);
                ViewBag.CurrentUser = user;

                Group group = dbContext.Groups.Include(gu => gu.GroupUsers).FirstOrDefault(g => g.GroupID == groupID);
                ViewBag.CurrentGroup = group;

                List<Message> groupMessages = dbContext.Messages
                    .Include(m => m.Creator)
                    .Include(m => m.Comments)
                    .ThenInclude(c => c.User)
                    .OrderByDescending(m => m.CreatedAt)
                    .Where(tgid => tgid.GroupID == group.GroupID).ToList();
                ViewBag.allMessages = groupMessages;

                return View("GroupChatPage");
            }
            else
            {
                return RedirectToAction("Index");
            }
        }

        [HttpPost("newGroupMessage/{userID:int}/{groupID:int}")]
        public IActionResult NewGroupMessage(int userID, int groupID, Message newMessage)
        {
            
            if(ModelState.IsValid && HttpContext.Session.GetInt32("loggeduser") == userID)
            {
                dbContext.Messages.Add(newMessage);
                dbContext.SaveChanges();
                return RedirectToAction("GroupChat", new{userID = userID, groupID = groupID});
            }
            else if(!ModelState.IsValid && HttpContext.Session.GetInt32("loggeduser") == userID)
            {
                ModelState.AddModelError("message", "Unable to create message :|");
                User user = dbContext.Users.FirstOrDefault(u => u.UserID == userID);
                ViewBag.CurrentUser = user;
                return View("GroupChatPage");
            }
            else
            {
                return RedirectToAction("Index");
            }
        }

        [HttpPost("createGroupComment/{userID:int}/{groupID:int}")]
        public IActionResult CreateGroupComment(int userID, int groupID, Comment comment)
        {
            if(ModelState.IsValid)
            {
                dbContext.Comments.Add(comment);
                dbContext.SaveChanges();
                return RedirectToAction("GroupChat", new{userID = userID, groupID = groupID});
            }
                
            else
            {
                User user = dbContext.Users.FirstOrDefault(u => u.UserID == userID);
                ViewBag.CurrentUser = user;

                List<Message> allMessages = dbContext.Messages
                .Include(m => m.Creator)
                .OrderByDescending(m => m.CreatedAt)
                .ToList();
                ViewBag.allMessages = allMessages;
                
                List<Comment> allComments = dbContext.Comments
                .Include(c => c.Message)
                .ToList();
                ViewBag.allComments = allComments;

                return View("GroupChatPage");
            }
        }

        [HttpGet("/directmessage/{SenderID:int}/{ReceiverID:int}")]
        public IActionResult directMessage(int SenderID, int ReceiverID)
        {
            User currentUser = dbContext.Users.FirstOrDefault(u => u.UserID == SenderID);
            ViewBag.CurrentUser = currentUser;

            Connection connection = dbContext.Connections
                .Where(c => c.UserID == SenderID || c.UserID == ReceiverID)
                .FirstOrDefault(c => c.FriendID == SenderID || c.FriendID == ReceiverID);
            ViewBag.Connection = connection;

            List<DM> allDMs = dbContext.DMs
                .Where(c => c.ConnectionID == connection.ConnectionID)
                .ToList();
            @ViewBag.allDMs = allDMs;

            User receivingUser = dbContext.Users.FirstOrDefault(u => u.UserID == ReceiverID);
            ViewBag.ReceivingUser = receivingUser;

            return View("conversations");
        }

        [HttpPost("/newDM/{SenderID:int}/{ReceiverID:int}")]
        public IActionResult newDM(int SenderID, int ReceiverID, DM directMessage)
        {
            dbContext.DMs.Add(directMessage);
            dbContext.SaveChanges();

            System.Console.WriteLine("Success!");

            return RedirectToAction("directmessage", new {SenderID=SenderID, ReceiverID=ReceiverID});
        }
    }
}