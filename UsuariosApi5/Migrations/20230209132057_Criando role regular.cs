using Microsoft.EntityFrameworkCore.Migrations;

namespace UsuariosApi5.Migrations
{
    public partial class Criandoroleregular : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 99999,
                column: "ConcurrencyStamp",
                value: "7f03bd79-5d53-454b-8019-654e4fac5099");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { 99997, "689c5c5a-d0c6-4bec-b298-f0b59b6acf39", "regular", "REGULAR" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 99999,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8c5e8c98-0a2c-490d-be0d-a0c61e6d641b", "AQAAAAEAACcQAAAAECgetnmJnoLYQK445cNnrvAD6QEpjpP3UKXn9pnsv+Df0oRRSIJ8Jtf5rnPZEt2iJA==", "400ec66f-656b-4378-99e3-cb2c3232f355" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 99997);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 99999,
                column: "ConcurrencyStamp",
                value: "c6ce1950-47c1-42c1-975c-e24c5b87c5a2");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 99999,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "af6f4b90-f036-4fb1-bd71-5ccc2365ea00", "AQAAAAEAACcQAAAAENNu/AprHqRU0BlhyuAEgEmD1l7KSnGr60tJX2tlDMem1kEAhIkH80fZtV1p+ciI/A==", "fbb9ab33-221c-43af-a576-91b2681e426d" });
        }
    }
}
