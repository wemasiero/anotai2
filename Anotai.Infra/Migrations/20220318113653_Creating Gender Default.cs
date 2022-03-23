using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Anotai.Data.Migrations
{
    public partial class CreatingGenderDefault : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Genders",
                columns: new[] { "Id", "CreatedAt", "Description", "IsDeleted", "UpdatedAt" },
                values: new object[] { 1, new DateTime(2022, 3, 18, 8, 36, 53, 577, DateTimeKind.Local).AddTicks(4978), "AÇÃO E AVENTURA", false, new DateTime(2022, 3, 18, 8, 36, 53, 577, DateTimeKind.Local).AddTicks(4988) });

            migrationBuilder.InsertData(
                table: "Genders",
                columns: new[] { "Id", "CreatedAt", "Description", "IsDeleted", "UpdatedAt" },
                values: new object[] { 2, new DateTime(2022, 3, 18, 8, 36, 53, 577, DateTimeKind.Local).AddTicks(4991), "ARTE E FOTOGRAFIA", false, new DateTime(2022, 3, 18, 8, 36, 53, 577, DateTimeKind.Local).AddTicks(4992) });

            migrationBuilder.InsertData(
                table: "Genders",
                columns: new[] { "Id", "CreatedAt", "Description", "IsDeleted", "UpdatedAt" },
                values: new object[] { 3, new DateTime(2022, 3, 18, 8, 36, 53, 577, DateTimeKind.Local).AddTicks(4993), "AUTOAJUDA", false, new DateTime(2022, 3, 18, 8, 36, 53, 577, DateTimeKind.Local).AddTicks(4994) });

            migrationBuilder.InsertData(
                table: "Genders",
                columns: new[] { "Id", "CreatedAt", "Description", "IsDeleted", "UpdatedAt" },
                values: new object[] { 4, new DateTime(2022, 3, 18, 8, 36, 53, 577, DateTimeKind.Local).AddTicks(4995), "BIOGRAFIA", false, new DateTime(2022, 3, 18, 8, 36, 53, 577, DateTimeKind.Local).AddTicks(4996) });

            migrationBuilder.InsertData(
                table: "Genders",
                columns: new[] { "Id", "CreatedAt", "Description", "IsDeleted", "UpdatedAt" },
                values: new object[] { 5, new DateTime(2022, 3, 18, 8, 36, 53, 577, DateTimeKind.Local).AddTicks(4998), "CONTO", false, new DateTime(2022, 3, 18, 8, 36, 53, 577, DateTimeKind.Local).AddTicks(4998) });

            migrationBuilder.InsertData(
                table: "Genders",
                columns: new[] { "Id", "CreatedAt", "Description", "IsDeleted", "UpdatedAt" },
                values: new object[] { 6, new DateTime(2022, 3, 18, 8, 36, 53, 577, DateTimeKind.Local).AddTicks(5000), "CRIMES REAIS", false, new DateTime(2022, 3, 18, 8, 36, 53, 577, DateTimeKind.Local).AddTicks(5001) });

            migrationBuilder.InsertData(
                table: "Genders",
                columns: new[] { "Id", "CreatedAt", "Description", "IsDeleted", "UpdatedAt" },
                values: new object[] { 7, new DateTime(2022, 3, 18, 8, 36, 53, 577, DateTimeKind.Local).AddTicks(5002), "DISTOPIA", false, new DateTime(2022, 3, 18, 8, 36, 53, 577, DateTimeKind.Local).AddTicks(5003) });

            migrationBuilder.InsertData(
                table: "Genders",
                columns: new[] { "Id", "CreatedAt", "Description", "IsDeleted", "UpdatedAt" },
                values: new object[] { 8, new DateTime(2022, 3, 18, 8, 36, 53, 577, DateTimeKind.Local).AddTicks(5004), "ENSAIOS", false, new DateTime(2022, 3, 18, 8, 36, 53, 577, DateTimeKind.Local).AddTicks(5005) });

            migrationBuilder.InsertData(
                table: "Genders",
                columns: new[] { "Id", "CreatedAt", "Description", "IsDeleted", "UpdatedAt" },
                values: new object[] { 9, new DateTime(2022, 3, 18, 8, 36, 53, 577, DateTimeKind.Local).AddTicks(5006), "FANTASIA", false, new DateTime(2022, 3, 18, 8, 36, 53, 577, DateTimeKind.Local).AddTicks(5007) });

            migrationBuilder.InsertData(
                table: "Genders",
                columns: new[] { "Id", "CreatedAt", "Description", "IsDeleted", "UpdatedAt" },
                values: new object[] { 10, new DateTime(2022, 3, 18, 8, 36, 53, 577, DateTimeKind.Local).AddTicks(5008), "FICÇÃO CIENTÍFICA", false, new DateTime(2022, 3, 18, 8, 36, 53, 577, DateTimeKind.Local).AddTicks(5009) });

            migrationBuilder.InsertData(
                table: "Genders",
                columns: new[] { "Id", "CreatedAt", "Description", "IsDeleted", "UpdatedAt" },
                values: new object[] { 11, new DateTime(2022, 3, 18, 8, 36, 53, 577, DateTimeKind.Local).AddTicks(5010), "FICÇÃO CONTEMPORÂNEA", false, new DateTime(2022, 3, 18, 8, 36, 53, 577, DateTimeKind.Local).AddTicks(5011) });

            migrationBuilder.InsertData(
                table: "Genders",
                columns: new[] { "Id", "CreatedAt", "Description", "IsDeleted", "UpdatedAt" },
                values: new object[] { 12, new DateTime(2022, 3, 18, 8, 36, 53, 577, DateTimeKind.Local).AddTicks(5012), "FICÇÃO FEMININA", false, new DateTime(2022, 3, 18, 8, 36, 53, 577, DateTimeKind.Local).AddTicks(5013) });

            migrationBuilder.InsertData(
                table: "Genders",
                columns: new[] { "Id", "CreatedAt", "Description", "IsDeleted", "UpdatedAt" },
                values: new object[] { 13, new DateTime(2022, 3, 18, 8, 36, 53, 577, DateTimeKind.Local).AddTicks(5015), "FICÇÃO HISTÓRICA", false, new DateTime(2022, 3, 18, 8, 36, 53, 577, DateTimeKind.Local).AddTicks(5016) });

            migrationBuilder.InsertData(
                table: "Genders",
                columns: new[] { "Id", "CreatedAt", "Description", "IsDeleted", "UpdatedAt" },
                values: new object[] { 14, new DateTime(2022, 3, 18, 8, 36, 53, 577, DateTimeKind.Local).AddTicks(5017), "FICÇÃO POLICIAL", false, new DateTime(2022, 3, 18, 8, 36, 53, 577, DateTimeKind.Local).AddTicks(5018) });

            migrationBuilder.InsertData(
                table: "Genders",
                columns: new[] { "Id", "CreatedAt", "Description", "IsDeleted", "UpdatedAt" },
                values: new object[] { 15, new DateTime(2022, 3, 18, 8, 36, 53, 577, DateTimeKind.Local).AddTicks(5020), "GASTRONOMIA", false, new DateTime(2022, 3, 18, 8, 36, 53, 577, DateTimeKind.Local).AddTicks(5020) });

            migrationBuilder.InsertData(
                table: "Genders",
                columns: new[] { "Id", "CreatedAt", "Description", "IsDeleted", "UpdatedAt" },
                values: new object[] { 16, new DateTime(2022, 3, 18, 8, 36, 53, 577, DateTimeKind.Local).AddTicks(5022), "GÊNEROS DE FICÇÃO", false, new DateTime(2022, 3, 18, 8, 36, 53, 577, DateTimeKind.Local).AddTicks(5022) });

            migrationBuilder.InsertData(
                table: "Genders",
                columns: new[] { "Id", "CreatedAt", "Description", "IsDeleted", "UpdatedAt" },
                values: new object[] { 17, new DateTime(2022, 3, 18, 8, 36, 53, 577, DateTimeKind.Local).AddTicks(5024), "GÊNEROS DE NÃO FICÇÃO", false, new DateTime(2022, 3, 18, 8, 36, 53, 577, DateTimeKind.Local).AddTicks(5025) });

            migrationBuilder.InsertData(
                table: "Genders",
                columns: new[] { "Id", "CreatedAt", "Description", "IsDeleted", "UpdatedAt" },
                values: new object[] { 18, new DateTime(2022, 3, 18, 8, 36, 53, 577, DateTimeKind.Local).AddTicks(5026), "GRAPHIC NOVEL", false, new DateTime(2022, 3, 18, 8, 36, 53, 577, DateTimeKind.Local).AddTicks(5027) });

            migrationBuilder.InsertData(
                table: "Genders",
                columns: new[] { "Id", "CreatedAt", "Description", "IsDeleted", "UpdatedAt" },
                values: new object[] { 19, new DateTime(2022, 3, 18, 8, 36, 53, 577, DateTimeKind.Local).AddTicks(5028), "GUIAS & COMO FAZER ", false, new DateTime(2022, 3, 18, 8, 36, 53, 577, DateTimeKind.Local).AddTicks(5029) });

            migrationBuilder.InsertData(
                table: "Genders",
                columns: new[] { "Id", "CreatedAt", "Description", "IsDeleted", "UpdatedAt" },
                values: new object[] { 20, new DateTime(2022, 3, 18, 8, 36, 53, 577, DateTimeKind.Local).AddTicks(5030), "HISTÓRIA", false, new DateTime(2022, 3, 18, 8, 36, 53, 577, DateTimeKind.Local).AddTicks(5031) });

            migrationBuilder.InsertData(
                table: "Genders",
                columns: new[] { "Id", "CreatedAt", "Description", "IsDeleted", "UpdatedAt" },
                values: new object[] { 21, new DateTime(2022, 3, 18, 8, 36, 53, 577, DateTimeKind.Local).AddTicks(5032), "HORROR", false, new DateTime(2022, 3, 18, 8, 36, 53, 577, DateTimeKind.Local).AddTicks(5033) });

            migrationBuilder.InsertData(
                table: "Genders",
                columns: new[] { "Id", "CreatedAt", "Description", "IsDeleted", "UpdatedAt" },
                values: new object[] { 22, new DateTime(2022, 3, 18, 8, 36, 53, 577, DateTimeKind.Local).AddTicks(5035), "HUMANIDADES E CIÊNCIAS SOCIAIS", false, new DateTime(2022, 3, 18, 8, 36, 53, 577, DateTimeKind.Local).AddTicks(5035) });

            migrationBuilder.InsertData(
                table: "Genders",
                columns: new[] { "Id", "CreatedAt", "Description", "IsDeleted", "UpdatedAt" },
                values: new object[] { 23, new DateTime(2022, 3, 18, 8, 36, 53, 577, DateTimeKind.Local).AddTicks(5037), "HUMOR", false, new DateTime(2022, 3, 18, 8, 36, 53, 577, DateTimeKind.Local).AddTicks(5037) });

            migrationBuilder.InsertData(
                table: "Genders",
                columns: new[] { "Id", "CreatedAt", "Description", "IsDeleted", "UpdatedAt" },
                values: new object[] { 24, new DateTime(2022, 3, 18, 8, 36, 53, 577, DateTimeKind.Local).AddTicks(5039), "INFANTIL", false, new DateTime(2022, 3, 18, 8, 36, 53, 577, DateTimeKind.Local).AddTicks(5039) });

            migrationBuilder.InsertData(
                table: "Genders",
                columns: new[] { "Id", "CreatedAt", "Description", "IsDeleted", "UpdatedAt" },
                values: new object[] { 25, new DateTime(2022, 3, 18, 8, 36, 53, 577, DateTimeKind.Local).AddTicks(5041), "INFANTIL", false, new DateTime(2022, 3, 18, 8, 36, 53, 577, DateTimeKind.Local).AddTicks(5042) });

            migrationBuilder.InsertData(
                table: "Genders",
                columns: new[] { "Id", "CreatedAt", "Description", "IsDeleted", "UpdatedAt" },
                values: new object[] { 26, new DateTime(2022, 3, 18, 8, 36, 53, 577, DateTimeKind.Local).AddTicks(5043), "LGBTQ+", false, new DateTime(2022, 3, 18, 8, 36, 53, 577, DateTimeKind.Local).AddTicks(5044) });

            migrationBuilder.InsertData(
                table: "Genders",
                columns: new[] { "Id", "CreatedAt", "Description", "IsDeleted", "UpdatedAt" },
                values: new object[] { 27, new DateTime(2022, 3, 18, 8, 36, 53, 577, DateTimeKind.Local).AddTicks(5045), "MEMÓRIAS E AUTOBIOGRAFIA", false, new DateTime(2022, 3, 18, 8, 36, 53, 577, DateTimeKind.Local).AddTicks(5046) });

            migrationBuilder.InsertData(
                table: "Genders",
                columns: new[] { "Id", "CreatedAt", "Description", "IsDeleted", "UpdatedAt" },
                values: new object[] { 28, new DateTime(2022, 3, 18, 8, 36, 53, 577, DateTimeKind.Local).AddTicks(5048), "NEW ADULT – NOVO ADULTO ", false, new DateTime(2022, 3, 18, 8, 36, 53, 577, DateTimeKind.Local).AddTicks(5048) });

            migrationBuilder.InsertData(
                table: "Genders",
                columns: new[] { "Id", "CreatedAt", "Description", "IsDeleted", "UpdatedAt" },
                values: new object[] { 29, new DateTime(2022, 3, 18, 8, 36, 53, 577, DateTimeKind.Local).AddTicks(5049), "PATERNIDADE E FAMÍLIA", false, new DateTime(2022, 3, 18, 8, 36, 53, 577, DateTimeKind.Local).AddTicks(5050) });

            migrationBuilder.InsertData(
                table: "Genders",
                columns: new[] { "Id", "CreatedAt", "Description", "IsDeleted", "UpdatedAt" },
                values: new object[] { 30, new DateTime(2022, 3, 18, 8, 36, 53, 577, DateTimeKind.Local).AddTicks(5052), "REALISMO MÁGICO", false, new DateTime(2022, 3, 18, 8, 36, 53, 577, DateTimeKind.Local).AddTicks(5052) });

            migrationBuilder.InsertData(
                table: "Genders",
                columns: new[] { "Id", "CreatedAt", "Description", "IsDeleted", "UpdatedAt" },
                values: new object[] { 31, new DateTime(2022, 3, 18, 8, 36, 53, 577, DateTimeKind.Local).AddTicks(5054), "RELIGIÃO E ESPIRITUALIDADE", false, new DateTime(2022, 3, 18, 8, 36, 53, 577, DateTimeKind.Local).AddTicks(5054) });

            migrationBuilder.InsertData(
                table: "Genders",
                columns: new[] { "Id", "CreatedAt", "Description", "IsDeleted", "UpdatedAt" },
                values: new object[] { 32, new DateTime(2022, 3, 18, 8, 36, 53, 577, DateTimeKind.Local).AddTicks(5056), "ROMANCE", false, new DateTime(2022, 3, 18, 8, 36, 53, 577, DateTimeKind.Local).AddTicks(5056) });

            migrationBuilder.InsertData(
                table: "Genders",
                columns: new[] { "Id", "CreatedAt", "Description", "IsDeleted", "UpdatedAt" },
                values: new object[] { 33, new DateTime(2022, 3, 18, 8, 36, 53, 577, DateTimeKind.Local).AddTicks(5058), "TECNOLOGIA E CIÊNCIA", false, new DateTime(2022, 3, 18, 8, 36, 53, 577, DateTimeKind.Local).AddTicks(5058) });

            migrationBuilder.InsertData(
                table: "Genders",
                columns: new[] { "Id", "CreatedAt", "Description", "IsDeleted", "UpdatedAt" },
                values: new object[] { 34, new DateTime(2022, 3, 18, 8, 36, 53, 577, DateTimeKind.Local).AddTicks(5060), "THRILLER E SUSPENSE", false, new DateTime(2022, 3, 18, 8, 36, 53, 577, DateTimeKind.Local).AddTicks(5060) });

            migrationBuilder.InsertData(
                table: "Genders",
                columns: new[] { "Id", "CreatedAt", "Description", "IsDeleted", "UpdatedAt" },
                values: new object[] { 35, new DateTime(2022, 3, 18, 8, 36, 53, 577, DateTimeKind.Local).AddTicks(5062), "VIAJEM", false, new DateTime(2022, 3, 18, 8, 36, 53, 577, DateTimeKind.Local).AddTicks(5063) });

            migrationBuilder.InsertData(
                table: "Genders",
                columns: new[] { "Id", "CreatedAt", "Description", "IsDeleted", "UpdatedAt" },
                values: new object[] { 36, new DateTime(2022, 3, 18, 8, 36, 53, 577, DateTimeKind.Local).AddTicks(5064), "YOUNG ADULT – JOVEM ADULTO", false, new DateTime(2022, 3, 18, 8, 36, 53, 577, DateTimeKind.Local).AddTicks(5065) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 36);
        }
    }
}
