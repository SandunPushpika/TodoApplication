using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TestApplication.DataAccess.Migrations
{
    public partial class changedstructure : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "title",
                table: "Todos",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "description",
                table: "Todos",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "name",
                table: "authors",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "adressnb",
                table: "authors",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "city",
                table: "authors",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "street",
                table: "authors",
                maxLength: 50,
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "created", "due" },
                values: new object[] { new DateTime(2022, 7, 17, 15, 39, 41, 966, DateTimeKind.Local).AddTicks(2121), new DateTime(2022, 7, 19, 15, 39, 41, 968, DateTimeKind.Local).AddTicks(2895) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "created", "due" },
                values: new object[] { new DateTime(2022, 7, 17, 15, 39, 41, 968, DateTimeKind.Local).AddTicks(6187), new DateTime(2022, 7, 19, 15, 39, 41, 968, DateTimeKind.Local).AddTicks(6247) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "created", "due" },
                values: new object[] { new DateTime(2022, 7, 17, 15, 39, 41, 968, DateTimeKind.Local).AddTicks(6413), new DateTime(2022, 7, 22, 15, 39, 41, 968, DateTimeKind.Local).AddTicks(6426) });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "adressnb", "city", "street" },
                values: new object[] { "162/4", "Ambalangoda", "Athvalagoda" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "adressnb", "city", "street" },
                values: new object[] { "1678B", "Los Angeles", "Mension Street" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "adressnb", "city", "street" },
                values: new object[] { "54", "Okhlama", "Denist Street" });

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "adressnb", "city", "street" },
                values: new object[] { "162/4", "Sillycan Valley", "FB Street" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "adressnb",
                table: "authors");

            migrationBuilder.DropColumn(
                name: "city",
                table: "authors");

            migrationBuilder.DropColumn(
                name: "street",
                table: "authors");

            migrationBuilder.AlterColumn<string>(
                name: "title",
                table: "Todos",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "description",
                table: "Todos",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "name",
                table: "authors",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 20);

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "created", "due" },
                values: new object[] { new DateTime(2022, 7, 17, 12, 21, 52, 907, DateTimeKind.Local).AddTicks(9266), new DateTime(2022, 7, 19, 12, 21, 52, 910, DateTimeKind.Local).AddTicks(8551) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "created", "due" },
                values: new object[] { new DateTime(2022, 7, 17, 12, 21, 52, 911, DateTimeKind.Local).AddTicks(1214), new DateTime(2022, 7, 19, 12, 21, 52, 911, DateTimeKind.Local).AddTicks(1255) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "created", "due" },
                values: new object[] { new DateTime(2022, 7, 17, 12, 21, 52, 911, DateTimeKind.Local).AddTicks(1350), new DateTime(2022, 7, 22, 12, 21, 52, 911, DateTimeKind.Local).AddTicks(1357) });
        }
    }
}
