using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace theWall.Models
{
    public class Group
    {
        [Key]
        public int GroupID {get;set;}

        public string name {get;set;}

        public List<UserGroup> GroupUsers {get;set;}

        public List<Message> GroupMessages {get;set;}
    }
}