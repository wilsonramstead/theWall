using System;
using System.ComponentModel.DataAnnotations;


namespace theWall.Models
{
    public class UserLogin
    {
        public string logEmail {get;set;}

        public string Password {get;set;}
    }
}