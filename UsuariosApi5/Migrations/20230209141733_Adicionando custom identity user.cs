using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace UsuariosApi5.Migrations
{
    public partial class Adicionandocustomidentityuser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DataNascimento",
                table: "AspNetUsers",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 99997,
                column: "ConcurrencyStamp",
                value: "9acea985-e4fe-4277-bc45-ba5bce78c25e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 99999,
                column: "ConcurrencyStamp",
                value: "f90b75f6-96aa-4877-87d1-ce044b892032");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 99999,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1c562f5b-3a4c-4321-8c5c-a718ffcae6ad", "AQAAAAEAACcQAAAAEJKeHkAfY2LVdoXmwwY7tXoPNUR9MNSBQPsRqddFPeqfsn51QvUkSSlU+gjTTS1Q8Q==", "b251365b-0396-497d-a8dc-a76b010339f1" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DataNascimento",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 99997,
                column: "ConcurrencyStamp",
                value: "689c5c5a-d0c6-4bec-b298-f0b59b6acf39");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 99999,
                column: "ConcurrencyStamp",
                value: "7f03bd79-5d53-454b-8019-654e4fac5099");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 99999,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8c5e8c98-0a2c-490d-be0d-a0c61e6d641b", "AQAAAAEAACcQAAAAECgetnmJnoLYQK445cNnrvAD6QEpjpP3UKXn9pnsv+Df0oRRSIJ8Jtf5rnPZEt2iJA==", "400ec66f-656b-4378-99e3-cb2c3232f355" });
        }
    }
}
