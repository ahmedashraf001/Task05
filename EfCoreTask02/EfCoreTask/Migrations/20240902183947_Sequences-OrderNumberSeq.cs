using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EfCoreTask.Migrations
{
    public partial class SequencesOrderNumberSeq : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateSequence(
                name: "OrderNumberSeq",
                startValue: 100L);

            migrationBuilder.AddColumn<int>(
                name: "OrderNumber",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValueSql: "Next value for OrderNumberSeq ");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropSequence(
                name: "OrderNumberSeq");

            migrationBuilder.DropColumn(
                name: "OrderNumber",
                table: "Orders");
        }
    }
}
