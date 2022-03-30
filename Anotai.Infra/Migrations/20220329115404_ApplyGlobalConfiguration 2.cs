using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Anotai.Data.Migrations
{
    public partial class ApplyGlobalConfiguration2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Users",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(2022, 3, 29, 8, 54, 4, 446, DateTimeKind.Local).AddTicks(7451),
                oldClrType: typeof(DateTime),
                oldType: "TEXT",
                oldDefaultValue: new DateTime(2022, 3, 29, 8, 31, 25, 122, DateTimeKind.Local).AddTicks(8788));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Genders",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(2022, 3, 29, 8, 54, 4, 446, DateTimeKind.Local).AddTicks(7293),
                oldClrType: typeof(DateTime),
                oldType: "TEXT",
                oldDefaultValue: new DateTime(2022, 3, 29, 8, 31, 25, 122, DateTimeKind.Local).AddTicks(8529));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Books",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(2022, 3, 29, 8, 54, 4, 446, DateTimeKind.Local).AddTicks(6947),
                oldClrType: typeof(DateTime),
                oldType: "TEXT",
                oldDefaultValue: new DateTime(2022, 3, 29, 8, 31, 25, 122, DateTimeKind.Local).AddTicks(8173));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 29, 8, 54, 4, 446, DateTimeKind.Local).AddTicks(7776));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 29, 8, 54, 4, 446, DateTimeKind.Local).AddTicks(7780));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 29, 8, 54, 4, 446, DateTimeKind.Local).AddTicks(7781));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 29, 8, 54, 4, 446, DateTimeKind.Local).AddTicks(7783));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 29, 8, 54, 4, 446, DateTimeKind.Local).AddTicks(7784));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 29, 8, 54, 4, 446, DateTimeKind.Local).AddTicks(7786));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 29, 8, 54, 4, 446, DateTimeKind.Local).AddTicks(7788));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 29, 8, 54, 4, 446, DateTimeKind.Local).AddTicks(7789));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 29, 8, 54, 4, 446, DateTimeKind.Local).AddTicks(7791));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 29, 8, 54, 4, 446, DateTimeKind.Local).AddTicks(7792));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 29, 8, 54, 4, 446, DateTimeKind.Local).AddTicks(7794));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 29, 8, 54, 4, 446, DateTimeKind.Local).AddTicks(7796));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 29, 8, 54, 4, 446, DateTimeKind.Local).AddTicks(7797));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 29, 8, 54, 4, 446, DateTimeKind.Local).AddTicks(7798));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 29, 8, 54, 4, 446, DateTimeKind.Local).AddTicks(7800));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 29, 8, 54, 4, 446, DateTimeKind.Local).AddTicks(7801));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 29, 8, 54, 4, 446, DateTimeKind.Local).AddTicks(7803));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 29, 8, 54, 4, 446, DateTimeKind.Local).AddTicks(7804));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 29, 8, 54, 4, 446, DateTimeKind.Local).AddTicks(7809));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 29, 8, 54, 4, 446, DateTimeKind.Local).AddTicks(7810));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 29, 8, 54, 4, 446, DateTimeKind.Local).AddTicks(7812));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 29, 8, 54, 4, 446, DateTimeKind.Local).AddTicks(7814));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 29, 8, 54, 4, 446, DateTimeKind.Local).AddTicks(7815));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 29, 8, 54, 4, 446, DateTimeKind.Local).AddTicks(7817));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 29, 8, 54, 4, 446, DateTimeKind.Local).AddTicks(7819));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 29, 8, 54, 4, 446, DateTimeKind.Local).AddTicks(7821));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 29, 8, 54, 4, 446, DateTimeKind.Local).AddTicks(7824));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 29, 8, 54, 4, 446, DateTimeKind.Local).AddTicks(7825));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 29, 8, 54, 4, 446, DateTimeKind.Local).AddTicks(7827));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 29, 8, 54, 4, 446, DateTimeKind.Local).AddTicks(7829));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 29, 8, 54, 4, 446, DateTimeKind.Local).AddTicks(7830));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 29, 8, 54, 4, 446, DateTimeKind.Local).AddTicks(7832));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 29, 8, 54, 4, 446, DateTimeKind.Local).AddTicks(7833));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 29, 8, 54, 4, 446, DateTimeKind.Local).AddTicks(7835));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 29, 8, 54, 4, 446, DateTimeKind.Local).AddTicks(7836));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 29, 8, 54, 4, 446, DateTimeKind.Local).AddTicks(7639));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Users",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(2022, 3, 29, 8, 31, 25, 122, DateTimeKind.Local).AddTicks(8788),
                oldClrType: typeof(DateTime),
                oldType: "TEXT",
                oldDefaultValue: new DateTime(2022, 3, 29, 8, 54, 4, 446, DateTimeKind.Local).AddTicks(7451));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Genders",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(2022, 3, 29, 8, 31, 25, 122, DateTimeKind.Local).AddTicks(8529),
                oldClrType: typeof(DateTime),
                oldType: "TEXT",
                oldDefaultValue: new DateTime(2022, 3, 29, 8, 54, 4, 446, DateTimeKind.Local).AddTicks(7293));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Books",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(2022, 3, 29, 8, 31, 25, 122, DateTimeKind.Local).AddTicks(8173),
                oldClrType: typeof(DateTime),
                oldType: "TEXT",
                oldDefaultValue: new DateTime(2022, 3, 29, 8, 54, 4, 446, DateTimeKind.Local).AddTicks(6947));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 29, 8, 31, 25, 122, DateTimeKind.Local).AddTicks(9121));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 29, 8, 31, 25, 122, DateTimeKind.Local).AddTicks(9123));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 29, 8, 31, 25, 122, DateTimeKind.Local).AddTicks(9125));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 29, 8, 31, 25, 122, DateTimeKind.Local).AddTicks(9127));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 29, 8, 31, 25, 122, DateTimeKind.Local).AddTicks(9128));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 29, 8, 31, 25, 122, DateTimeKind.Local).AddTicks(9130));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 29, 8, 31, 25, 122, DateTimeKind.Local).AddTicks(9133));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 29, 8, 31, 25, 122, DateTimeKind.Local).AddTicks(9135));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 29, 8, 31, 25, 122, DateTimeKind.Local).AddTicks(9136));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 29, 8, 31, 25, 122, DateTimeKind.Local).AddTicks(9139));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 29, 8, 31, 25, 122, DateTimeKind.Local).AddTicks(9204));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 29, 8, 31, 25, 122, DateTimeKind.Local).AddTicks(9206));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 29, 8, 31, 25, 122, DateTimeKind.Local).AddTicks(9208));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 29, 8, 31, 25, 122, DateTimeKind.Local).AddTicks(9209));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 29, 8, 31, 25, 122, DateTimeKind.Local).AddTicks(9211));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 29, 8, 31, 25, 122, DateTimeKind.Local).AddTicks(9212));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 29, 8, 31, 25, 122, DateTimeKind.Local).AddTicks(9213));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 29, 8, 31, 25, 122, DateTimeKind.Local).AddTicks(9215));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 29, 8, 31, 25, 122, DateTimeKind.Local).AddTicks(9216));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 29, 8, 31, 25, 122, DateTimeKind.Local).AddTicks(9218));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 29, 8, 31, 25, 122, DateTimeKind.Local).AddTicks(9219));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 29, 8, 31, 25, 122, DateTimeKind.Local).AddTicks(9221));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 29, 8, 31, 25, 122, DateTimeKind.Local).AddTicks(9222));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 29, 8, 31, 25, 122, DateTimeKind.Local).AddTicks(9223));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 29, 8, 31, 25, 122, DateTimeKind.Local).AddTicks(9225));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 29, 8, 31, 25, 122, DateTimeKind.Local).AddTicks(9226));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 29, 8, 31, 25, 122, DateTimeKind.Local).AddTicks(9228));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 29, 8, 31, 25, 122, DateTimeKind.Local).AddTicks(9229));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 29, 8, 31, 25, 122, DateTimeKind.Local).AddTicks(9231));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 29, 8, 31, 25, 122, DateTimeKind.Local).AddTicks(9232));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 29, 8, 31, 25, 122, DateTimeKind.Local).AddTicks(9234));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 29, 8, 31, 25, 122, DateTimeKind.Local).AddTicks(9235));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 29, 8, 31, 25, 122, DateTimeKind.Local).AddTicks(9236));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 29, 8, 31, 25, 122, DateTimeKind.Local).AddTicks(9238));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 29, 8, 31, 25, 122, DateTimeKind.Local).AddTicks(9239));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 29, 8, 31, 25, 122, DateTimeKind.Local).AddTicks(8977));
        }
    }
}
