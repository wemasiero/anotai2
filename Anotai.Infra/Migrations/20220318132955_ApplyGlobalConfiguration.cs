using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Anotai.Data.Migrations
{
    public partial class ApplyGlobalConfiguration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "Genders",
                type: "INTEGER",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Genders",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(2022, 3, 18, 10, 29, 55, 531, DateTimeKind.Local).AddTicks(4166),
                oldClrType: typeof(DateTime),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 3, 18, 10, 29, 55, 531, DateTimeKind.Local).AddTicks(4672), new DateTime(2022, 3, 18, 10, 29, 55, 531, DateTimeKind.Local).AddTicks(4678) });

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 3, 18, 10, 29, 55, 531, DateTimeKind.Local).AddTicks(4681), new DateTime(2022, 3, 18, 10, 29, 55, 531, DateTimeKind.Local).AddTicks(4681) });

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 3, 18, 10, 29, 55, 531, DateTimeKind.Local).AddTicks(4683), new DateTime(2022, 3, 18, 10, 29, 55, 531, DateTimeKind.Local).AddTicks(4684) });

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 3, 18, 10, 29, 55, 531, DateTimeKind.Local).AddTicks(4685), new DateTime(2022, 3, 18, 10, 29, 55, 531, DateTimeKind.Local).AddTicks(4686) });

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 3, 18, 10, 29, 55, 531, DateTimeKind.Local).AddTicks(4687), new DateTime(2022, 3, 18, 10, 29, 55, 531, DateTimeKind.Local).AddTicks(4688) });

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 3, 18, 10, 29, 55, 531, DateTimeKind.Local).AddTicks(4689), new DateTime(2022, 3, 18, 10, 29, 55, 531, DateTimeKind.Local).AddTicks(4690) });

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 3, 18, 10, 29, 55, 531, DateTimeKind.Local).AddTicks(4691), new DateTime(2022, 3, 18, 10, 29, 55, 531, DateTimeKind.Local).AddTicks(4692) });

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 3, 18, 10, 29, 55, 531, DateTimeKind.Local).AddTicks(4694), new DateTime(2022, 3, 18, 10, 29, 55, 531, DateTimeKind.Local).AddTicks(4694) });

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 3, 18, 10, 29, 55, 531, DateTimeKind.Local).AddTicks(4696), new DateTime(2022, 3, 18, 10, 29, 55, 531, DateTimeKind.Local).AddTicks(4697) });

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 3, 18, 10, 29, 55, 531, DateTimeKind.Local).AddTicks(4698), new DateTime(2022, 3, 18, 10, 29, 55, 531, DateTimeKind.Local).AddTicks(4699) });

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 3, 18, 10, 29, 55, 531, DateTimeKind.Local).AddTicks(4700), new DateTime(2022, 3, 18, 10, 29, 55, 531, DateTimeKind.Local).AddTicks(4701) });

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 3, 18, 10, 29, 55, 531, DateTimeKind.Local).AddTicks(4702), new DateTime(2022, 3, 18, 10, 29, 55, 531, DateTimeKind.Local).AddTicks(4703) });

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 3, 18, 10, 29, 55, 531, DateTimeKind.Local).AddTicks(4704), new DateTime(2022, 3, 18, 10, 29, 55, 531, DateTimeKind.Local).AddTicks(4705) });

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 3, 18, 10, 29, 55, 531, DateTimeKind.Local).AddTicks(4706), new DateTime(2022, 3, 18, 10, 29, 55, 531, DateTimeKind.Local).AddTicks(4707) });

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 3, 18, 10, 29, 55, 531, DateTimeKind.Local).AddTicks(4708), new DateTime(2022, 3, 18, 10, 29, 55, 531, DateTimeKind.Local).AddTicks(4709) });

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 3, 18, 10, 29, 55, 531, DateTimeKind.Local).AddTicks(4710), new DateTime(2022, 3, 18, 10, 29, 55, 531, DateTimeKind.Local).AddTicks(4711) });

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 3, 18, 10, 29, 55, 531, DateTimeKind.Local).AddTicks(4713), new DateTime(2022, 3, 18, 10, 29, 55, 531, DateTimeKind.Local).AddTicks(4713) });

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 3, 18, 10, 29, 55, 531, DateTimeKind.Local).AddTicks(4715), new DateTime(2022, 3, 18, 10, 29, 55, 531, DateTimeKind.Local).AddTicks(4715) });

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 3, 18, 10, 29, 55, 531, DateTimeKind.Local).AddTicks(4717), new DateTime(2022, 3, 18, 10, 29, 55, 531, DateTimeKind.Local).AddTicks(4717) });

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 3, 18, 10, 29, 55, 531, DateTimeKind.Local).AddTicks(4719), new DateTime(2022, 3, 18, 10, 29, 55, 531, DateTimeKind.Local).AddTicks(4720) });

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 3, 18, 10, 29, 55, 531, DateTimeKind.Local).AddTicks(4721), new DateTime(2022, 3, 18, 10, 29, 55, 531, DateTimeKind.Local).AddTicks(4723) });

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 3, 18, 10, 29, 55, 531, DateTimeKind.Local).AddTicks(4724), new DateTime(2022, 3, 18, 10, 29, 55, 531, DateTimeKind.Local).AddTicks(4725) });

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 3, 18, 10, 29, 55, 531, DateTimeKind.Local).AddTicks(4726), new DateTime(2022, 3, 18, 10, 29, 55, 531, DateTimeKind.Local).AddTicks(4727) });

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 3, 18, 10, 29, 55, 531, DateTimeKind.Local).AddTicks(4728), new DateTime(2022, 3, 18, 10, 29, 55, 531, DateTimeKind.Local).AddTicks(4729) });

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 3, 18, 10, 29, 55, 531, DateTimeKind.Local).AddTicks(4730), new DateTime(2022, 3, 18, 10, 29, 55, 531, DateTimeKind.Local).AddTicks(4731) });

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 3, 18, 10, 29, 55, 531, DateTimeKind.Local).AddTicks(4732), new DateTime(2022, 3, 18, 10, 29, 55, 531, DateTimeKind.Local).AddTicks(4733) });

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 3, 18, 10, 29, 55, 531, DateTimeKind.Local).AddTicks(4734), new DateTime(2022, 3, 18, 10, 29, 55, 531, DateTimeKind.Local).AddTicks(4735) });

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 3, 18, 10, 29, 55, 531, DateTimeKind.Local).AddTicks(4736), new DateTime(2022, 3, 18, 10, 29, 55, 531, DateTimeKind.Local).AddTicks(4737) });

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 3, 18, 10, 29, 55, 531, DateTimeKind.Local).AddTicks(4738), new DateTime(2022, 3, 18, 10, 29, 55, 531, DateTimeKind.Local).AddTicks(4739) });

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 3, 18, 10, 29, 55, 531, DateTimeKind.Local).AddTicks(4740), new DateTime(2022, 3, 18, 10, 29, 55, 531, DateTimeKind.Local).AddTicks(4741) });

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 3, 18, 10, 29, 55, 531, DateTimeKind.Local).AddTicks(4742), new DateTime(2022, 3, 18, 10, 29, 55, 531, DateTimeKind.Local).AddTicks(4743) });

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 3, 18, 10, 29, 55, 531, DateTimeKind.Local).AddTicks(4744), new DateTime(2022, 3, 18, 10, 29, 55, 531, DateTimeKind.Local).AddTicks(4745) });

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 3, 18, 10, 29, 55, 531, DateTimeKind.Local).AddTicks(4746), new DateTime(2022, 3, 18, 10, 29, 55, 531, DateTimeKind.Local).AddTicks(4747) });

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 3, 18, 10, 29, 55, 531, DateTimeKind.Local).AddTicks(4748), new DateTime(2022, 3, 18, 10, 29, 55, 531, DateTimeKind.Local).AddTicks(4749) });

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 3, 18, 10, 29, 55, 531, DateTimeKind.Local).AddTicks(4750), new DateTime(2022, 3, 18, 10, 29, 55, 531, DateTimeKind.Local).AddTicks(4751) });

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 3, 18, 10, 29, 55, 531, DateTimeKind.Local).AddTicks(4753), new DateTime(2022, 3, 18, 10, 29, 55, 531, DateTimeKind.Local).AddTicks(4753) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "Genders",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "INTEGER",
                oldDefaultValue: false);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Genders",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "TEXT",
                oldDefaultValue: new DateTime(2022, 3, 18, 10, 29, 55, 531, DateTimeKind.Local).AddTicks(4166));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 3, 18, 8, 36, 53, 577, DateTimeKind.Local).AddTicks(4978), new DateTime(2022, 3, 18, 8, 36, 53, 577, DateTimeKind.Local).AddTicks(4988) });

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 3, 18, 8, 36, 53, 577, DateTimeKind.Local).AddTicks(4991), new DateTime(2022, 3, 18, 8, 36, 53, 577, DateTimeKind.Local).AddTicks(4992) });

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 3, 18, 8, 36, 53, 577, DateTimeKind.Local).AddTicks(4993), new DateTime(2022, 3, 18, 8, 36, 53, 577, DateTimeKind.Local).AddTicks(4994) });

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 3, 18, 8, 36, 53, 577, DateTimeKind.Local).AddTicks(4995), new DateTime(2022, 3, 18, 8, 36, 53, 577, DateTimeKind.Local).AddTicks(4996) });

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 3, 18, 8, 36, 53, 577, DateTimeKind.Local).AddTicks(4998), new DateTime(2022, 3, 18, 8, 36, 53, 577, DateTimeKind.Local).AddTicks(4998) });

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 3, 18, 8, 36, 53, 577, DateTimeKind.Local).AddTicks(5000), new DateTime(2022, 3, 18, 8, 36, 53, 577, DateTimeKind.Local).AddTicks(5001) });

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 3, 18, 8, 36, 53, 577, DateTimeKind.Local).AddTicks(5002), new DateTime(2022, 3, 18, 8, 36, 53, 577, DateTimeKind.Local).AddTicks(5003) });

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 3, 18, 8, 36, 53, 577, DateTimeKind.Local).AddTicks(5004), new DateTime(2022, 3, 18, 8, 36, 53, 577, DateTimeKind.Local).AddTicks(5005) });

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 3, 18, 8, 36, 53, 577, DateTimeKind.Local).AddTicks(5006), new DateTime(2022, 3, 18, 8, 36, 53, 577, DateTimeKind.Local).AddTicks(5007) });

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 3, 18, 8, 36, 53, 577, DateTimeKind.Local).AddTicks(5008), new DateTime(2022, 3, 18, 8, 36, 53, 577, DateTimeKind.Local).AddTicks(5009) });

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 3, 18, 8, 36, 53, 577, DateTimeKind.Local).AddTicks(5010), new DateTime(2022, 3, 18, 8, 36, 53, 577, DateTimeKind.Local).AddTicks(5011) });

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 3, 18, 8, 36, 53, 577, DateTimeKind.Local).AddTicks(5012), new DateTime(2022, 3, 18, 8, 36, 53, 577, DateTimeKind.Local).AddTicks(5013) });

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 3, 18, 8, 36, 53, 577, DateTimeKind.Local).AddTicks(5015), new DateTime(2022, 3, 18, 8, 36, 53, 577, DateTimeKind.Local).AddTicks(5016) });

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 3, 18, 8, 36, 53, 577, DateTimeKind.Local).AddTicks(5017), new DateTime(2022, 3, 18, 8, 36, 53, 577, DateTimeKind.Local).AddTicks(5018) });

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 3, 18, 8, 36, 53, 577, DateTimeKind.Local).AddTicks(5020), new DateTime(2022, 3, 18, 8, 36, 53, 577, DateTimeKind.Local).AddTicks(5020) });

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 3, 18, 8, 36, 53, 577, DateTimeKind.Local).AddTicks(5022), new DateTime(2022, 3, 18, 8, 36, 53, 577, DateTimeKind.Local).AddTicks(5022) });

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 3, 18, 8, 36, 53, 577, DateTimeKind.Local).AddTicks(5024), new DateTime(2022, 3, 18, 8, 36, 53, 577, DateTimeKind.Local).AddTicks(5025) });

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 3, 18, 8, 36, 53, 577, DateTimeKind.Local).AddTicks(5026), new DateTime(2022, 3, 18, 8, 36, 53, 577, DateTimeKind.Local).AddTicks(5027) });

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 3, 18, 8, 36, 53, 577, DateTimeKind.Local).AddTicks(5028), new DateTime(2022, 3, 18, 8, 36, 53, 577, DateTimeKind.Local).AddTicks(5029) });

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 3, 18, 8, 36, 53, 577, DateTimeKind.Local).AddTicks(5030), new DateTime(2022, 3, 18, 8, 36, 53, 577, DateTimeKind.Local).AddTicks(5031) });

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 3, 18, 8, 36, 53, 577, DateTimeKind.Local).AddTicks(5032), new DateTime(2022, 3, 18, 8, 36, 53, 577, DateTimeKind.Local).AddTicks(5033) });

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 3, 18, 8, 36, 53, 577, DateTimeKind.Local).AddTicks(5035), new DateTime(2022, 3, 18, 8, 36, 53, 577, DateTimeKind.Local).AddTicks(5035) });

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 3, 18, 8, 36, 53, 577, DateTimeKind.Local).AddTicks(5037), new DateTime(2022, 3, 18, 8, 36, 53, 577, DateTimeKind.Local).AddTicks(5037) });

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 3, 18, 8, 36, 53, 577, DateTimeKind.Local).AddTicks(5039), new DateTime(2022, 3, 18, 8, 36, 53, 577, DateTimeKind.Local).AddTicks(5039) });

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 3, 18, 8, 36, 53, 577, DateTimeKind.Local).AddTicks(5041), new DateTime(2022, 3, 18, 8, 36, 53, 577, DateTimeKind.Local).AddTicks(5042) });

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 3, 18, 8, 36, 53, 577, DateTimeKind.Local).AddTicks(5043), new DateTime(2022, 3, 18, 8, 36, 53, 577, DateTimeKind.Local).AddTicks(5044) });

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 3, 18, 8, 36, 53, 577, DateTimeKind.Local).AddTicks(5045), new DateTime(2022, 3, 18, 8, 36, 53, 577, DateTimeKind.Local).AddTicks(5046) });

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 3, 18, 8, 36, 53, 577, DateTimeKind.Local).AddTicks(5048), new DateTime(2022, 3, 18, 8, 36, 53, 577, DateTimeKind.Local).AddTicks(5048) });

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 3, 18, 8, 36, 53, 577, DateTimeKind.Local).AddTicks(5049), new DateTime(2022, 3, 18, 8, 36, 53, 577, DateTimeKind.Local).AddTicks(5050) });

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 3, 18, 8, 36, 53, 577, DateTimeKind.Local).AddTicks(5052), new DateTime(2022, 3, 18, 8, 36, 53, 577, DateTimeKind.Local).AddTicks(5052) });

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 3, 18, 8, 36, 53, 577, DateTimeKind.Local).AddTicks(5054), new DateTime(2022, 3, 18, 8, 36, 53, 577, DateTimeKind.Local).AddTicks(5054) });

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 3, 18, 8, 36, 53, 577, DateTimeKind.Local).AddTicks(5056), new DateTime(2022, 3, 18, 8, 36, 53, 577, DateTimeKind.Local).AddTicks(5056) });

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 3, 18, 8, 36, 53, 577, DateTimeKind.Local).AddTicks(5058), new DateTime(2022, 3, 18, 8, 36, 53, 577, DateTimeKind.Local).AddTicks(5058) });

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 3, 18, 8, 36, 53, 577, DateTimeKind.Local).AddTicks(5060), new DateTime(2022, 3, 18, 8, 36, 53, 577, DateTimeKind.Local).AddTicks(5060) });

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 3, 18, 8, 36, 53, 577, DateTimeKind.Local).AddTicks(5062), new DateTime(2022, 3, 18, 8, 36, 53, 577, DateTimeKind.Local).AddTicks(5063) });

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 3, 18, 8, 36, 53, 577, DateTimeKind.Local).AddTicks(5064), new DateTime(2022, 3, 18, 8, 36, 53, 577, DateTimeKind.Local).AddTicks(5065) });
        }
    }
}
