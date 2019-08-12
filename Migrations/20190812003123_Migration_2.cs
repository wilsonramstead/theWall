using Microsoft.EntityFrameworkCore.Migrations;

namespace theWall.Migrations
{
    public partial class Migration_2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Connections_Users_FriendID",
                table: "Connections");

            migrationBuilder.DropIndex(
                name: "IX_Connections_FriendID",
                table: "Connections");

            migrationBuilder.CreateIndex(
                name: "IX_Connections_UserID",
                table: "Connections",
                column: "UserID");

            migrationBuilder.AddForeignKey(
                name: "FK_Connections_Users_UserID",
                table: "Connections",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Connections_Users_UserID",
                table: "Connections");

            migrationBuilder.DropIndex(
                name: "IX_Connections_UserID",
                table: "Connections");

            migrationBuilder.CreateIndex(
                name: "IX_Connections_FriendID",
                table: "Connections",
                column: "FriendID");

            migrationBuilder.AddForeignKey(
                name: "FK_Connections_Users_FriendID",
                table: "Connections",
                column: "FriendID",
                principalTable: "Users",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
