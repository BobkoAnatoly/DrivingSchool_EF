using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DrivingSchool.Migrations
{
    public partial class SomeFix1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "DrivingCategories",
                newName: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CategoryId",
                table: "DrivingCategories",
                newName: "Id");
        }
    }
}
