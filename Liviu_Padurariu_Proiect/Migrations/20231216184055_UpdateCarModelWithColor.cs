using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Liviu_Padurariu_Proiect.Migrations
{
    /// <inheritdoc />
    public partial class UpdateCarModelWithColor : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Color",
                table: "Car");

            migrationBuilder.AddColumn<int>(
                name: "ColorID",
                table: "Car",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Color",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Color", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Car_ColorID",
                table: "Car",
                column: "ColorID");

            migrationBuilder.AddForeignKey(
                name: "FK_Car_Color_ColorID",
                table: "Car",
                column: "ColorID",
                principalTable: "Color",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Car_Color_ColorID",
                table: "Car");

            migrationBuilder.DropTable(
                name: "Color");

            migrationBuilder.DropIndex(
                name: "IX_Car_ColorID",
                table: "Car");

            migrationBuilder.DropColumn(
                name: "ColorID",
                table: "Car");

            migrationBuilder.AddColumn<string>(
                name: "Color",
                table: "Car",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
