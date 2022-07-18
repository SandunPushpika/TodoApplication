using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TestApplication.DataAccess.Migrations
{
    public partial class seeddata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Todos",
                columns: new[] { "Id", "created", "description", "due", "status", "title" },
                values: new object[] { 1, new DateTime(2022, 7, 17, 10, 25, 12, 349, DateTimeKind.Local).AddTicks(739), " test descriptions", new DateTime(2022, 7, 19, 10, 25, 12, 350, DateTimeKind.Local).AddTicks(8384), 1, "test" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
