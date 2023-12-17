using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Liviu_Padurariu_Proiect.Migrations
{
    /// <inheritdoc />
    public partial class UpdateEverythingTwice : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Car_Color_ColorID",
                table: "Car");

            migrationBuilder.DropColumn(
                name: "Make",
                table: "Car");

            migrationBuilder.DropColumn(
                name: "Model",
                table: "Car");

            migrationBuilder.RenameColumn(
                name: "Doors",
                table: "Car",
                newName: "Seats");

            migrationBuilder.AlterColumn<int>(
                name: "ColorID",
                table: "Car",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "CarMakerID",
                table: "Car",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "HP",
                table: "Car",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "Car",
                type: "numeric(5,0)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "TransmissionID",
                table: "Car",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "CarMaker",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Make = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarMaker", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Transmission",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transmission", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Car_CarMakerID",
                table: "Car",
                column: "CarMakerID");

            migrationBuilder.CreateIndex(
                name: "IX_Car_TransmissionID",
                table: "Car",
                column: "TransmissionID");

            migrationBuilder.AddForeignKey(
                name: "FK_Car_CarMaker_CarMakerID",
                table: "Car",
                column: "CarMakerID",
                principalTable: "CarMaker",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Car_Color_ColorID",
                table: "Car",
                column: "ColorID",
                principalTable: "Color",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Car_Transmission_TransmissionID",
                table: "Car",
                column: "TransmissionID",
                principalTable: "Transmission",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Car_CarMaker_CarMakerID",
                table: "Car");

            migrationBuilder.DropForeignKey(
                name: "FK_Car_Color_ColorID",
                table: "Car");

            migrationBuilder.DropForeignKey(
                name: "FK_Car_Transmission_TransmissionID",
                table: "Car");

            migrationBuilder.DropTable(
                name: "CarMaker");

            migrationBuilder.DropTable(
                name: "Transmission");

            migrationBuilder.DropIndex(
                name: "IX_Car_CarMakerID",
                table: "Car");

            migrationBuilder.DropIndex(
                name: "IX_Car_TransmissionID",
                table: "Car");

            migrationBuilder.DropColumn(
                name: "CarMakerID",
                table: "Car");

            migrationBuilder.DropColumn(
                name: "HP",
                table: "Car");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Car");

            migrationBuilder.DropColumn(
                name: "TransmissionID",
                table: "Car");

            migrationBuilder.RenameColumn(
                name: "Seats",
                table: "Car",
                newName: "Doors");

            migrationBuilder.AlterColumn<int>(
                name: "ColorID",
                table: "Car",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Make",
                table: "Car",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Model",
                table: "Car",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddForeignKey(
                name: "FK_Car_Color_ColorID",
                table: "Car",
                column: "ColorID",
                principalTable: "Color",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
