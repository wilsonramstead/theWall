using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using theWall.Models;

public class Connection
{
    [Key]
    public int ConnectionID {get;set;}
    public int UserID {get;set;}

    public int FriendID {get;set;}

    public Connection(int UserID, int FriendID)
    {
        this.UserID = UserID;
        this.FriendID = FriendID;
    }
}