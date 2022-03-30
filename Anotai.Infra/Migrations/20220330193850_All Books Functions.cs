using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Anotai.Data.Migrations
{
    public partial class AllBooksFunctions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Users",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(2022, 3, 30, 16, 38, 50, 118, DateTimeKind.Local).AddTicks(6669),
                oldClrType: typeof(DateTime),
                oldType: "TEXT",
                oldDefaultValue: new DateTime(2022, 3, 29, 8, 54, 4, 446, DateTimeKind.Local).AddTicks(7451));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Genders",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(2022, 3, 30, 16, 38, 50, 118, DateTimeKind.Local).AddTicks(6497),
                oldClrType: typeof(DateTime),
                oldType: "TEXT",
                oldDefaultValue: new DateTime(2022, 3, 29, 8, 54, 4, 446, DateTimeKind.Local).AddTicks(7293));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Books",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(2022, 3, 30, 16, 38, 50, 118, DateTimeKind.Local).AddTicks(6143),
                oldClrType: typeof(DateTime),
                oldType: "TEXT",
                oldDefaultValue: new DateTime(2022, 3, 29, 8, 54, 4, 446, DateTimeKind.Local).AddTicks(6947));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 30, 16, 38, 50, 118, DateTimeKind.Local).AddTicks(7005));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 30, 16, 38, 50, 118, DateTimeKind.Local).AddTicks(7007));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 30, 16, 38, 50, 118, DateTimeKind.Local).AddTicks(7010));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 30, 16, 38, 50, 118, DateTimeKind.Local).AddTicks(7011));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 30, 16, 38, 50, 118, DateTimeKind.Local).AddTicks(7012));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 30, 16, 38, 50, 118, DateTimeKind.Local).AddTicks(7014));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 30, 16, 38, 50, 118, DateTimeKind.Local).AddTicks(7016));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 30, 16, 38, 50, 118, DateTimeKind.Local).AddTicks(7017));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 30, 16, 38, 50, 118, DateTimeKind.Local).AddTicks(7018));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 30, 16, 38, 50, 118, DateTimeKind.Local).AddTicks(7020));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 30, 16, 38, 50, 118, DateTimeKind.Local).AddTicks(7021));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 30, 16, 38, 50, 118, DateTimeKind.Local).AddTicks(7023));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 30, 16, 38, 50, 118, DateTimeKind.Local).AddTicks(7024));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 30, 16, 38, 50, 118, DateTimeKind.Local).AddTicks(7026));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 30, 16, 38, 50, 118, DateTimeKind.Local).AddTicks(7027));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 30, 16, 38, 50, 118, DateTimeKind.Local).AddTicks(7028));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 30, 16, 38, 50, 118, DateTimeKind.Local).AddTicks(7030));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 30, 16, 38, 50, 118, DateTimeKind.Local).AddTicks(7031));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 30, 16, 38, 50, 118, DateTimeKind.Local).AddTicks(7032));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 30, 16, 38, 50, 118, DateTimeKind.Local).AddTicks(7034));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 30, 16, 38, 50, 118, DateTimeKind.Local).AddTicks(7036));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 30, 16, 38, 50, 118, DateTimeKind.Local).AddTicks(7037));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 30, 16, 38, 50, 118, DateTimeKind.Local).AddTicks(7038));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 30, 16, 38, 50, 118, DateTimeKind.Local).AddTicks(7040));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 30, 16, 38, 50, 118, DateTimeKind.Local).AddTicks(7041));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 30, 16, 38, 50, 118, DateTimeKind.Local).AddTicks(7042));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 30, 16, 38, 50, 118, DateTimeKind.Local).AddTicks(7044));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 30, 16, 38, 50, 118, DateTimeKind.Local).AddTicks(7045));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 30, 16, 38, 50, 118, DateTimeKind.Local).AddTicks(7046));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 30, 16, 38, 50, 118, DateTimeKind.Local).AddTicks(7048));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 30, 16, 38, 50, 118, DateTimeKind.Local).AddTicks(7049));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 30, 16, 38, 50, 118, DateTimeKind.Local).AddTicks(7051));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 30, 16, 38, 50, 118, DateTimeKind.Local).AddTicks(7052));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 30, 16, 38, 50, 118, DateTimeKind.Local).AddTicks(7053));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 30, 16, 38, 50, 118, DateTimeKind.Local).AddTicks(7055));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 30, 16, 38, 50, 118, DateTimeKind.Local).AddTicks(6861));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Users",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(2022, 3, 29, 8, 54, 4, 446, DateTimeKind.Local).AddTicks(7451),
                oldClrType: typeof(DateTime),
                oldType: "TEXT",
                oldDefaultValue: new DateTime(2022, 3, 30, 16, 38, 50, 118, DateTimeKind.Local).AddTicks(6669));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Genders",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(2022, 3, 29, 8, 54, 4, 446, DateTimeKind.Local).AddTicks(7293),
                oldClrType: typeof(DateTime),
                oldType: "TEXT",
                oldDefaultValue: new DateTime(2022, 3, 30, 16, 38, 50, 118, DateTimeKind.Local).AddTicks(6497));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Books",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(2022, 3, 29, 8, 54, 4, 446, DateTimeKind.Local).AddTicks(6947),
                oldClrType: typeof(DateTime),
                oldType: "TEXT",
                oldDefaultValue: new DateTime(2022, 3, 30, 16, 38, 50, 118, DateTimeKind.Local).AddTicks(6143));

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
    }
}
