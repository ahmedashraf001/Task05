using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EfCoreTask.Migrations
{
    public partial class ChangeAgestudentColumnName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Age",
                schema: "MySchema",
                table: "SStudents",
                newName: "AAge");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "AAge",
                schema: "MySchema",
                table: "SStudents",
                newName: "Age");
        }
    }
}
