using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EfCoreTask.Migrations
{
    public partial class ChangePrimaryKeyName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                schema: "MySchema",
                table: "SStudents",
                newName: "StId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Courses",
                newName: "CrsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "StId",
                schema: "MySchema",
                table: "SStudents",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "CrsId",
                table: "Courses",
                newName: "Id");
        }
    }
}
