using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EfCoreTask.Migrations
{
    public partial class ComputedColumnIDAAgestudentsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ID_Age",
                schema: "MySchema",
                table: "SStudents",
                type: "nvarchar(max)",
                nullable: false,
                computedColumnSql: "[StId] + [AAge]");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ID_Age",
                schema: "MySchema",
                table: "SStudents");
        }
    }
}
