using Microsoft.EntityFrameworkCore.Migrations;

namespace CaoMinhQuang108.Migrations
{
    public partial class Create_Table_UniversityCMQ108 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UniversityCMQ108",
                columns: table => new
                {
                    UniversityId = table.Column<string>(type: "varchar", maxLength: 20, nullable: false),
                    UniversityName = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UniversityCMQ108", x => x.UniversityId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UniversityCMQ108");
        }
    }
}
