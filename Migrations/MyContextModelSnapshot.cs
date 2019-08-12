﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using theWall.Models;

namespace theWall.Migrations
{
    [DbContext(typeof(MyContext))]
    partial class MyContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Connection", b =>
                {
                    b.Property<int>("ConnectionID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("FriendID");

                    b.Property<int>("UserID");

                    b.HasKey("ConnectionID");

                    b.HasIndex("UserID");

                    b.ToTable("Connections");
                });

            modelBuilder.Entity("theWall.Models.Comment", b =>
                {
                    b.Property<int>("CommentID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedAt");

                    b.Property<int>("MessageID");

                    b.Property<DateTime>("UpdatedAt");

                    b.Property<int>("UserID");

                    b.Property<string>("comContent")
                        .IsRequired();

                    b.HasKey("CommentID");

                    b.HasIndex("MessageID");

                    b.HasIndex("UserID");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("theWall.Models.Group", b =>
                {
                    b.Property<int>("GroupID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("name");

                    b.HasKey("GroupID");

                    b.ToTable("Groups");
                });

            modelBuilder.Entity("theWall.Models.Message", b =>
                {
                    b.Property<int>("MessageID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Content")
                        .IsRequired();

                    b.Property<DateTime>("CreatedAt");

                    b.Property<DateTime>("UpdatedAt");

                    b.Property<int>("UserID");

                    b.Property<int?>("thisGroupGroupID");

                    b.HasKey("MessageID");

                    b.HasIndex("UserID");

                    b.HasIndex("thisGroupGroupID");

                    b.ToTable("Messages");
                });

            modelBuilder.Entity("theWall.Models.User", b =>
                {
                    b.Property<int>("UserID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Bio");

                    b.Property<int>("ColorBlue");

                    b.Property<int>("ColorGreen");

                    b.Property<int>("ColorRed");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("FirstName")
                        .IsRequired();

                    b.Property<string>("LastName")
                        .IsRequired();

                    b.Property<string>("Password")
                        .IsRequired();

                    b.Property<DateTime>("UpdatedAt");

                    b.Property<string>("UserName")
                        .IsRequired();

                    b.HasKey("UserID");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("theWall.Models.UserGroup", b =>
                {
                    b.Property<int>("UserGroupID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("GroupID");

                    b.Property<int>("UserID");

                    b.HasKey("UserGroupID");

                    b.HasIndex("GroupID");

                    b.HasIndex("UserID");

                    b.ToTable("UserGroups");
                });

            modelBuilder.Entity("Connection", b =>
                {
                    b.HasOne("theWall.Models.User")
                        .WithMany("MyConnections")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("theWall.Models.Comment", b =>
                {
                    b.HasOne("theWall.Models.Message", "Message")
                        .WithMany("Comments")
                        .HasForeignKey("MessageID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("theWall.Models.User", "User")
                        .WithMany("Comments")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("theWall.Models.Message", b =>
                {
                    b.HasOne("theWall.Models.User", "Creator")
                        .WithMany("allMessages")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("theWall.Models.Group", "thisGroup")
                        .WithMany("GroupMessages")
                        .HasForeignKey("thisGroupGroupID");
                });

            modelBuilder.Entity("theWall.Models.UserGroup", b =>
                {
                    b.HasOne("theWall.Models.Group", "Group")
                        .WithMany("GroupUsers")
                        .HasForeignKey("GroupID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("theWall.Models.User", "User")
                        .WithMany("allGroups")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
