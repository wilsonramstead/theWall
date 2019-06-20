using System;
using System.ComponentModel.DataAnnotations;


namespace theWall.Models
{
    public class Comment
    {
        [Key]
        public int CommentID {get;set;}

        [Required]
        [MinLength(1)]
        public string comContent {get;set;}

        public int UserID {get;set;}
        public User User {get;set;}
        public int MessageID {get;set;}
        public Message Message {get;set;}
        public DateTime CreatedAt {get;set;} = DateTime.Now;

        public DateTime UpdatedAt {get;set;} = DateTime.Now;

    }
}