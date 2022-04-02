using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Anotai.Data.Migrations
{
    public partial class UsersGenderBookFull : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Users",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(2022, 4, 2, 11, 30, 37, 150, DateTimeKind.Local).AddTicks(664),
                oldClrType: typeof(DateTime),
                oldType: "TEXT",
                oldDefaultValue: new DateTime(2022, 3, 30, 16, 38, 50, 118, DateTimeKind.Local).AddTicks(6669));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Genders",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(2022, 4, 2, 11, 30, 37, 150, DateTimeKind.Local).AddTicks(497),
                oldClrType: typeof(DateTime),
                oldType: "TEXT",
                oldDefaultValue: new DateTime(2022, 3, 30, 16, 38, 50, 118, DateTimeKind.Local).AddTicks(6497));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Books",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(2022, 4, 2, 11, 30, 37, 150, DateTimeKind.Local).AddTicks(65),
                oldClrType: typeof(DateTime),
                oldType: "TEXT",
                oldDefaultValue: new DateTime(2022, 3, 30, 16, 38, 50, 118, DateTimeKind.Local).AddTicks(6143));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 2, 11, 30, 37, 150, DateTimeKind.Local).AddTicks(1045));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 2, 11, 30, 37, 150, DateTimeKind.Local).AddTicks(1048));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 2, 11, 30, 37, 150, DateTimeKind.Local).AddTicks(1049));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 2, 11, 30, 37, 150, DateTimeKind.Local).AddTicks(1051));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 2, 11, 30, 37, 150, DateTimeKind.Local).AddTicks(1052));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 2, 11, 30, 37, 150, DateTimeKind.Local).AddTicks(1053));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 2, 11, 30, 37, 150, DateTimeKind.Local).AddTicks(1055));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 2, 11, 30, 37, 150, DateTimeKind.Local).AddTicks(1056));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 2, 11, 30, 37, 150, DateTimeKind.Local).AddTicks(1057));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 2, 11, 30, 37, 150, DateTimeKind.Local).AddTicks(1058));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 2, 11, 30, 37, 150, DateTimeKind.Local).AddTicks(1060));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 2, 11, 30, 37, 150, DateTimeKind.Local).AddTicks(1061));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 2, 11, 30, 37, 150, DateTimeKind.Local).AddTicks(1062));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 2, 11, 30, 37, 150, DateTimeKind.Local).AddTicks(1064));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 2, 11, 30, 37, 150, DateTimeKind.Local).AddTicks(1065));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 2, 11, 30, 37, 150, DateTimeKind.Local).AddTicks(1066));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 2, 11, 30, 37, 150, DateTimeKind.Local).AddTicks(1068));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 2, 11, 30, 37, 150, DateTimeKind.Local).AddTicks(1070));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 2, 11, 30, 37, 150, DateTimeKind.Local).AddTicks(1071));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 2, 11, 30, 37, 150, DateTimeKind.Local).AddTicks(1072));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 2, 11, 30, 37, 150, DateTimeKind.Local).AddTicks(1074));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 2, 11, 30, 37, 150, DateTimeKind.Local).AddTicks(1075));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 2, 11, 30, 37, 150, DateTimeKind.Local).AddTicks(1077));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 2, 11, 30, 37, 150, DateTimeKind.Local).AddTicks(1078));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 2, 11, 30, 37, 150, DateTimeKind.Local).AddTicks(1079));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 2, 11, 30, 37, 150, DateTimeKind.Local).AddTicks(1080));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 2, 11, 30, 37, 150, DateTimeKind.Local).AddTicks(1081));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 2, 11, 30, 37, 150, DateTimeKind.Local).AddTicks(1083));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 2, 11, 30, 37, 150, DateTimeKind.Local).AddTicks(1084));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 2, 11, 30, 37, 150, DateTimeKind.Local).AddTicks(1085));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 2, 11, 30, 37, 150, DateTimeKind.Local).AddTicks(1086));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 2, 11, 30, 37, 150, DateTimeKind.Local).AddTicks(1088));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 2, 11, 30, 37, 150, DateTimeKind.Local).AddTicks(1089));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 2, 11, 30, 37, 150, DateTimeKind.Local).AddTicks(1090));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 2, 11, 30, 37, 150, DateTimeKind.Local).AddTicks(1091));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 2, 11, 30, 37, 150, DateTimeKind.Local).AddTicks(893));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Users",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(2022, 3, 30, 16, 38, 50, 118, DateTimeKind.Local).AddTicks(6669),
                oldClrType: typeof(DateTime),
                oldType: "TEXT",
                oldDefaultValue: new DateTime(2022, 4, 2, 11, 30, 37, 150, DateTimeKind.Local).AddTicks(664));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Genders",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(2022, 3, 30, 16, 38, 50, 118, DateTimeKind.Local).AddTicks(6497),
                oldClrType: typeof(DateTime),
                oldType: "TEXT",
                oldDefaultValue: new DateTime(2022, 4, 2, 11, 30, 37, 150, DateTimeKind.Local).AddTicks(497));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Books",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(2022, 3, 30, 16, 38, 50, 118, DateTimeKind.Local).AddTicks(6143),
                oldClrType: typeof(DateTime),
                oldType: "TEXT",
                oldDefaultValue: new DateTime(2022, 4, 2, 11, 30, 37, 150, DateTimeKind.Local).AddTicks(65));

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
    }
}
