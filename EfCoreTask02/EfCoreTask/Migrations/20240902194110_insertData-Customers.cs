using Microsoft.EntityFrameworkCore.Migrations;
using System.IO;


#nullable disable

namespace EfCoreTask.Migrations
{
    public partial class insertDataCustomers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
			var sqlFilePath = Path.Combine("Scripts", "Customers1000.sql");
			var sqlScript = File.ReadAllText(sqlFilePath);
			migrationBuilder.Sql(sqlScript);
		}

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
