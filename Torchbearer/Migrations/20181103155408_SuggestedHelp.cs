using Microsoft.EntityFrameworkCore.Migrations;

namespace Torchbearer.Migrations
{
    public partial class SuggestedHelp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SuggestedHelp",
                columns: table => new
                {
                    SkillId = table.Column<int>(nullable: false),
                    SuggestedHelpSkillId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SuggestedHelp", x => new { x.SkillId, x.SuggestedHelpSkillId });
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SuggestedHelp");
        }
    }
}
