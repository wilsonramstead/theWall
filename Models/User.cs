using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace theWall.Models
{
    public class User
    {
        [Key]
        public int UserID {get;set;}

        [Required]
        public string FirstName {get;set;}

        [Required]
        public string LastName {get;set;}

        [Required]
        [EmailAddress]
        public string Email {get;set;}

        [Required]
        public string UserName {get;set;}

        [Required]
        public string Password {get;set;}
        
        [Required]
        [NotMapped]
        [Compare("Password")]
        public string Confirm {get;set;}

        public string Bio {get;set;}
        
        public int ColorRed {get;set;}

        public int ColorGreen {get;set;}

        public int ColorBlue {get;set;}

        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;

        public List<Comment> Comments {get;set;}
        public List<Message> allMessages {get;set;}
        public List<UserGroup> allGroups {get;set;}
        public List<Connection> MyConnections { get; set; }
        public List<DM> DMs {get;set;}
    }
}