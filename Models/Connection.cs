using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using theWall.Models;

public class Connection
{
    [Key]
    public int ConnectionID {get;set;}
    public int creatorID {get;set;}
    public int UserID {get;set;}

    public int FriendID {get;set;}

    public bool isConnected {get;set;}

    public Connection(int creatorID, int UserID, int FriendID)
    {
        this.creatorID = creatorID;
        this.UserID = UserID;
        this.FriendID = FriendID;
        this.isConnected = false;
    }
}