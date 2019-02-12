using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ClubTreasurer.Migrations
{
    public partial class OneToOneOptional : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BankAccounts_Persons_PersonId",
                table: "BankAccounts");

            migrationBuilder.DropIndex(
                name: "IX_BankAccounts_PersonId",
                table: "BankAccounts");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "9852f912-4703-415e-9054-e597a5c156a9", "f38e29fc-c719-4b2b-bb67-623bf659bc5e" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "bac20b58-0e01-4ea0-80a0-275ad6d674ab", "c6f4cf77-ae7d-41eb-b95e-e1437036a186" });

            migrationBuilder.AddColumn<int>(
                name: "BankAccountId",
                table: "Persons",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "LastModified", "LastModifiedById", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3159d0ce-a321-40fa-b845-8e3be33470e1", "f8e812a9-f097-4698-a41b-3e88e58044bc", "CRUD operations on finances", new DateTime(2019, 2, 11, 15, 28, 23, 100, DateTimeKind.Local), "e2a8bd78-87eb-4e39-aafd-fd9d67e3c48e", "FinaceEditor", null },
                    { "42a11a85-33a4-448f-8337-29177e685013", "c8373eab-5f51-411f-8c9a-b1f44336296a", "Read operations on finances", new DateTime(2019, 2, 11, 15, 28, 23, 100, DateTimeKind.Local), "e2a8bd78-87eb-4e39-aafd-fd9d67e3c48e", "FinanceReader", null }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e2a8bd78-87eb-4e39-aafd-fd9d67e3c48e",
                column: "ConcurrencyStamp",
                value: "575aa16d-dc82-44ff-a14a-de1ce1e389ea");

            migrationBuilder.UpdateData(
                table: "BankTransactionCategorys",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 11, 15, 28, 23, 100, DateTimeKind.Local), new DateTime(2019, 2, 11, 15, 28, 23, 100, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "BankTransactionCategorys",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 11, 15, 28, 23, 100, DateTimeKind.Local), new DateTime(2019, 2, 11, 15, 28, 23, 100, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "BankTransactionCategorys",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 11, 15, 28, 23, 100, DateTimeKind.Local), new DateTime(2019, 2, 11, 15, 28, 23, 100, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "BankTransactionCategorys",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 11, 15, 28, 23, 100, DateTimeKind.Local), new DateTime(2019, 2, 11, 15, 28, 23, 100, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "BankTransactionCategorys",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 11, 15, 28, 23, 100, DateTimeKind.Local), new DateTime(2019, 2, 11, 15, 28, 23, 100, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "BankTransactionCategorys",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 11, 15, 28, 23, 100, DateTimeKind.Local), new DateTime(2019, 2, 11, 15, 28, 23, 100, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "BankTransactionCategorys",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 11, 15, 28, 23, 100, DateTimeKind.Local), new DateTime(2019, 2, 11, 15, 28, 23, 100, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 11, 15, 28, 23, 100, DateTimeKind.Local), new DateTime(2019, 2, 11, 15, 28, 23, 100, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 11, 15, 28, 23, 100, DateTimeKind.Local), new DateTime(2019, 2, 11, 15, 28, 23, 100, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 11, 15, 28, 23, 100, DateTimeKind.Local), new DateTime(2019, 2, 11, 15, 28, 23, 100, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 11, 15, 28, 23, 100, DateTimeKind.Local), new DateTime(2019, 2, 11, 15, 28, 23, 100, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 11, 15, 28, 23, 100, DateTimeKind.Local), new DateTime(2019, 2, 11, 15, 28, 23, 100, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 11, 15, 28, 23, 100, DateTimeKind.Local), new DateTime(2019, 2, 11, 15, 28, 23, 100, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 11, 15, 28, 23, 100, DateTimeKind.Local), new DateTime(2019, 2, 11, 15, 28, 23, 100, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 11, 15, 28, 23, 100, DateTimeKind.Local), new DateTime(2019, 2, 11, 15, 28, 23, 100, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 11, 15, 28, 23, 100, DateTimeKind.Local), new DateTime(2019, 2, 11, 15, 28, 23, 100, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 11, 15, 28, 23, 100, DateTimeKind.Local), new DateTime(2019, 2, 11, 15, 28, 23, 100, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 11, 15, 28, 23, 100, DateTimeKind.Local), new DateTime(2019, 2, 11, 15, 28, 23, 100, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 11, 15, 28, 23, 100, DateTimeKind.Local), new DateTime(2019, 2, 11, 15, 28, 23, 100, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 11, 15, 28, 23, 100, DateTimeKind.Local), new DateTime(2019, 2, 11, 15, 28, 23, 100, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 11, 15, 28, 23, 100, DateTimeKind.Local), new DateTime(2019, 2, 11, 15, 28, 23, 100, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 11, 15, 28, 23, 100, DateTimeKind.Local), new DateTime(2019, 2, 11, 15, 28, 23, 100, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 11, 15, 28, 23, 100, DateTimeKind.Local), new DateTime(2019, 2, 11, 15, 28, 23, 100, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 11, 15, 28, 23, 100, DateTimeKind.Local), new DateTime(2019, 2, 11, 15, 28, 23, 100, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 11, 15, 28, 23, 100, DateTimeKind.Local), new DateTime(2019, 2, 11, 15, 28, 23, 100, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 11, 15, 28, 23, 100, DateTimeKind.Local), new DateTime(2019, 2, 11, 15, 28, 23, 100, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "ID",
                keyValue: 20,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 11, 15, 28, 23, 100, DateTimeKind.Local), new DateTime(2019, 2, 11, 15, 28, 23, 100, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "ID",
                keyValue: 21,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 11, 15, 28, 23, 100, DateTimeKind.Local), new DateTime(2019, 2, 11, 15, 28, 23, 100, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "ID",
                keyValue: 22,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 11, 15, 28, 23, 100, DateTimeKind.Local), new DateTime(2019, 2, 11, 15, 28, 23, 100, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PlayerPositions",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 11, 15, 28, 23, 100, DateTimeKind.Local), new DateTime(2019, 2, 11, 15, 28, 23, 100, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PlayerPositions",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 11, 15, 28, 23, 100, DateTimeKind.Local), new DateTime(2019, 2, 11, 15, 28, 23, 100, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PlayerPositions",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 11, 15, 28, 23, 100, DateTimeKind.Local), new DateTime(2019, 2, 11, 15, 28, 23, 100, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PlayerPositions",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 11, 15, 28, 23, 100, DateTimeKind.Local), new DateTime(2019, 2, 11, 15, 28, 23, 100, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PlayerPositions",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 11, 15, 28, 23, 100, DateTimeKind.Local), new DateTime(2019, 2, 11, 15, 28, 23, 100, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PlayerPositions",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 11, 15, 28, 23, 100, DateTimeKind.Local), new DateTime(2019, 2, 11, 15, 28, 23, 100, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PlayerPositions",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 11, 15, 28, 23, 100, DateTimeKind.Local), new DateTime(2019, 2, 11, 15, 28, 23, 100, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PlayerPositions",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 11, 15, 28, 23, 100, DateTimeKind.Local), new DateTime(2019, 2, 11, 15, 28, 23, 100, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PlayerPositions",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 11, 15, 28, 23, 100, DateTimeKind.Local), new DateTime(2019, 2, 11, 15, 28, 23, 100, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PlayerPositions",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 11, 15, 28, 23, 100, DateTimeKind.Local), new DateTime(2019, 2, 11, 15, 28, 23, 100, DateTimeKind.Local) });

            migrationBuilder.CreateIndex(
                name: "IX_Persons_BankAccountId",
                table: "Persons",
                column: "BankAccountId",
                unique: true,
                filter: "[BankAccountId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Persons_BankAccounts_BankAccountId",
                table: "Persons",
                column: "BankAccountId",
                principalTable: "BankAccounts",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Persons_BankAccounts_BankAccountId",
                table: "Persons");

            migrationBuilder.DropIndex(
                name: "IX_Persons_BankAccountId",
                table: "Persons");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "3159d0ce-a321-40fa-b845-8e3be33470e1", "f8e812a9-f097-4698-a41b-3e88e58044bc" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "42a11a85-33a4-448f-8337-29177e685013", "c8373eab-5f51-411f-8c9a-b1f44336296a" });

            migrationBuilder.DropColumn(
                name: "BankAccountId",
                table: "Persons");

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

            migrationBuilder.CreateIndex(
                name: "IX_BankAccounts_PersonId",
                table: "BankAccounts",
                column: "PersonId");

            migrationBuilder.AddForeignKey(
                name: "FK_BankAccounts_Persons_PersonId",
                table: "BankAccounts",
                column: "PersonId",
                principalTable: "Persons",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
