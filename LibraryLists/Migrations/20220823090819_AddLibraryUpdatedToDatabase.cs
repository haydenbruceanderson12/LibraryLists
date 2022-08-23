using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LibraryLists.Migrations
{
    public partial class AddLibraryUpdatedToDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ISBN",
                table: "Library",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ISBN",
                table: "Library");
        }
    }
}
