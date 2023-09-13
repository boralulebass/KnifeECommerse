using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    public partial class mig_homephotos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HomePhotos",
                columns: table => new
                {
                    HomePhotosID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HomeTitle1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HomeDesc1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HomeButton1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HomePhoto1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HomeTitle2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HomeDesc2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HomeButton2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HomePhoto2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HomeTitle3 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HomeDesc3 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HomeButton3 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HomePhoto3 = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HomePhotos", x => x.HomePhotosID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HomePhotos");
        }
    }
}
