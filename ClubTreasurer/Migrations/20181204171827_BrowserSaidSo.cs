using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ClubTreasurer.Migrations
{
    public partial class BrowserSaidSo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "920d780a-5b19-4628-97b4-a23e2894a4c9", "1a67a31b-16c3-4d64-8ce0-d64f4fcb0be9" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "fc9555af-19a8-4e8c-a6b3-6e7e0878d5c3", "0212e5b3-a997-494b-9fb4-7bf0c73c71fd" });

            migrationBuilder.AlterColumn<decimal>(
                name: "Amount",
                table: "BankTransactions",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "LastModified", "LastModifiedById", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "01368786-3397-44a9-8fa0-562cd56619de", "354c1a10-8143-4a82-8c52-a012dbaf73b9", "CRUD operations on finances", new DateTime(2018, 12, 4, 18, 18, 26, 382, DateTimeKind.Local), "e2a8bd78-87eb-4e39-aafd-fd9d67e3c48e", "FinaceEditor", null },
                    { "ea6055c5-030e-4e6f-bd91-d11827c51256", "de99a07d-a765-4a4e-82fa-3284923d53fc", "Read operations on finances", new DateTime(2018, 12, 4, 18, 18, 26, 382, DateTimeKind.Local), "e2a8bd78-87eb-4e39-aafd-fd9d67e3c48e", "FinanceReader", null }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e2a8bd78-87eb-4e39-aafd-fd9d67e3c48e",
                column: "ConcurrencyStamp",
                value: "0be47c2b-f755-4d90-8629-1ad9441afd38");

            migrationBuilder.UpdateData(
                table: "BankTransactionCategorys",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2018, 12, 4, 18, 18, 26, 382, DateTimeKind.Local), new DateTime(2018, 12, 4, 18, 18, 26, 382, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "BankTransactionCategorys",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2018, 12, 4, 18, 18, 26, 382, DateTimeKind.Local), new DateTime(2018, 12, 4, 18, 18, 26, 382, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "BankTransactionCategorys",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2018, 12, 4, 18, 18, 26, 382, DateTimeKind.Local), new DateTime(2018, 12, 4, 18, 18, 26, 382, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "BankTransactionCategorys",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2018, 12, 4, 18, 18, 26, 382, DateTimeKind.Local), new DateTime(2018, 12, 4, 18, 18, 26, 382, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "BankTransactionCategorys",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2018, 12, 4, 18, 18, 26, 382, DateTimeKind.Local), new DateTime(2018, 12, 4, 18, 18, 26, 382, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "BankTransactionCategorys",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2018, 12, 4, 18, 18, 26, 382, DateTimeKind.Local), new DateTime(2018, 12, 4, 18, 18, 26, 382, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "BankTransactionCategorys",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2018, 12, 4, 18, 18, 26, 382, DateTimeKind.Local), new DateTime(2018, 12, 4, 18, 18, 26, 382, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2018, 12, 4, 18, 18, 26, 382, DateTimeKind.Local), new DateTime(2018, 12, 4, 18, 18, 26, 382, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2018, 12, 4, 18, 18, 26, 382, DateTimeKind.Local), new DateTime(2018, 12, 4, 18, 18, 26, 382, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2018, 12, 4, 18, 18, 26, 382, DateTimeKind.Local), new DateTime(2018, 12, 4, 18, 18, 26, 382, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2018, 12, 4, 18, 18, 26, 382, DateTimeKind.Local), new DateTime(2018, 12, 4, 18, 18, 26, 382, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2018, 12, 4, 18, 18, 26, 382, DateTimeKind.Local), new DateTime(2018, 12, 4, 18, 18, 26, 382, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2018, 12, 4, 18, 18, 26, 382, DateTimeKind.Local), new DateTime(2018, 12, 4, 18, 18, 26, 382, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2018, 12, 4, 18, 18, 26, 382, DateTimeKind.Local), new DateTime(2018, 12, 4, 18, 18, 26, 382, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2018, 12, 4, 18, 18, 26, 382, DateTimeKind.Local), new DateTime(2018, 12, 4, 18, 18, 26, 382, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2018, 12, 4, 18, 18, 26, 382, DateTimeKind.Local), new DateTime(2018, 12, 4, 18, 18, 26, 382, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2018, 12, 4, 18, 18, 26, 382, DateTimeKind.Local), new DateTime(2018, 12, 4, 18, 18, 26, 382, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2018, 12, 4, 18, 18, 26, 382, DateTimeKind.Local), new DateTime(2018, 12, 4, 18, 18, 26, 382, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2018, 12, 4, 18, 18, 26, 382, DateTimeKind.Local), new DateTime(2018, 12, 4, 18, 18, 26, 382, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2018, 12, 4, 18, 18, 26, 382, DateTimeKind.Local), new DateTime(2018, 12, 4, 18, 18, 26, 382, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2018, 12, 4, 18, 18, 26, 382, DateTimeKind.Local), new DateTime(2018, 12, 4, 18, 18, 26, 382, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2018, 12, 4, 18, 18, 26, 382, DateTimeKind.Local), new DateTime(2018, 12, 4, 18, 18, 26, 382, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2018, 12, 4, 18, 18, 26, 382, DateTimeKind.Local), new DateTime(2018, 12, 4, 18, 18, 26, 382, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2018, 12, 4, 18, 18, 26, 382, DateTimeKind.Local), new DateTime(2018, 12, 4, 18, 18, 26, 382, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2018, 12, 4, 18, 18, 26, 382, DateTimeKind.Local), new DateTime(2018, 12, 4, 18, 18, 26, 382, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2018, 12, 4, 18, 18, 26, 382, DateTimeKind.Local), new DateTime(2018, 12, 4, 18, 18, 26, 382, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "ID",
                keyValue: 20,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2018, 12, 4, 18, 18, 26, 382, DateTimeKind.Local), new DateTime(2018, 12, 4, 18, 18, 26, 382, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "ID",
                keyValue: 21,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2018, 12, 4, 18, 18, 26, 382, DateTimeKind.Local), new DateTime(2018, 12, 4, 18, 18, 26, 382, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "ID",
                keyValue: 22,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2018, 12, 4, 18, 18, 26, 382, DateTimeKind.Local), new DateTime(2018, 12, 4, 18, 18, 26, 382, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PlayerPositions",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2018, 12, 4, 18, 18, 26, 382, DateTimeKind.Local), new DateTime(2018, 12, 4, 18, 18, 26, 382, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PlayerPositions",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2018, 12, 4, 18, 18, 26, 382, DateTimeKind.Local), new DateTime(2018, 12, 4, 18, 18, 26, 382, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PlayerPositions",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2018, 12, 4, 18, 18, 26, 382, DateTimeKind.Local), new DateTime(2018, 12, 4, 18, 18, 26, 382, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PlayerPositions",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2018, 12, 4, 18, 18, 26, 382, DateTimeKind.Local), new DateTime(2018, 12, 4, 18, 18, 26, 382, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PlayerPositions",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2018, 12, 4, 18, 18, 26, 382, DateTimeKind.Local), new DateTime(2018, 12, 4, 18, 18, 26, 382, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PlayerPositions",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2018, 12, 4, 18, 18, 26, 382, DateTimeKind.Local), new DateTime(2018, 12, 4, 18, 18, 26, 382, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PlayerPositions",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2018, 12, 4, 18, 18, 26, 382, DateTimeKind.Local), new DateTime(2018, 12, 4, 18, 18, 26, 382, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PlayerPositions",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2018, 12, 4, 18, 18, 26, 382, DateTimeKind.Local), new DateTime(2018, 12, 4, 18, 18, 26, 382, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PlayerPositions",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2018, 12, 4, 18, 18, 26, 382, DateTimeKind.Local), new DateTime(2018, 12, 4, 18, 18, 26, 382, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PlayerPositions",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2018, 12, 4, 18, 18, 26, 382, DateTimeKind.Local), new DateTime(2018, 12, 4, 18, 18, 26, 382, DateTimeKind.Local) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "01368786-3397-44a9-8fa0-562cd56619de", "354c1a10-8143-4a82-8c52-a012dbaf73b9" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "ea6055c5-030e-4e6f-bd91-d11827c51256", "de99a07d-a765-4a4e-82fa-3284923d53fc" });

            migrationBuilder.AlterColumn<decimal>(
                name: "Amount",
                table: "BankTransactions",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "LastModified", "LastModifiedById", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "920d780a-5b19-4628-97b4-a23e2894a4c9", "1a67a31b-16c3-4d64-8ce0-d64f4fcb0be9", "CRUD operations on finances", new DateTime(2018, 12, 4, 16, 36, 7, 193, DateTimeKind.Local), "e2a8bd78-87eb-4e39-aafd-fd9d67e3c48e", "FinaceEditor", null },
                    { "fc9555af-19a8-4e8c-a6b3-6e7e0878d5c3", "0212e5b3-a997-494b-9fb4-7bf0c73c71fd", "Read operations on finances", new DateTime(2018, 12, 4, 16, 36, 7, 193, DateTimeKind.Local), "e2a8bd78-87eb-4e39-aafd-fd9d67e3c48e", "FinanceReader", null }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e2a8bd78-87eb-4e39-aafd-fd9d67e3c48e",
                column: "ConcurrencyStamp",
                value: "a7b76316-fbc8-41d4-9ff8-a5adcb9b55d1");

            migrationBuilder.UpdateData(
                table: "BankTransactionCategorys",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2018, 12, 4, 16, 36, 7, 193, DateTimeKind.Local), new DateTime(2018, 12, 4, 16, 36, 7, 193, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "BankTransactionCategorys",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2018, 12, 4, 16, 36, 7, 193, DateTimeKind.Local), new DateTime(2018, 12, 4, 16, 36, 7, 193, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "BankTransactionCategorys",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2018, 12, 4, 16, 36, 7, 193, DateTimeKind.Local), new DateTime(2018, 12, 4, 16, 36, 7, 193, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "BankTransactionCategorys",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2018, 12, 4, 16, 36, 7, 193, DateTimeKind.Local), new DateTime(2018, 12, 4, 16, 36, 7, 193, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "BankTransactionCategorys",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2018, 12, 4, 16, 36, 7, 193, DateTimeKind.Local), new DateTime(2018, 12, 4, 16, 36, 7, 193, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "BankTransactionCategorys",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2018, 12, 4, 16, 36, 7, 193, DateTimeKind.Local), new DateTime(2018, 12, 4, 16, 36, 7, 193, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "BankTransactionCategorys",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2018, 12, 4, 16, 36, 7, 193, DateTimeKind.Local), new DateTime(2018, 12, 4, 16, 36, 7, 193, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2018, 12, 4, 16, 36, 7, 193, DateTimeKind.Local), new DateTime(2018, 12, 4, 16, 36, 7, 193, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2018, 12, 4, 16, 36, 7, 193, DateTimeKind.Local), new DateTime(2018, 12, 4, 16, 36, 7, 193, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2018, 12, 4, 16, 36, 7, 193, DateTimeKind.Local), new DateTime(2018, 12, 4, 16, 36, 7, 193, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2018, 12, 4, 16, 36, 7, 193, DateTimeKind.Local), new DateTime(2018, 12, 4, 16, 36, 7, 193, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2018, 12, 4, 16, 36, 7, 193, DateTimeKind.Local), new DateTime(2018, 12, 4, 16, 36, 7, 193, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2018, 12, 4, 16, 36, 7, 193, DateTimeKind.Local), new DateTime(2018, 12, 4, 16, 36, 7, 193, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2018, 12, 4, 16, 36, 7, 193, DateTimeKind.Local), new DateTime(2018, 12, 4, 16, 36, 7, 193, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2018, 12, 4, 16, 36, 7, 193, DateTimeKind.Local), new DateTime(2018, 12, 4, 16, 36, 7, 193, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2018, 12, 4, 16, 36, 7, 193, DateTimeKind.Local), new DateTime(2018, 12, 4, 16, 36, 7, 193, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2018, 12, 4, 16, 36, 7, 193, DateTimeKind.Local), new DateTime(2018, 12, 4, 16, 36, 7, 193, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2018, 12, 4, 16, 36, 7, 193, DateTimeKind.Local), new DateTime(2018, 12, 4, 16, 36, 7, 193, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2018, 12, 4, 16, 36, 7, 193, DateTimeKind.Local), new DateTime(2018, 12, 4, 16, 36, 7, 193, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2018, 12, 4, 16, 36, 7, 193, DateTimeKind.Local), new DateTime(2018, 12, 4, 16, 36, 7, 193, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2018, 12, 4, 16, 36, 7, 193, DateTimeKind.Local), new DateTime(2018, 12, 4, 16, 36, 7, 193, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2018, 12, 4, 16, 36, 7, 193, DateTimeKind.Local), new DateTime(2018, 12, 4, 16, 36, 7, 193, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2018, 12, 4, 16, 36, 7, 193, DateTimeKind.Local), new DateTime(2018, 12, 4, 16, 36, 7, 193, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2018, 12, 4, 16, 36, 7, 193, DateTimeKind.Local), new DateTime(2018, 12, 4, 16, 36, 7, 193, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2018, 12, 4, 16, 36, 7, 193, DateTimeKind.Local), new DateTime(2018, 12, 4, 16, 36, 7, 193, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2018, 12, 4, 16, 36, 7, 193, DateTimeKind.Local), new DateTime(2018, 12, 4, 16, 36, 7, 193, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "ID",
                keyValue: 20,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2018, 12, 4, 16, 36, 7, 193, DateTimeKind.Local), new DateTime(2018, 12, 4, 16, 36, 7, 193, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "ID",
                keyValue: 21,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2018, 12, 4, 16, 36, 7, 193, DateTimeKind.Local), new DateTime(2018, 12, 4, 16, 36, 7, 193, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "ID",
                keyValue: 22,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2018, 12, 4, 16, 36, 7, 193, DateTimeKind.Local), new DateTime(2018, 12, 4, 16, 36, 7, 193, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PlayerPositions",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2018, 12, 4, 16, 36, 7, 193, DateTimeKind.Local), new DateTime(2018, 12, 4, 16, 36, 7, 193, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PlayerPositions",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2018, 12, 4, 16, 36, 7, 193, DateTimeKind.Local), new DateTime(2018, 12, 4, 16, 36, 7, 193, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PlayerPositions",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2018, 12, 4, 16, 36, 7, 193, DateTimeKind.Local), new DateTime(2018, 12, 4, 16, 36, 7, 193, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PlayerPositions",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2018, 12, 4, 16, 36, 7, 193, DateTimeKind.Local), new DateTime(2018, 12, 4, 16, 36, 7, 193, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PlayerPositions",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2018, 12, 4, 16, 36, 7, 193, DateTimeKind.Local), new DateTime(2018, 12, 4, 16, 36, 7, 193, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PlayerPositions",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2018, 12, 4, 16, 36, 7, 193, DateTimeKind.Local), new DateTime(2018, 12, 4, 16, 36, 7, 193, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PlayerPositions",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2018, 12, 4, 16, 36, 7, 193, DateTimeKind.Local), new DateTime(2018, 12, 4, 16, 36, 7, 193, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PlayerPositions",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2018, 12, 4, 16, 36, 7, 193, DateTimeKind.Local), new DateTime(2018, 12, 4, 16, 36, 7, 193, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PlayerPositions",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2018, 12, 4, 16, 36, 7, 193, DateTimeKind.Local), new DateTime(2018, 12, 4, 16, 36, 7, 193, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PlayerPositions",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2018, 12, 4, 16, 36, 7, 193, DateTimeKind.Local), new DateTime(2018, 12, 4, 16, 36, 7, 193, DateTimeKind.Local) });
        }
    }
}
