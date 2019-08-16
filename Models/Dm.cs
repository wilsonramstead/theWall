using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace theWall.Models
{
    public class DM
    {
        [Key]
        public int DmID {get;set;}

        [Required]
        [MinLength(1)]
        public string Content {get;set;}

        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;

        public int ConnectionID {get;set;}
        public int SenderID {get;set;}
        public int ReceiverID {get;set;}
        public User Creator {get;set;}
    }
}