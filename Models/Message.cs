using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace theWall.Models
{
    public class Message
    {
        [Key]
        public int MessageID {get;set;}

        [Required]
        [MinLength(1)]
        public string Content {get;set;}

        [Required]
        
        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;

        public int UserID {get;set;}
        public User Creator {get;set;}
        public List<Comment> Comments {get;set;}
        public int GroupID {get;set;}

    }
}