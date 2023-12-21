using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Liviu_Padurariu_Proiect.Migrations
{
    /// <inheritdoc />
    public partial class addUserRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RoleID",
                table: "User",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_User_RoleID",
                table: "User",
                column: "RoleID");

            migrationBuilder.AddForeignKey(
                name: "FK_User_Role_RoleID",
                table: "User",
                column: "RoleID",
                principalTable: "Role",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_User_Role_RoleID",
                table: "User");

            migrationBuilder.DropIndex(
                name: "IX_User_RoleID",
                table: "User");

            migrationBuilder.DropColumn(
                name: "RoleID",
                table: "User");
        }
    }
}
