using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LibraryLists.Migrations
{
    public partial class FavoriteDbUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Review",
                table: "Library");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Review",
                table: "Library",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
