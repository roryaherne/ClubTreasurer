using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ClubTreasurer.Migrations
{
    public partial class TransactionAltKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "44ef7f76-eabd-497b-8535-05569afff7af", "8c6af3aa-d838-4ba9-a94f-6f2360df1b45" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "589ef4c9-d67a-4355-b56b-cfd5b098f1f1", "a60ec7b2-54dd-4292-ae12-2881ecc8486b" });

            migrationBuilder.AlterColumn<string>(
                name: "ReferenceNumber",
                table: "BankTransactions",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddUniqueConstraint(
                name: "AK_BankTransactions_ReferenceNumber",
                table: "BankTransactions",
                column: "ReferenceNumber");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "LastModified", "LastModifiedById", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "bac20b58-0e01-4ea0-80a0-275ad6d674ab", "c6f4cf77-ae7d-41eb-b95e-e1437036a186", "CRUD operations on finances", new DateTime(2019, 2, 6, 18, 13, 14, 246, DateTimeKind.Local), "e2a8bd78-87eb-4e39-aafd-fd9d67e3c48e", "FinaceEditor", null },
                    { "9852f912-4703-415e-9054-e597a5c156a9", "f38e29fc-c719-4b2b-bb67-623bf659bc5e", "Read operations on finances", new DateTime(2019, 2, 6, 18, 13, 14, 246, DateTimeKind.Local), "e2a8bd78-87eb-4e39-aafd-fd9d67e3c48e", "FinanceReader", null }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e2a8bd78-87eb-4e39-aafd-fd9d67e3c48e",
                column: "ConcurrencyStamp",
                value: "ddccfc31-70a6-4e63-a839-1ef4eca5d1d5");

            migrationBuilder.UpdateData(
                table: "BankTransactionCategorys",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 6, 18, 13, 14, 246, DateTimeKind.Local), new DateTime(2019, 2, 6, 18, 13, 14, 246, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "BankTransactionCategorys",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 6, 18, 13, 14, 246, DateTimeKind.Local), new DateTime(2019, 2, 6, 18, 13, 14, 246, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "BankTransactionCategorys",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 6, 18, 13, 14, 246, DateTimeKind.Local), new DateTime(2019, 2, 6, 18, 13, 14, 246, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "BankTransactionCategorys",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 6, 18, 13, 14, 246, DateTimeKind.Local), new DateTime(2019, 2, 6, 18, 13, 14, 246, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "BankTransactionCategorys",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 6, 18, 13, 14, 246, DateTimeKind.Local), new DateTime(2019, 2, 6, 18, 13, 14, 246, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "BankTransactionCategorys",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 6, 18, 13, 14, 246, DateTimeKind.Local), new DateTime(2019, 2, 6, 18, 13, 14, 246, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "BankTransactionCategorys",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 6, 18, 13, 14, 246, DateTimeKind.Local), new DateTime(2019, 2, 6, 18, 13, 14, 246, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 6, 18, 13, 14, 246, DateTimeKind.Local), new DateTime(2019, 2, 6, 18, 13, 14, 246, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 6, 18, 13, 14, 246, DateTimeKind.Local), new DateTime(2019, 2, 6, 18, 13, 14, 246, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 6, 18, 13, 14, 246, DateTimeKind.Local), new DateTime(2019, 2, 6, 18, 13, 14, 246, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 6, 18, 13, 14, 246, DateTimeKind.Local), new DateTime(2019, 2, 6, 18, 13, 14, 246, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 6, 18, 13, 14, 246, DateTimeKind.Local), new DateTime(2019, 2, 6, 18, 13, 14, 246, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 6, 18, 13, 14, 246, DateTimeKind.Local), new DateTime(2019, 2, 6, 18, 13, 14, 246, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 6, 18, 13, 14, 246, DateTimeKind.Local), new DateTime(2019, 2, 6, 18, 13, 14, 246, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 6, 18, 13, 14, 246, DateTimeKind.Local), new DateTime(2019, 2, 6, 18, 13, 14, 246, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 6, 18, 13, 14, 246, DateTimeKind.Local), new DateTime(2019, 2, 6, 18, 13, 14, 246, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 6, 18, 13, 14, 246, DateTimeKind.Local), new DateTime(2019, 2, 6, 18, 13, 14, 246, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 6, 18, 13, 14, 246, DateTimeKind.Local), new DateTime(2019, 2, 6, 18, 13, 14, 246, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 6, 18, 13, 14, 246, DateTimeKind.Local), new DateTime(2019, 2, 6, 18, 13, 14, 246, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 6, 18, 13, 14, 246, DateTimeKind.Local), new DateTime(2019, 2, 6, 18, 13, 14, 246, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 6, 18, 13, 14, 246, DateTimeKind.Local), new DateTime(2019, 2, 6, 18, 13, 14, 246, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 6, 18, 13, 14, 246, DateTimeKind.Local), new DateTime(2019, 2, 6, 18, 13, 14, 246, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 6, 18, 13, 14, 246, DateTimeKind.Local), new DateTime(2019, 2, 6, 18, 13, 14, 246, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 6, 18, 13, 14, 246, DateTimeKind.Local), new DateTime(2019, 2, 6, 18, 13, 14, 246, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 6, 18, 13, 14, 246, DateTimeKind.Local), new DateTime(2019, 2, 6, 18, 13, 14, 246, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 6, 18, 13, 14, 246, DateTimeKind.Local), new DateTime(2019, 2, 6, 18, 13, 14, 246, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "ID",
                keyValue: 20,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 6, 18, 13, 14, 246, DateTimeKind.Local), new DateTime(2019, 2, 6, 18, 13, 14, 246, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "ID",
                keyValue: 21,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 6, 18, 13, 14, 246, DateTimeKind.Local), new DateTime(2019, 2, 6, 18, 13, 14, 246, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "ID",
                keyValue: 22,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 6, 18, 13, 14, 246, DateTimeKind.Local), new DateTime(2019, 2, 6, 18, 13, 14, 246, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PlayerPositions",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 6, 18, 13, 14, 246, DateTimeKind.Local), new DateTime(2019, 2, 6, 18, 13, 14, 246, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PlayerPositions",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 6, 18, 13, 14, 246, DateTimeKind.Local), new DateTime(2019, 2, 6, 18, 13, 14, 246, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PlayerPositions",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 6, 18, 13, 14, 246, DateTimeKind.Local), new DateTime(2019, 2, 6, 18, 13, 14, 246, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PlayerPositions",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 6, 18, 13, 14, 246, DateTimeKind.Local), new DateTime(2019, 2, 6, 18, 13, 14, 246, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PlayerPositions",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 6, 18, 13, 14, 246, DateTimeKind.Local), new DateTime(2019, 2, 6, 18, 13, 14, 246, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PlayerPositions",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 6, 18, 13, 14, 246, DateTimeKind.Local), new DateTime(2019, 2, 6, 18, 13, 14, 246, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PlayerPositions",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 6, 18, 13, 14, 246, DateTimeKind.Local), new DateTime(2019, 2, 6, 18, 13, 14, 246, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PlayerPositions",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 6, 18, 13, 14, 246, DateTimeKind.Local), new DateTime(2019, 2, 6, 18, 13, 14, 246, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PlayerPositions",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 6, 18, 13, 14, 246, DateTimeKind.Local), new DateTime(2019, 2, 6, 18, 13, 14, 246, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PlayerPositions",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 6, 18, 13, 14, 246, DateTimeKind.Local), new DateTime(2019, 2, 6, 18, 13, 14, 246, DateTimeKind.Local) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropUniqueConstraint(
                name: "AK_BankTransactions_ReferenceNumber",
                table: "BankTransactions");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "9852f912-4703-415e-9054-e597a5c156a9", "f38e29fc-c719-4b2b-bb67-623bf659bc5e" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "bac20b58-0e01-4ea0-80a0-275ad6d674ab", "c6f4cf77-ae7d-41eb-b95e-e1437036a186" });

            migrationBuilder.AlterColumn<string>(
                name: "ReferenceNumber",
                table: "BankTransactions",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "LastModified", "LastModifiedById", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "589ef4c9-d67a-4355-b56b-cfd5b098f1f1", "a60ec7b2-54dd-4292-ae12-2881ecc8486b", "CRUD operations on finances", new DateTime(2019, 2, 5, 11, 7, 56, 652, DateTimeKind.Local), "e2a8bd78-87eb-4e39-aafd-fd9d67e3c48e", "FinaceEditor", null },
                    { "44ef7f76-eabd-497b-8535-05569afff7af", "8c6af3aa-d838-4ba9-a94f-6f2360df1b45", "Read operations on finances", new DateTime(2019, 2, 5, 11, 7, 56, 652, DateTimeKind.Local), "e2a8bd78-87eb-4e39-aafd-fd9d67e3c48e", "FinanceReader", null }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e2a8bd78-87eb-4e39-aafd-fd9d67e3c48e",
                column: "ConcurrencyStamp",
                value: "06efcae3-8e87-4b9d-a64b-6def6475e538");

            migrationBuilder.UpdateData(
                table: "BankTransactionCategorys",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 5, 11, 7, 56, 652, DateTimeKind.Local), new DateTime(2019, 2, 5, 11, 7, 56, 652, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "BankTransactionCategorys",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 5, 11, 7, 56, 652, DateTimeKind.Local), new DateTime(2019, 2, 5, 11, 7, 56, 652, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "BankTransactionCategorys",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 5, 11, 7, 56, 652, DateTimeKind.Local), new DateTime(2019, 2, 5, 11, 7, 56, 652, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "BankTransactionCategorys",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 5, 11, 7, 56, 652, DateTimeKind.Local), new DateTime(2019, 2, 5, 11, 7, 56, 652, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "BankTransactionCategorys",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 5, 11, 7, 56, 652, DateTimeKind.Local), new DateTime(2019, 2, 5, 11, 7, 56, 652, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "BankTransactionCategorys",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 5, 11, 7, 56, 652, DateTimeKind.Local), new DateTime(2019, 2, 5, 11, 7, 56, 652, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "BankTransactionCategorys",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 5, 11, 7, 56, 652, DateTimeKind.Local), new DateTime(2019, 2, 5, 11, 7, 56, 652, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 5, 11, 7, 56, 652, DateTimeKind.Local), new DateTime(2019, 2, 5, 11, 7, 56, 652, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 5, 11, 7, 56, 652, DateTimeKind.Local), new DateTime(2019, 2, 5, 11, 7, 56, 652, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 5, 11, 7, 56, 652, DateTimeKind.Local), new DateTime(2019, 2, 5, 11, 7, 56, 652, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 5, 11, 7, 56, 652, DateTimeKind.Local), new DateTime(2019, 2, 5, 11, 7, 56, 652, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 5, 11, 7, 56, 652, DateTimeKind.Local), new DateTime(2019, 2, 5, 11, 7, 56, 652, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 5, 11, 7, 56, 652, DateTimeKind.Local), new DateTime(2019, 2, 5, 11, 7, 56, 652, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 5, 11, 7, 56, 652, DateTimeKind.Local), new DateTime(2019, 2, 5, 11, 7, 56, 652, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 5, 11, 7, 56, 652, DateTimeKind.Local), new DateTime(2019, 2, 5, 11, 7, 56, 652, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 5, 11, 7, 56, 652, DateTimeKind.Local), new DateTime(2019, 2, 5, 11, 7, 56, 652, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 5, 11, 7, 56, 652, DateTimeKind.Local), new DateTime(2019, 2, 5, 11, 7, 56, 652, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 5, 11, 7, 56, 652, DateTimeKind.Local), new DateTime(2019, 2, 5, 11, 7, 56, 652, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 5, 11, 7, 56, 652, DateTimeKind.Local), new DateTime(2019, 2, 5, 11, 7, 56, 652, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 5, 11, 7, 56, 652, DateTimeKind.Local), new DateTime(2019, 2, 5, 11, 7, 56, 652, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 5, 11, 7, 56, 652, DateTimeKind.Local), new DateTime(2019, 2, 5, 11, 7, 56, 652, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 5, 11, 7, 56, 652, DateTimeKind.Local), new DateTime(2019, 2, 5, 11, 7, 56, 652, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 5, 11, 7, 56, 652, DateTimeKind.Local), new DateTime(2019, 2, 5, 11, 7, 56, 652, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 5, 11, 7, 56, 652, DateTimeKind.Local), new DateTime(2019, 2, 5, 11, 7, 56, 652, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 5, 11, 7, 56, 652, DateTimeKind.Local), new DateTime(2019, 2, 5, 11, 7, 56, 652, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 5, 11, 7, 56, 652, DateTimeKind.Local), new DateTime(2019, 2, 5, 11, 7, 56, 652, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "ID",
                keyValue: 20,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 5, 11, 7, 56, 652, DateTimeKind.Local), new DateTime(2019, 2, 5, 11, 7, 56, 652, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "ID",
                keyValue: 21,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 5, 11, 7, 56, 652, DateTimeKind.Local), new DateTime(2019, 2, 5, 11, 7, 56, 652, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "ID",
                keyValue: 22,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 5, 11, 7, 56, 652, DateTimeKind.Local), new DateTime(2019, 2, 5, 11, 7, 56, 652, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PlayerPositions",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 5, 11, 7, 56, 652, DateTimeKind.Local), new DateTime(2019, 2, 5, 11, 7, 56, 652, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PlayerPositions",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 5, 11, 7, 56, 652, DateTimeKind.Local), new DateTime(2019, 2, 5, 11, 7, 56, 652, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PlayerPositions",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 5, 11, 7, 56, 652, DateTimeKind.Local), new DateTime(2019, 2, 5, 11, 7, 56, 652, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PlayerPositions",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 5, 11, 7, 56, 652, DateTimeKind.Local), new DateTime(2019, 2, 5, 11, 7, 56, 652, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PlayerPositions",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 5, 11, 7, 56, 652, DateTimeKind.Local), new DateTime(2019, 2, 5, 11, 7, 56, 652, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PlayerPositions",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 5, 11, 7, 56, 652, DateTimeKind.Local), new DateTime(2019, 2, 5, 11, 7, 56, 652, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PlayerPositions",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 5, 11, 7, 56, 652, DateTimeKind.Local), new DateTime(2019, 2, 5, 11, 7, 56, 652, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PlayerPositions",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 5, 11, 7, 56, 652, DateTimeKind.Local), new DateTime(2019, 2, 5, 11, 7, 56, 652, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PlayerPositions",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 5, 11, 7, 56, 652, DateTimeKind.Local), new DateTime(2019, 2, 5, 11, 7, 56, 652, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PlayerPositions",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 5, 11, 7, 56, 652, DateTimeKind.Local), new DateTime(2019, 2, 5, 11, 7, 56, 652, DateTimeKind.Local) });
        }
    }
}
