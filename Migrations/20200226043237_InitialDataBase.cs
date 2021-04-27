using Microsoft.EntityFrameworkCore.Migrations;

namespace AssetMS.Migrations
{
    public partial class InitialDataBase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BookCollection",
                columns: table => new
                {
                    BookId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Price = table.Column<int>(nullable: false),
                    Quantity = table.Column<int>(nullable: false),
                    ISBN = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Author = table.Column<string>(nullable: true),
                    Edition = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookCollection", x => x.BookId);
                });

            migrationBuilder.CreateTable(
                name: "HardwareCollection",
                columns: table => new
                {
                    HardwareId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Price = table.Column<int>(nullable: false),
                    Quantity = table.Column<int>(nullable: false),
                    Number = table.Column<string>(nullable: true),
                    Type = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HardwareCollection", x => x.HardwareId);
                });

            migrationBuilder.CreateTable(
                name: "SoftwareCollection",
                columns: table => new
                {
                    SoftwareId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Price = table.Column<int>(nullable: false),
                    Quantity = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SoftwareCollection", x => x.SoftwareId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BookCollection");

            migrationBuilder.DropTable(
                name: "HardwareCollection");

            migrationBuilder.DropTable(
                name: "SoftwareCollection");
        }
    }
}
