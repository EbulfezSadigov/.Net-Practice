using Microsoft.EntityFrameworkCore.Migrations;

namespace Practice_1.Migrations
{
    public partial class policies : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "BackGround",
                table: "Policies",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BackGround",
                table: "Policies");
        }
    }
}
