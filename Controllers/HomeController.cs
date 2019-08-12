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
                else
                {
                    PasswordHasher<User> Hasher = new PasswordHasher<User>();
                    user.Password = Hasher.HashPassword(user, user.Password);
                    dbContext.Add(user);
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
            if(HttpContext.Session.GetInt32("loggeduser") == userID)
            {
                User user = dbContext.Users.FirstOrDefault(u => u.UserID == userID);
                ViewBag.CurrentUser = user;

                List<Message> allMessages = dbContext.Messages
                    .Include(m => m.Creator)
                    .Include(m => m.Comments)
                    .ThenInclude(c => c.User)
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
                System.Console.WriteLine("Hit");
                System.Console.WriteLine("comment content: " + comment.comContent);
                dbContext.Comments.Add(comment);
                dbContext.SaveChanges();
                System.Console.WriteLine("Worked");
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
            var num = 5;
            if(HttpContext.Session.GetInt32("loggeduser") == userID)
            {
                bool edit = false;
                // int num = 10;   
                System.Console.WriteLine("num: ", num);
                ViewBag.edit = edit;
                System.Console.WriteLine("edit: ", edit);
                System.Console.WriteLine("!!!!: ", ViewBag.edit);
                User user = dbContext.Users.FirstOrDefault(u => u.UserID == userID);
                ViewBag.CurrentUser = user;

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
            else
            {
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
                    User u = dbContext.Users.FirstOrDefault(fid => fid.UserID == con.FriendID);
                    allConnections.Add(u);
                }
                ViewBag.allConn = allConnections;

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
                
                Connection newConn = new Connection(userID, connectionID);
                dbContext.Connections.Add(newConn);
                Connection newConn2 = new Connection(connectionID, userID);
                dbContext.Connections.Add(newConn2);
                dbContext.SaveChanges();
                
                return RedirectToAction("Connections", new{userID = userID});
            }
            else
            {
                return RedirectToAction("Index");
            }
        }

        // [HttpGet("/account/")]
    }
}