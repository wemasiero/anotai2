using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Anotai.Data.Migrations
{
    public partial class relationshipentity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Users",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(2022, 3, 29, 8, 31, 25, 122, DateTimeKind.Local).AddTicks(8788),
                oldClrType: typeof(DateTime),
                oldType: "TEXT",
                oldDefaultValue: new DateTime(2022, 3, 28, 15, 47, 19, 850, DateTimeKind.Local).AddTicks(2725));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Genders",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(2022, 3, 29, 8, 31, 25, 122, DateTimeKind.Local).AddTicks(8529),
                oldClrType: typeof(DateTime),
                oldType: "TEXT",
                oldDefaultValue: new DateTime(2022, 3, 28, 15, 47, 19, 850, DateTimeKind.Local).AddTicks(2541));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Books",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(2022, 3, 29, 8, 31, 25, 122, DateTimeKind.Local).AddTicks(8173),
                oldClrType: typeof(DateTime),
                oldType: "TEXT",
                oldDefaultValue: new DateTime(2022, 3, 28, 15, 47, 19, 850, DateTimeKind.Local).AddTicks(2182));

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Users",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(2022, 3, 28, 15, 47, 19, 850, DateTimeKind.Local).AddTicks(2725),
                oldClrType: typeof(DateTime),
                oldType: "TEXT",
                oldDefaultValue: new DateTime(2022, 3, 29, 8, 31, 25, 122, DateTimeKind.Local).AddTicks(8788));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Genders",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(2022, 3, 28, 15, 47, 19, 850, DateTimeKind.Local).AddTicks(2541),
                oldClrType: typeof(DateTime),
                oldType: "TEXT",
                oldDefaultValue: new DateTime(2022, 3, 29, 8, 31, 25, 122, DateTimeKind.Local).AddTicks(8529));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Books",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(2022, 3, 28, 15, 47, 19, 850, DateTimeKind.Local).AddTicks(2182),
                oldClrType: typeof(DateTime),
                oldType: "TEXT",
                oldDefaultValue: new DateTime(2022, 3, 29, 8, 31, 25, 122, DateTimeKind.Local).AddTicks(8173));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 28, 15, 47, 19, 850, DateTimeKind.Local).AddTicks(3054));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 28, 15, 47, 19, 850, DateTimeKind.Local).AddTicks(3057));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 28, 15, 47, 19, 850, DateTimeKind.Local).AddTicks(3059));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 28, 15, 47, 19, 850, DateTimeKind.Local).AddTicks(3061));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 28, 15, 47, 19, 850, DateTimeKind.Local).AddTicks(3062));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 28, 15, 47, 19, 850, DateTimeKind.Local).AddTicks(3063));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 28, 15, 47, 19, 850, DateTimeKind.Local).AddTicks(3065));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 28, 15, 47, 19, 850, DateTimeKind.Local).AddTicks(3067));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 28, 15, 47, 19, 850, DateTimeKind.Local).AddTicks(3068));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 28, 15, 47, 19, 850, DateTimeKind.Local).AddTicks(3070));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 28, 15, 47, 19, 850, DateTimeKind.Local).AddTicks(3071));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 28, 15, 47, 19, 850, DateTimeKind.Local).AddTicks(3073));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 28, 15, 47, 19, 850, DateTimeKind.Local).AddTicks(3074));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 28, 15, 47, 19, 850, DateTimeKind.Local).AddTicks(3076));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 28, 15, 47, 19, 850, DateTimeKind.Local).AddTicks(3077));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 28, 15, 47, 19, 850, DateTimeKind.Local).AddTicks(3078));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 28, 15, 47, 19, 850, DateTimeKind.Local).AddTicks(3080));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 28, 15, 47, 19, 850, DateTimeKind.Local).AddTicks(3081));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 28, 15, 47, 19, 850, DateTimeKind.Local).AddTicks(3082));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 28, 15, 47, 19, 850, DateTimeKind.Local).AddTicks(3084));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 28, 15, 47, 19, 850, DateTimeKind.Local).AddTicks(3085));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 28, 15, 47, 19, 850, DateTimeKind.Local).AddTicks(3087));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 28, 15, 47, 19, 850, DateTimeKind.Local).AddTicks(3089));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 28, 15, 47, 19, 850, DateTimeKind.Local).AddTicks(3090));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 28, 15, 47, 19, 850, DateTimeKind.Local).AddTicks(3092));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 28, 15, 47, 19, 850, DateTimeKind.Local).AddTicks(3093));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 28, 15, 47, 19, 850, DateTimeKind.Local).AddTicks(3095));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 28, 15, 47, 19, 850, DateTimeKind.Local).AddTicks(3096));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 28, 15, 47, 19, 850, DateTimeKind.Local).AddTicks(3097));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 28, 15, 47, 19, 850, DateTimeKind.Local).AddTicks(3099));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 28, 15, 47, 19, 850, DateTimeKind.Local).AddTicks(3100));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 28, 15, 47, 19, 850, DateTimeKind.Local).AddTicks(3102));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 28, 15, 47, 19, 850, DateTimeKind.Local).AddTicks(3103));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 28, 15, 47, 19, 850, DateTimeKind.Local).AddTicks(3104));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 28, 15, 47, 19, 850, DateTimeKind.Local).AddTicks(3106));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 28, 15, 47, 19, 850, DateTimeKind.Local).AddTicks(2915));
        }
    }
}
