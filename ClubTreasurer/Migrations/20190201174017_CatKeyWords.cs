using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ClubTreasurer.Migrations
{
    public partial class CatKeyWords : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "01368786-3397-44a9-8fa0-562cd56619de", "354c1a10-8143-4a82-8c52-a012dbaf73b9" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "ea6055c5-030e-4e6f-bd91-d11827c51256", "de99a07d-a765-4a4e-82fa-3284923d53fc" });

            migrationBuilder.AddColumn<string>(
                name: "KeyWords",
                table: "BankTransactionCategorys",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "LastModified", "LastModifiedById", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "8ec7d191-ce84-4b01-a69f-174458c75646", "00b520bd-083b-4dbd-aedd-8e379b381591", "CRUD operations on finances", new DateTime(2019, 2, 1, 18, 40, 16, 246, DateTimeKind.Local), "e2a8bd78-87eb-4e39-aafd-fd9d67e3c48e", "FinaceEditor", null },
                    { "1c119311-17d7-4d20-a1e5-00f426e30475", "351ec1cd-2d82-44c2-a6b6-e52e2b5ba45e", "Read operations on finances", new DateTime(2019, 2, 1, 18, 40, 16, 246, DateTimeKind.Local), "e2a8bd78-87eb-4e39-aafd-fd9d67e3c48e", "FinanceReader", null }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e2a8bd78-87eb-4e39-aafd-fd9d67e3c48e",
                column: "ConcurrencyStamp",
                value: "a7fc6d3c-0dfe-463d-96d2-2e9c18d49ceb");

            migrationBuilder.UpdateData(
                table: "BankTransactionCategorys",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 1, 18, 40, 16, 246, DateTimeKind.Local), new DateTime(2019, 2, 1, 18, 40, 16, 246, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "BankTransactionCategorys",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 1, 18, 40, 16, 246, DateTimeKind.Local), new DateTime(2019, 2, 1, 18, 40, 16, 246, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "BankTransactionCategorys",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 1, 18, 40, 16, 246, DateTimeKind.Local), new DateTime(2019, 2, 1, 18, 40, 16, 246, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "BankTransactionCategorys",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 1, 18, 40, 16, 246, DateTimeKind.Local), new DateTime(2019, 2, 1, 18, 40, 16, 246, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "BankTransactionCategorys",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 1, 18, 40, 16, 246, DateTimeKind.Local), new DateTime(2019, 2, 1, 18, 40, 16, 246, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "BankTransactionCategorys",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 1, 18, 40, 16, 246, DateTimeKind.Local), new DateTime(2019, 2, 1, 18, 40, 16, 246, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "BankTransactionCategorys",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 1, 18, 40, 16, 246, DateTimeKind.Local), new DateTime(2019, 2, 1, 18, 40, 16, 246, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 1, 18, 40, 16, 246, DateTimeKind.Local), new DateTime(2019, 2, 1, 18, 40, 16, 246, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 1, 18, 40, 16, 246, DateTimeKind.Local), new DateTime(2019, 2, 1, 18, 40, 16, 246, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 1, 18, 40, 16, 246, DateTimeKind.Local), new DateTime(2019, 2, 1, 18, 40, 16, 246, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 1, 18, 40, 16, 246, DateTimeKind.Local), new DateTime(2019, 2, 1, 18, 40, 16, 246, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 1, 18, 40, 16, 246, DateTimeKind.Local), new DateTime(2019, 2, 1, 18, 40, 16, 246, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 1, 18, 40, 16, 246, DateTimeKind.Local), new DateTime(2019, 2, 1, 18, 40, 16, 246, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 1, 18, 40, 16, 246, DateTimeKind.Local), new DateTime(2019, 2, 1, 18, 40, 16, 246, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 1, 18, 40, 16, 246, DateTimeKind.Local), new DateTime(2019, 2, 1, 18, 40, 16, 246, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 1, 18, 40, 16, 246, DateTimeKind.Local), new DateTime(2019, 2, 1, 18, 40, 16, 246, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 1, 18, 40, 16, 246, DateTimeKind.Local), new DateTime(2019, 2, 1, 18, 40, 16, 246, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 1, 18, 40, 16, 246, DateTimeKind.Local), new DateTime(2019, 2, 1, 18, 40, 16, 246, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 1, 18, 40, 16, 246, DateTimeKind.Local), new DateTime(2019, 2, 1, 18, 40, 16, 246, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 1, 18, 40, 16, 246, DateTimeKind.Local), new DateTime(2019, 2, 1, 18, 40, 16, 246, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 1, 18, 40, 16, 246, DateTimeKind.Local), new DateTime(2019, 2, 1, 18, 40, 16, 246, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 1, 18, 40, 16, 246, DateTimeKind.Local), new DateTime(2019, 2, 1, 18, 40, 16, 246, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 1, 18, 40, 16, 246, DateTimeKind.Local), new DateTime(2019, 2, 1, 18, 40, 16, 246, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 1, 18, 40, 16, 246, DateTimeKind.Local), new DateTime(2019, 2, 1, 18, 40, 16, 246, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 1, 18, 40, 16, 246, DateTimeKind.Local), new DateTime(2019, 2, 1, 18, 40, 16, 246, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 1, 18, 40, 16, 246, DateTimeKind.Local), new DateTime(2019, 2, 1, 18, 40, 16, 246, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "ID",
                keyValue: 20,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 1, 18, 40, 16, 246, DateTimeKind.Local), new DateTime(2019, 2, 1, 18, 40, 16, 246, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "ID",
                keyValue: 21,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 1, 18, 40, 16, 246, DateTimeKind.Local), new DateTime(2019, 2, 1, 18, 40, 16, 246, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "ID",
                keyValue: 22,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 1, 18, 40, 16, 246, DateTimeKind.Local), new DateTime(2019, 2, 1, 18, 40, 16, 246, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PlayerPositions",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 1, 18, 40, 16, 246, DateTimeKind.Local), new DateTime(2019, 2, 1, 18, 40, 16, 246, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PlayerPositions",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 1, 18, 40, 16, 246, DateTimeKind.Local), new DateTime(2019, 2, 1, 18, 40, 16, 246, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PlayerPositions",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 1, 18, 40, 16, 246, DateTimeKind.Local), new DateTime(2019, 2, 1, 18, 40, 16, 246, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PlayerPositions",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 1, 18, 40, 16, 246, DateTimeKind.Local), new DateTime(2019, 2, 1, 18, 40, 16, 246, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PlayerPositions",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 1, 18, 40, 16, 246, DateTimeKind.Local), new DateTime(2019, 2, 1, 18, 40, 16, 246, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PlayerPositions",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 1, 18, 40, 16, 246, DateTimeKind.Local), new DateTime(2019, 2, 1, 18, 40, 16, 246, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PlayerPositions",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 1, 18, 40, 16, 246, DateTimeKind.Local), new DateTime(2019, 2, 1, 18, 40, 16, 246, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PlayerPositions",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 1, 18, 40, 16, 246, DateTimeKind.Local), new DateTime(2019, 2, 1, 18, 40, 16, 246, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PlayerPositions",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 1, 18, 40, 16, 246, DateTimeKind.Local), new DateTime(2019, 2, 1, 18, 40, 16, 246, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PlayerPositions",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 1, 18, 40, 16, 246, DateTimeKind.Local), new DateTime(2019, 2, 1, 18, 40, 16, 246, DateTimeKind.Local) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "1c119311-17d7-4d20-a1e5-00f426e30475", "351ec1cd-2d82-44c2-a6b6-e52e2b5ba45e" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "8ec7d191-ce84-4b01-a69f-174458c75646", "00b520bd-083b-4dbd-aedd-8e379b381591" });

            migrationBuilder.DropColumn(
                name: "KeyWords",
                table: "BankTransactionCategorys");

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
    }
}
