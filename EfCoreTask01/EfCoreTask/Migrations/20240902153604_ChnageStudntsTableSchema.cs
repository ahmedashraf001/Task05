using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EfCoreTask.Migrations
{
    public partial class ChnageStudntsTableSchema : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "MySchema");

            migrationBuilder.RenameTable(
                name: "SStudents",
                newName: "SStudents",
                newSchema: "MySchema");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(
                name: "SStudents",
                schema: "MySchema",
                newName: "SStudents");
        }
    }
}
