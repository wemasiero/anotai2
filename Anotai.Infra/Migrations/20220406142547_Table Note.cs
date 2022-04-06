using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Anotai.Data.Migrations
{
    public partial class TableNote : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Users",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(2022, 4, 6, 11, 25, 47, 179, DateTimeKind.Local).AddTicks(7468),
                oldClrType: typeof(DateTime),
                oldType: "TEXT",
                oldDefaultValue: new DateTime(2022, 4, 2, 11, 30, 37, 150, DateTimeKind.Local).AddTicks(664));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Genders",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(2022, 4, 6, 11, 25, 47, 179, DateTimeKind.Local).AddTicks(7069),
                oldClrType: typeof(DateTime),
                oldType: "TEXT",
                oldDefaultValue: new DateTime(2022, 4, 2, 11, 30, 37, 150, DateTimeKind.Local).AddTicks(497));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Books",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(2022, 4, 6, 11, 25, 47, 179, DateTimeKind.Local).AddTicks(6741),
                oldClrType: typeof(DateTime),
                oldType: "TEXT",
                oldDefaultValue: new DateTime(2022, 4, 2, 11, 30, 37, 150, DateTimeKind.Local).AddTicks(65));

            migrationBuilder.CreateTable(
                name: "Notes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Annotation = table.Column<string>(type: "TEXT", maxLength: 500, nullable: false),
                    Reference = table.Column<string>(type: "TEXT", nullable: true),
                    BookId = table.Column<int>(type: "INTEGER", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false, defaultValue: new DateTime(2022, 4, 6, 11, 25, 47, 179, DateTimeKind.Local).AddTicks(7218)),
                    UpdatedAt = table.Column<DateTime>(type: "TEXT", nullable: true),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Notes_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 6, 11, 25, 47, 179, DateTimeKind.Local).AddTicks(7793));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 6, 11, 25, 47, 179, DateTimeKind.Local).AddTicks(7795));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 6, 11, 25, 47, 179, DateTimeKind.Local).AddTicks(7797));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 6, 11, 25, 47, 179, DateTimeKind.Local).AddTicks(7798));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 6, 11, 25, 47, 179, DateTimeKind.Local).AddTicks(7799));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 6, 11, 25, 47, 179, DateTimeKind.Local).AddTicks(7800));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 6, 11, 25, 47, 179, DateTimeKind.Local).AddTicks(7802));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 6, 11, 25, 47, 179, DateTimeKind.Local).AddTicks(7803));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 6, 11, 25, 47, 179, DateTimeKind.Local).AddTicks(7804));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 6, 11, 25, 47, 179, DateTimeKind.Local).AddTicks(7805));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 6, 11, 25, 47, 179, DateTimeKind.Local).AddTicks(7806));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 6, 11, 25, 47, 179, DateTimeKind.Local).AddTicks(7808));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 6, 11, 25, 47, 179, DateTimeKind.Local).AddTicks(7809));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 6, 11, 25, 47, 179, DateTimeKind.Local).AddTicks(7810));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 6, 11, 25, 47, 179, DateTimeKind.Local).AddTicks(7812));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 6, 11, 25, 47, 179, DateTimeKind.Local).AddTicks(7813));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 6, 11, 25, 47, 179, DateTimeKind.Local).AddTicks(7814));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 6, 11, 25, 47, 179, DateTimeKind.Local).AddTicks(7816));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 6, 11, 25, 47, 179, DateTimeKind.Local).AddTicks(7817));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 6, 11, 25, 47, 179, DateTimeKind.Local).AddTicks(7818));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 6, 11, 25, 47, 179, DateTimeKind.Local).AddTicks(7819));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 6, 11, 25, 47, 179, DateTimeKind.Local).AddTicks(7820));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 6, 11, 25, 47, 179, DateTimeKind.Local).AddTicks(7822));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 6, 11, 25, 47, 179, DateTimeKind.Local).AddTicks(7823));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 6, 11, 25, 47, 179, DateTimeKind.Local).AddTicks(7917));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 6, 11, 25, 47, 179, DateTimeKind.Local).AddTicks(7919));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 6, 11, 25, 47, 179, DateTimeKind.Local).AddTicks(7920));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 6, 11, 25, 47, 179, DateTimeKind.Local).AddTicks(7922));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 6, 11, 25, 47, 179, DateTimeKind.Local).AddTicks(7923));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 6, 11, 25, 47, 179, DateTimeKind.Local).AddTicks(7924));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 6, 11, 25, 47, 179, DateTimeKind.Local).AddTicks(7925));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 6, 11, 25, 47, 179, DateTimeKind.Local).AddTicks(7926));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 6, 11, 25, 47, 179, DateTimeKind.Local).AddTicks(7946));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 6, 11, 25, 47, 179, DateTimeKind.Local).AddTicks(7947));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 6, 11, 25, 47, 179, DateTimeKind.Local).AddTicks(7949));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 4, 6, 11, 25, 47, 179, DateTimeKind.Local).AddTicks(7628));

            migrationBuilder.CreateIndex(
                name: "IX_Notes_BookId",
                table: "Notes",
                column: "BookId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Notes");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Users",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(2022, 4, 2, 11, 30, 37, 150, DateTimeKind.Local).AddTicks(664),
                oldClrType: typeof(DateTime),
                oldType: "TEXT",
                oldDefaultValue: new DateTime(2022, 4, 6, 11, 25, 47, 179, DateTimeKind.Local).AddTicks(7468));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Genders",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(2022, 4, 2, 11, 30, 37, 150, DateTimeKind.Local).AddTicks(497),
                oldClrType: typeof(DateTime),
                oldType: "TEXT",
                oldDefaultValue: new DateTime(2022, 4, 6, 11, 25, 47, 179, DateTimeKind.Local).AddTicks(7069));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Books",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(2022, 4, 2, 11, 30, 37, 150, DateTimeKind.Local).AddTicks(65),
                oldClrType: typeof(DateTime),
                oldType: "TEXT",
                oldDefaultValue: new DateTime(2022, 4, 6, 11, 25, 47, 179, DateTimeKind.Local).AddTicks(6741));

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
    }
}
