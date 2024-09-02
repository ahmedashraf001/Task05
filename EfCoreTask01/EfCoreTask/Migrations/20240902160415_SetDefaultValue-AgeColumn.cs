using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EfCoreTask.Migrations
{
    public partial class SetDefaultValueAgeColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "AAge",
                schema: "MySchema",
                table: "SStudents",
                type: "int",
                nullable: false,
                defaultValue: 22,
                comment: "Name of the student",
                oldClrType: typeof(int),
                oldType: "int",
                oldDefaultValue: 20,
                oldComment: "Name of the student");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "AAge",
                schema: "MySchema",
                table: "SStudents",
                type: "int",
                nullable: false,
                defaultValue: 20,
                comment: "Name of the student",
                oldClrType: typeof(int),
                oldType: "int",
                oldDefaultValue: 22,
                oldComment: "Name of the student");
        }
    }
}
