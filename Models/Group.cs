using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace theWall.Models
{
    public class Group
    {
        [Key]
        public int GroupID {get;set;}
        [Required]
        public string Name {get;set;}
        public int OwnerID {get;set;}

        public List<UserGroup> GroupUsers {get;set;}

        public List<Message> GroupMessages {get;set;}

        public Group(string Name)
        {
            this.Name = Name;
        }

        public Group(){}
    }
}