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

        [HttpGet("account")]
        public IActionResult Account()
        {
            return View("accountPage");
        }
    }
}