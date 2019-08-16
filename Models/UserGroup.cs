using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
    
namespace theWall.Models
{
    public class UserGroup
    {
        [Key]
        public int UserGroupID {get;set;}

        public int UserID {get;set;}

        public int GroupID {get;set;}

        public User User {get;set;}

        public Group Group {get;set;}

        public UserGroup(int UserID, int GroupID)
        {
            this.UserID = UserID;
            this.GroupID = GroupID;
        }

        public UserGroup()
        {}
    }
}