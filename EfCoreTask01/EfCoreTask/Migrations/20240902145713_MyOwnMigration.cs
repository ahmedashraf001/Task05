using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EfCoreTask.Migrations
{
    public partial class MyOwnMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"alter table students 
                                    add  Email nvarchar(250) Null;");
        } 

        protected override void Down(MigrationBuilder migrationBuilder)
        {
			migrationBuilder.Sql(@"alter table students 
                                    drop column Email; "); 
		}
    }
}
