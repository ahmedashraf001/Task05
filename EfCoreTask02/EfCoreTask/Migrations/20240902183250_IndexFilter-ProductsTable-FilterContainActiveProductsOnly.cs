using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EfCoreTask.Migrations
{
    public partial class IndexFilterProductsTableFilterContainActiveProductsOnly : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_ProductName",
                table: "Products");

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Products",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateIndex(
                name: "IX_ProductName",
                table: "Products",
                column: "ProductName",
                filter: "[IsActive] = 1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_ProductName",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Products");

            migrationBuilder.CreateIndex(
                name: "IX_ProductName",
                table: "Products",
                column: "ProductName");
        }
    }
}
