using Microsoft.EntityFrameworkCore.Migrations;

namespace CaoMinhQuang108.Migrations
{
    public partial class Create_Table_CMQ108 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CMQ108s",
                columns: table => new
                {
                    CMQId = table.Column<string>(type: "varchar", maxLength: 20, nullable: false),
                    CMQName = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true),
                    CMQGender = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CMQ108s", x => x.CMQId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CMQ108s");
        }
    }
}
