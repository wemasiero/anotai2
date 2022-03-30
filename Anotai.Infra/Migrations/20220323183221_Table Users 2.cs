using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Anotai.Data.Migrations
{
    public partial class TableUsers2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Users",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(2022, 3, 23, 15, 32, 20, 984, DateTimeKind.Local).AddTicks(1929),
                oldClrType: typeof(DateTime),
                oldType: "TEXT",
                oldDefaultValue: new DateTime(2022, 3, 23, 14, 58, 0, 186, DateTimeKind.Local).AddTicks(1991));

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    Password = table.Column<string>(type: "TEXT", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false, defaultValue: new DateTime(2022, 3, 23, 14, 58, 0, 186, DateTimeKind.Local).AddTicks(1991)),
                    UpdatedAt = table.Column<DateTime>(type: "TEXT", nullable: true),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Genders",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(2022, 3, 23, 15, 32, 20, 984, DateTimeKind.Local).AddTicks(1415),
                oldClrType: typeof(DateTime),
                oldType: "TEXT",
                oldDefaultValue: new DateTime(2022, 3, 23, 14, 58, 0, 186, DateTimeKind.Local).AddTicks(1367));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 23, 15, 32, 20, 984, DateTimeKind.Local).AddTicks(2113));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 23, 15, 32, 20, 984, DateTimeKind.Local).AddTicks(2120));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 23, 15, 32, 20, 984, DateTimeKind.Local).AddTicks(2122));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 23, 15, 32, 20, 984, DateTimeKind.Local).AddTicks(2123));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 23, 15, 32, 20, 984, DateTimeKind.Local).AddTicks(2125));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 23, 15, 32, 20, 984, DateTimeKind.Local).AddTicks(2126));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 23, 15, 32, 20, 984, DateTimeKind.Local).AddTicks(2129));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 23, 15, 32, 20, 984, DateTimeKind.Local).AddTicks(2130));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 23, 15, 32, 20, 984, DateTimeKind.Local).AddTicks(2132));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 23, 15, 32, 20, 984, DateTimeKind.Local).AddTicks(2133));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 23, 15, 32, 20, 984, DateTimeKind.Local).AddTicks(2135));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 23, 15, 32, 20, 984, DateTimeKind.Local).AddTicks(2136));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 23, 15, 32, 20, 984, DateTimeKind.Local).AddTicks(2138));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 23, 15, 32, 20, 984, DateTimeKind.Local).AddTicks(2139));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 23, 15, 32, 20, 984, DateTimeKind.Local).AddTicks(2141));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 23, 15, 32, 20, 984, DateTimeKind.Local).AddTicks(2142));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 23, 15, 32, 20, 984, DateTimeKind.Local).AddTicks(2144));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 23, 15, 32, 20, 984, DateTimeKind.Local).AddTicks(2145));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 23, 15, 32, 20, 984, DateTimeKind.Local).AddTicks(2147));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 23, 15, 32, 20, 984, DateTimeKind.Local).AddTicks(2149));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 23, 15, 32, 20, 984, DateTimeKind.Local).AddTicks(2150));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 23, 15, 32, 20, 984, DateTimeKind.Local).AddTicks(2153));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 23, 15, 32, 20, 984, DateTimeKind.Local).AddTicks(2155));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 23, 15, 32, 20, 984, DateTimeKind.Local).AddTicks(2156));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 23, 15, 32, 20, 984, DateTimeKind.Local).AddTicks(2158));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 23, 15, 32, 20, 984, DateTimeKind.Local).AddTicks(2159));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 23, 15, 32, 20, 984, DateTimeKind.Local).AddTicks(2161));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 23, 15, 32, 20, 984, DateTimeKind.Local).AddTicks(2163));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 23, 15, 32, 20, 984, DateTimeKind.Local).AddTicks(2164));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 23, 15, 32, 20, 984, DateTimeKind.Local).AddTicks(2166));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 23, 15, 32, 20, 984, DateTimeKind.Local).AddTicks(2167));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 23, 15, 32, 20, 984, DateTimeKind.Local).AddTicks(2168));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 23, 15, 32, 20, 984, DateTimeKind.Local).AddTicks(2180));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 23, 15, 32, 20, 984, DateTimeKind.Local).AddTicks(2184));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 23, 15, 32, 20, 984, DateTimeKind.Local).AddTicks(2186));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Users",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(2022, 3, 23, 14, 58, 0, 186, DateTimeKind.Local).AddTicks(1991),
                oldClrType: typeof(DateTime),
                oldType: "TEXT",
                oldDefaultValue: new DateTime(2022, 3, 23, 15, 32, 20, 984, DateTimeKind.Local).AddTicks(1929));

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "Users",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .OldAnnotation("Sqlite:Autoincrement", true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Genders",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(2022, 3, 23, 14, 58, 0, 186, DateTimeKind.Local).AddTicks(1367),
                oldClrType: typeof(DateTime),
                oldType: "TEXT",
                oldDefaultValue: new DateTime(2022, 3, 23, 15, 32, 20, 984, DateTimeKind.Local).AddTicks(1415));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 23, 14, 58, 0, 186, DateTimeKind.Local).AddTicks(2206));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 23, 14, 58, 0, 186, DateTimeKind.Local).AddTicks(2212));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 23, 14, 58, 0, 186, DateTimeKind.Local).AddTicks(2213));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 23, 14, 58, 0, 186, DateTimeKind.Local).AddTicks(2215));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 23, 14, 58, 0, 186, DateTimeKind.Local).AddTicks(2217));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 23, 14, 58, 0, 186, DateTimeKind.Local).AddTicks(2218));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 23, 14, 58, 0, 186, DateTimeKind.Local).AddTicks(2220));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 23, 14, 58, 0, 186, DateTimeKind.Local).AddTicks(2221));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 23, 14, 58, 0, 186, DateTimeKind.Local).AddTicks(2222));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 23, 14, 58, 0, 186, DateTimeKind.Local).AddTicks(2224));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 23, 14, 58, 0, 186, DateTimeKind.Local).AddTicks(2225));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 23, 14, 58, 0, 186, DateTimeKind.Local).AddTicks(2227));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 23, 14, 58, 0, 186, DateTimeKind.Local).AddTicks(2228));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 23, 14, 58, 0, 186, DateTimeKind.Local).AddTicks(2229));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 23, 14, 58, 0, 186, DateTimeKind.Local).AddTicks(2231));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 23, 14, 58, 0, 186, DateTimeKind.Local).AddTicks(2232));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 23, 14, 58, 0, 186, DateTimeKind.Local).AddTicks(2233));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 23, 14, 58, 0, 186, DateTimeKind.Local).AddTicks(2235));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 23, 14, 58, 0, 186, DateTimeKind.Local).AddTicks(2237));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 23, 14, 58, 0, 186, DateTimeKind.Local).AddTicks(2239));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 23, 14, 58, 0, 186, DateTimeKind.Local).AddTicks(2241));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 23, 14, 58, 0, 186, DateTimeKind.Local).AddTicks(2242));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 23, 14, 58, 0, 186, DateTimeKind.Local).AddTicks(2243));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 23, 14, 58, 0, 186, DateTimeKind.Local).AddTicks(2245));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 23, 14, 58, 0, 186, DateTimeKind.Local).AddTicks(2246));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 23, 14, 58, 0, 186, DateTimeKind.Local).AddTicks(2248));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 23, 14, 58, 0, 186, DateTimeKind.Local).AddTicks(2249));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 23, 14, 58, 0, 186, DateTimeKind.Local).AddTicks(2251));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 23, 14, 58, 0, 186, DateTimeKind.Local).AddTicks(2252));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 23, 14, 58, 0, 186, DateTimeKind.Local).AddTicks(2254));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 23, 14, 58, 0, 186, DateTimeKind.Local).AddTicks(2255));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 23, 14, 58, 0, 186, DateTimeKind.Local).AddTicks(2257));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 23, 14, 58, 0, 186, DateTimeKind.Local).AddTicks(2258));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 23, 14, 58, 0, 186, DateTimeKind.Local).AddTicks(2260));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 23, 14, 58, 0, 186, DateTimeKind.Local).AddTicks(2261));
        }
    }
}
