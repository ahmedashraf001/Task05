﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EfCoreTask.Migrations
{
    public partial class RestoreTitleColumnCourse : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Courses",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Title",
                table: "Courses");
        }
    }
}
