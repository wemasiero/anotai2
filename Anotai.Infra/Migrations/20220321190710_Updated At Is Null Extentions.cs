using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Anotai.Data.Migrations
{
    public partial class UpdatedAtIsNullExtentions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Genders",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(2022, 3, 21, 16, 7, 10, 533, DateTimeKind.Local).AddTicks(2502),
                oldClrType: typeof(DateTime),
                oldType: "TEXT",
                oldDefaultValue: new DateTime(2022, 3, 18, 11, 12, 11, 671, DateTimeKind.Local).AddTicks(5239));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 21, 16, 7, 10, 533, DateTimeKind.Local).AddTicks(2786));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 21, 16, 7, 10, 533, DateTimeKind.Local).AddTicks(2792));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 21, 16, 7, 10, 533, DateTimeKind.Local).AddTicks(2793));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 21, 16, 7, 10, 533, DateTimeKind.Local).AddTicks(2795));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 21, 16, 7, 10, 533, DateTimeKind.Local).AddTicks(2796));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 21, 16, 7, 10, 533, DateTimeKind.Local).AddTicks(2798));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 21, 16, 7, 10, 533, DateTimeKind.Local).AddTicks(2799));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 21, 16, 7, 10, 533, DateTimeKind.Local).AddTicks(2801));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 21, 16, 7, 10, 533, DateTimeKind.Local).AddTicks(2802));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 21, 16, 7, 10, 533, DateTimeKind.Local).AddTicks(2803));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 21, 16, 7, 10, 533, DateTimeKind.Local).AddTicks(2805));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 21, 16, 7, 10, 533, DateTimeKind.Local).AddTicks(2806));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 21, 16, 7, 10, 533, DateTimeKind.Local).AddTicks(2808));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 21, 16, 7, 10, 533, DateTimeKind.Local).AddTicks(2809));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 21, 16, 7, 10, 533, DateTimeKind.Local).AddTicks(2811));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 21, 16, 7, 10, 533, DateTimeKind.Local).AddTicks(2812));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 21, 16, 7, 10, 533, DateTimeKind.Local).AddTicks(2814));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 21, 16, 7, 10, 533, DateTimeKind.Local).AddTicks(2815));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 21, 16, 7, 10, 533, DateTimeKind.Local).AddTicks(2816));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 21, 16, 7, 10, 533, DateTimeKind.Local).AddTicks(2818));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 21, 16, 7, 10, 533, DateTimeKind.Local).AddTicks(2819));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 21, 16, 7, 10, 533, DateTimeKind.Local).AddTicks(2821));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 21, 16, 7, 10, 533, DateTimeKind.Local).AddTicks(2822));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 21, 16, 7, 10, 533, DateTimeKind.Local).AddTicks(2823));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedAt", "Description" },
                values: new object[] { new DateTime(2022, 3, 21, 16, 7, 10, 533, DateTimeKind.Local).AddTicks(2825), "LGBTQ+" });

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedAt", "Description" },
                values: new object[] { new DateTime(2022, 3, 21, 16, 7, 10, 533, DateTimeKind.Local).AddTicks(2826), "MEMÓRIAS E AUTOBIOGRAFIA" });

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedAt", "Description" },
                values: new object[] { new DateTime(2022, 3, 21, 16, 7, 10, 533, DateTimeKind.Local).AddTicks(2829), "NEW ADULT – NOVO ADULTO " });

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedAt", "Description" },
                values: new object[] { new DateTime(2022, 3, 21, 16, 7, 10, 533, DateTimeKind.Local).AddTicks(2830), "PATERNIDADE E FAMÍLIA" });

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedAt", "Description" },
                values: new object[] { new DateTime(2022, 3, 21, 16, 7, 10, 533, DateTimeKind.Local).AddTicks(2831), "REALISMO MÁGICO" });

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedAt", "Description" },
                values: new object[] { new DateTime(2022, 3, 21, 16, 7, 10, 533, DateTimeKind.Local).AddTicks(2833), "RELIGIÃO E ESPIRITUALIDADE" });

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedAt", "Description" },
                values: new object[] { new DateTime(2022, 3, 21, 16, 7, 10, 533, DateTimeKind.Local).AddTicks(2834), "ROMANCE" });

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedAt", "Description" },
                values: new object[] { new DateTime(2022, 3, 21, 16, 7, 10, 533, DateTimeKind.Local).AddTicks(2835), "TECNOLOGIA E CIÊNCIA" });

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedAt", "Description" },
                values: new object[] { new DateTime(2022, 3, 21, 16, 7, 10, 533, DateTimeKind.Local).AddTicks(2837), "THRILLER E SUSPENSE" });

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedAt", "Description" },
                values: new object[] { new DateTime(2022, 3, 21, 16, 7, 10, 533, DateTimeKind.Local).AddTicks(2838), "VIAJEM" });

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedAt", "Description" },
                values: new object[] { new DateTime(2022, 3, 21, 16, 7, 10, 533, DateTimeKind.Local).AddTicks(2839), "YOUNG ADULT – JOVEM ADULTO" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Genders",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(2022, 3, 18, 11, 12, 11, 671, DateTimeKind.Local).AddTicks(5239),
                oldClrType: typeof(DateTime),
                oldType: "TEXT",
                oldDefaultValue: new DateTime(2022, 3, 21, 16, 7, 10, 533, DateTimeKind.Local).AddTicks(2502));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 18, 11, 12, 11, 671, DateTimeKind.Local).AddTicks(5756));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 18, 11, 12, 11, 671, DateTimeKind.Local).AddTicks(5765));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 18, 11, 12, 11, 671, DateTimeKind.Local).AddTicks(5768));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 18, 11, 12, 11, 671, DateTimeKind.Local).AddTicks(5770));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 18, 11, 12, 11, 671, DateTimeKind.Local).AddTicks(5773));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 18, 11, 12, 11, 671, DateTimeKind.Local).AddTicks(5775));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 18, 11, 12, 11, 671, DateTimeKind.Local).AddTicks(5778));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 18, 11, 12, 11, 671, DateTimeKind.Local).AddTicks(5781));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 18, 11, 12, 11, 671, DateTimeKind.Local).AddTicks(5783));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 18, 11, 12, 11, 671, DateTimeKind.Local).AddTicks(5785));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 18, 11, 12, 11, 671, DateTimeKind.Local).AddTicks(5788));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 18, 11, 12, 11, 671, DateTimeKind.Local).AddTicks(5790));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 18, 11, 12, 11, 671, DateTimeKind.Local).AddTicks(5792));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 18, 11, 12, 11, 671, DateTimeKind.Local).AddTicks(5795));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 18, 11, 12, 11, 671, DateTimeKind.Local).AddTicks(5797));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 18, 11, 12, 11, 671, DateTimeKind.Local).AddTicks(5799));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 18, 11, 12, 11, 671, DateTimeKind.Local).AddTicks(5802));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 18, 11, 12, 11, 671, DateTimeKind.Local).AddTicks(5805));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 18, 11, 12, 11, 671, DateTimeKind.Local).AddTicks(5807));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 18, 11, 12, 11, 671, DateTimeKind.Local).AddTicks(5810));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 18, 11, 12, 11, 671, DateTimeKind.Local).AddTicks(5813));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 18, 11, 12, 11, 671, DateTimeKind.Local).AddTicks(5815));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 18, 11, 12, 11, 671, DateTimeKind.Local).AddTicks(5818));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2022, 3, 18, 11, 12, 11, 671, DateTimeKind.Local).AddTicks(5820));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedAt", "Description" },
                values: new object[] { new DateTime(2022, 3, 18, 11, 12, 11, 671, DateTimeKind.Local).AddTicks(5823), "INFANTIL" });

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedAt", "Description" },
                values: new object[] { new DateTime(2022, 3, 18, 11, 12, 11, 671, DateTimeKind.Local).AddTicks(5825), "LGBTQ+" });

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedAt", "Description" },
                values: new object[] { new DateTime(2022, 3, 18, 11, 12, 11, 671, DateTimeKind.Local).AddTicks(5827), "MEMÓRIAS E AUTOBIOGRAFIA" });

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedAt", "Description" },
                values: new object[] { new DateTime(2022, 3, 18, 11, 12, 11, 671, DateTimeKind.Local).AddTicks(5830), "NEW ADULT – NOVO ADULTO " });

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedAt", "Description" },
                values: new object[] { new DateTime(2022, 3, 18, 11, 12, 11, 671, DateTimeKind.Local).AddTicks(5832), "PATERNIDADE E FAMÍLIA" });

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedAt", "Description" },
                values: new object[] { new DateTime(2022, 3, 18, 11, 12, 11, 671, DateTimeKind.Local).AddTicks(5834), "REALISMO MÁGICO" });

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedAt", "Description" },
                values: new object[] { new DateTime(2022, 3, 18, 11, 12, 11, 671, DateTimeKind.Local).AddTicks(5836), "RELIGIÃO E ESPIRITUALIDADE" });

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedAt", "Description" },
                values: new object[] { new DateTime(2022, 3, 18, 11, 12, 11, 671, DateTimeKind.Local).AddTicks(5839), "ROMANCE" });

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedAt", "Description" },
                values: new object[] { new DateTime(2022, 3, 18, 11, 12, 11, 671, DateTimeKind.Local).AddTicks(5841), "TECNOLOGIA E CIÊNCIA" });

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedAt", "Description" },
                values: new object[] { new DateTime(2022, 3, 18, 11, 12, 11, 671, DateTimeKind.Local).AddTicks(5844), "THRILLER E SUSPENSE" });

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedAt", "Description" },
                values: new object[] { new DateTime(2022, 3, 18, 11, 12, 11, 671, DateTimeKind.Local).AddTicks(5847), "VIAJEM" });

            migrationBuilder.InsertData(
                table: "Genders",
                columns: new[] { "Id", "CreatedAt", "Description", "IsDeleted", "UpdatedAt" },
                values: new object[] { 36, new DateTime(2022, 3, 18, 11, 12, 11, 671, DateTimeKind.Local).AddTicks(5849), "YOUNG ADULT – JOVEM ADULTO", false, null });
        }
    }
}
