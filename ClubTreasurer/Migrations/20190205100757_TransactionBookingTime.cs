using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ClubTreasurer.Migrations
{
    public partial class TransactionBookingTime : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "687b65df-3371-4cc4-81a4-9ec5a2a757c8", "3a7e7eb6-7d36-45e5-b4f5-947022975743" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "aae9b38a-9c11-468d-a579-c5b409e49b46", "07e28150-65d6-482b-8825-9baa3f1402fe" });

            migrationBuilder.AddColumn<DateTime>(
                name: "BookingDate",
                table: "BankTransactions",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "44ef7f76-eabd-497b-8535-05569afff7af", "8c6af3aa-d838-4ba9-a94f-6f2360df1b45" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "589ef4c9-d67a-4355-b56b-cfd5b098f1f1", "a60ec7b2-54dd-4292-ae12-2881ecc8486b" });

            migrationBuilder.DropColumn(
                name: "BookingDate",
                table: "BankTransactions");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "LastModified", "LastModifiedById", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "687b65df-3371-4cc4-81a4-9ec5a2a757c8", "3a7e7eb6-7d36-45e5-b4f5-947022975743", "CRUD operations on finances", new DateTime(2019, 2, 5, 10, 53, 47, 556, DateTimeKind.Local), "e2a8bd78-87eb-4e39-aafd-fd9d67e3c48e", "FinaceEditor", null },
                    { "aae9b38a-9c11-468d-a579-c5b409e49b46", "07e28150-65d6-482b-8825-9baa3f1402fe", "Read operations on finances", new DateTime(2019, 2, 5, 10, 53, 47, 556, DateTimeKind.Local), "e2a8bd78-87eb-4e39-aafd-fd9d67e3c48e", "FinanceReader", null }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e2a8bd78-87eb-4e39-aafd-fd9d67e3c48e",
                column: "ConcurrencyStamp",
                value: "ef2db7f5-503f-4b12-985b-a379e9f37384");

            migrationBuilder.UpdateData(
                table: "BankTransactionCategorys",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 5, 10, 53, 47, 556, DateTimeKind.Local), new DateTime(2019, 2, 5, 10, 53, 47, 556, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "BankTransactionCategorys",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 5, 10, 53, 47, 556, DateTimeKind.Local), new DateTime(2019, 2, 5, 10, 53, 47, 556, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "BankTransactionCategorys",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 5, 10, 53, 47, 556, DateTimeKind.Local), new DateTime(2019, 2, 5, 10, 53, 47, 556, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "BankTransactionCategorys",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 5, 10, 53, 47, 556, DateTimeKind.Local), new DateTime(2019, 2, 5, 10, 53, 47, 556, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "BankTransactionCategorys",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 5, 10, 53, 47, 556, DateTimeKind.Local), new DateTime(2019, 2, 5, 10, 53, 47, 556, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "BankTransactionCategorys",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 5, 10, 53, 47, 556, DateTimeKind.Local), new DateTime(2019, 2, 5, 10, 53, 47, 556, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "BankTransactionCategorys",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 5, 10, 53, 47, 556, DateTimeKind.Local), new DateTime(2019, 2, 5, 10, 53, 47, 556, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 5, 10, 53, 47, 556, DateTimeKind.Local), new DateTime(2019, 2, 5, 10, 53, 47, 556, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 5, 10, 53, 47, 556, DateTimeKind.Local), new DateTime(2019, 2, 5, 10, 53, 47, 556, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 5, 10, 53, 47, 556, DateTimeKind.Local), new DateTime(2019, 2, 5, 10, 53, 47, 556, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 5, 10, 53, 47, 556, DateTimeKind.Local), new DateTime(2019, 2, 5, 10, 53, 47, 556, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 5, 10, 53, 47, 556, DateTimeKind.Local), new DateTime(2019, 2, 5, 10, 53, 47, 556, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 5, 10, 53, 47, 556, DateTimeKind.Local), new DateTime(2019, 2, 5, 10, 53, 47, 556, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 5, 10, 53, 47, 556, DateTimeKind.Local), new DateTime(2019, 2, 5, 10, 53, 47, 556, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 5, 10, 53, 47, 556, DateTimeKind.Local), new DateTime(2019, 2, 5, 10, 53, 47, 556, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 5, 10, 53, 47, 556, DateTimeKind.Local), new DateTime(2019, 2, 5, 10, 53, 47, 556, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 5, 10, 53, 47, 556, DateTimeKind.Local), new DateTime(2019, 2, 5, 10, 53, 47, 556, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 5, 10, 53, 47, 556, DateTimeKind.Local), new DateTime(2019, 2, 5, 10, 53, 47, 556, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 5, 10, 53, 47, 556, DateTimeKind.Local), new DateTime(2019, 2, 5, 10, 53, 47, 556, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 5, 10, 53, 47, 556, DateTimeKind.Local), new DateTime(2019, 2, 5, 10, 53, 47, 556, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 5, 10, 53, 47, 556, DateTimeKind.Local), new DateTime(2019, 2, 5, 10, 53, 47, 556, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 5, 10, 53, 47, 556, DateTimeKind.Local), new DateTime(2019, 2, 5, 10, 53, 47, 556, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 5, 10, 53, 47, 556, DateTimeKind.Local), new DateTime(2019, 2, 5, 10, 53, 47, 556, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 5, 10, 53, 47, 556, DateTimeKind.Local), new DateTime(2019, 2, 5, 10, 53, 47, 556, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 5, 10, 53, 47, 556, DateTimeKind.Local), new DateTime(2019, 2, 5, 10, 53, 47, 556, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 5, 10, 53, 47, 556, DateTimeKind.Local), new DateTime(2019, 2, 5, 10, 53, 47, 556, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "ID",
                keyValue: 20,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 5, 10, 53, 47, 556, DateTimeKind.Local), new DateTime(2019, 2, 5, 10, 53, 47, 556, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "ID",
                keyValue: 21,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 5, 10, 53, 47, 556, DateTimeKind.Local), new DateTime(2019, 2, 5, 10, 53, 47, 556, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "ID",
                keyValue: 22,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 5, 10, 53, 47, 556, DateTimeKind.Local), new DateTime(2019, 2, 5, 10, 53, 47, 556, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PlayerPositions",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 5, 10, 53, 47, 556, DateTimeKind.Local), new DateTime(2019, 2, 5, 10, 53, 47, 556, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PlayerPositions",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 5, 10, 53, 47, 556, DateTimeKind.Local), new DateTime(2019, 2, 5, 10, 53, 47, 556, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PlayerPositions",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 5, 10, 53, 47, 556, DateTimeKind.Local), new DateTime(2019, 2, 5, 10, 53, 47, 556, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PlayerPositions",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 5, 10, 53, 47, 556, DateTimeKind.Local), new DateTime(2019, 2, 5, 10, 53, 47, 556, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PlayerPositions",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 5, 10, 53, 47, 556, DateTimeKind.Local), new DateTime(2019, 2, 5, 10, 53, 47, 556, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PlayerPositions",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 5, 10, 53, 47, 556, DateTimeKind.Local), new DateTime(2019, 2, 5, 10, 53, 47, 556, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PlayerPositions",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 5, 10, 53, 47, 556, DateTimeKind.Local), new DateTime(2019, 2, 5, 10, 53, 47, 556, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PlayerPositions",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 5, 10, 53, 47, 556, DateTimeKind.Local), new DateTime(2019, 2, 5, 10, 53, 47, 556, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PlayerPositions",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 5, 10, 53, 47, 556, DateTimeKind.Local), new DateTime(2019, 2, 5, 10, 53, 47, 556, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PlayerPositions",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 5, 10, 53, 47, 556, DateTimeKind.Local), new DateTime(2019, 2, 5, 10, 53, 47, 556, DateTimeKind.Local) });
        }
    }
}
