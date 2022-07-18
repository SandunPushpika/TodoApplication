using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TestApplication.DataAccess.Migrations
{
    public partial class AuthorModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "authorid",
                table: "Todos",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "authors",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_authors", x => x.id);
                });

            migrationBuilder.InsertData(
                table: "authors",
                columns: new[] { "id", "name" },
                values: new object[,]
                {
                    { 1, "sandun" },
                    { 2, "kashmir" },
                    { 3, "jackob" },
                    { 4, "jenny" }
                });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "authorid", "created", "due" },
                values: new object[] { 1, new DateTime(2022, 7, 17, 12, 21, 52, 907, DateTimeKind.Local).AddTicks(9266), new DateTime(2022, 7, 19, 12, 21, 52, 910, DateTimeKind.Local).AddTicks(8551) });

            migrationBuilder.InsertData(
                table: "Todos",
                columns: new[] { "Id", "authorid", "created", "description", "due", "status", "title" },
                values: new object[] { 2, 1, new DateTime(2022, 7, 17, 12, 21, 52, 911, DateTimeKind.Local).AddTicks(1214), " second attempt", new DateTime(2022, 7, 19, 12, 21, 52, 911, DateTimeKind.Local).AddTicks(1255), 0, "learn dotnet" });

            migrationBuilder.InsertData(
                table: "Todos",
                columns: new[] { "Id", "authorid", "created", "description", "due", "status", "title" },
                values: new object[] { 3, 4, new DateTime(2022, 7, 17, 12, 21, 52, 911, DateTimeKind.Local).AddTicks(1350), " This is to learn dotnet", new DateTime(2022, 7, 22, 12, 21, 52, 911, DateTimeKind.Local).AddTicks(1357), 2, "go home" });

            migrationBuilder.CreateIndex(
                name: "IX_Todos_authorid",
                table: "Todos",
                column: "authorid");

            migrationBuilder.AddForeignKey(
                name: "FK_Todos_authors_authorid",
                table: "Todos",
                column: "authorid",
                principalTable: "authors",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Todos_authors_authorid",
                table: "Todos");

            migrationBuilder.DropTable(
                name: "authors");

            migrationBuilder.DropIndex(
                name: "IX_Todos_authorid",
                table: "Todos");

            migrationBuilder.DeleteData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DropColumn(
                name: "authorid",
                table: "Todos");

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "created", "due" },
                values: new object[] { new DateTime(2022, 7, 17, 10, 25, 12, 349, DateTimeKind.Local).AddTicks(739), new DateTime(2022, 7, 19, 10, 25, 12, 350, DateTimeKind.Local).AddTicks(8384) });
        }
    }
}
