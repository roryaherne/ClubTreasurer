using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ClubTreasurer.Migrations
{
    public partial class BankAccOptionalFK : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BankAccounts_Persons_PersonID",
                table: "BankAccounts");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "53a35945-b9aa-4436-ba83-7934ea834b87", "d13e7ea7-f49b-4edd-909d-e4576f318ebf" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "6596d0ae-d411-48d9-97bb-bd56a2fb4829", "d2990fda-9fa4-40e2-8951-933149f29013" });

            migrationBuilder.RenameColumn(
                name: "PersonID",
                table: "BankAccounts",
                newName: "PersonId");

            migrationBuilder.RenameIndex(
                name: "IX_BankAccounts_PersonID",
                table: "BankAccounts",
                newName: "IX_BankAccounts_PersonId");

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
                columns: new[] { "Created", "KeyWords", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 5, 10, 53, 47, 556, DateTimeKind.Local), "coaching", new DateTime(2019, 2, 5, 10, 53, 47, 556, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "BankTransactionCategorys",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "Created", "KeyWords", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 5, 10, 53, 47, 556, DateTimeKind.Local), "gym,fitness", new DateTime(2019, 2, 5, 10, 53, 47, 556, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "BankTransactionCategorys",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "Created", "KeyWords", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 5, 10, 53, 47, 556, DateTimeKind.Local), "mitglied,membership", new DateTime(2019, 2, 5, 10, 53, 47, 556, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "BankTransactionCategorys",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "Created", "KeyWords", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 5, 10, 53, 47, 556, DateTimeKind.Local), "old boys,oldboys", new DateTime(2019, 2, 5, 10, 53, 47, 556, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "BankTransactionCategorys",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "Created", "KeyWords", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 5, 10, 53, 47, 556, DateTimeKind.Local), "sponsor", new DateTime(2019, 2, 5, 10, 53, 47, 556, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "BankTransactionCategorys",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "Created", "KeyWords", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 5, 10, 53, 47, 556, DateTimeKind.Local), "travel,fuel,train,zug", new DateTime(2019, 2, 5, 10, 53, 47, 556, DateTimeKind.Local) });

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

            migrationBuilder.AddForeignKey(
                name: "FK_BankAccounts_Persons_PersonId",
                table: "BankAccounts",
                column: "PersonId",
                principalTable: "Persons",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BankAccounts_Persons_PersonId",
                table: "BankAccounts");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "687b65df-3371-4cc4-81a4-9ec5a2a757c8", "3a7e7eb6-7d36-45e5-b4f5-947022975743" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "aae9b38a-9c11-468d-a579-c5b409e49b46", "07e28150-65d6-482b-8825-9baa3f1402fe" });

            migrationBuilder.RenameColumn(
                name: "PersonId",
                table: "BankAccounts",
                newName: "PersonID");

            migrationBuilder.RenameIndex(
                name: "IX_BankAccounts_PersonId",
                table: "BankAccounts",
                newName: "IX_BankAccounts_PersonID");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "LastModified", "LastModifiedById", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "6596d0ae-d411-48d9-97bb-bd56a2fb4829", "d2990fda-9fa4-40e2-8951-933149f29013", "CRUD operations on finances", new DateTime(2019, 2, 1, 19, 3, 34, 826, DateTimeKind.Local), "e2a8bd78-87eb-4e39-aafd-fd9d67e3c48e", "FinaceEditor", null },
                    { "53a35945-b9aa-4436-ba83-7934ea834b87", "d13e7ea7-f49b-4edd-909d-e4576f318ebf", "Read operations on finances", new DateTime(2019, 2, 1, 19, 3, 34, 826, DateTimeKind.Local), "e2a8bd78-87eb-4e39-aafd-fd9d67e3c48e", "FinanceReader", null }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e2a8bd78-87eb-4e39-aafd-fd9d67e3c48e",
                column: "ConcurrencyStamp",
                value: "cbb57315-e61d-4362-aa1b-3167d74e0fd7");

            migrationBuilder.UpdateData(
                table: "BankTransactionCategorys",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "Created", "KeyWords", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 1, 19, 3, 34, 826, DateTimeKind.Local), null, new DateTime(2019, 2, 1, 19, 3, 34, 826, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "BankTransactionCategorys",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "Created", "KeyWords", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 1, 19, 3, 34, 826, DateTimeKind.Local), null, new DateTime(2019, 2, 1, 19, 3, 34, 826, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "BankTransactionCategorys",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "Created", "KeyWords", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 1, 19, 3, 34, 826, DateTimeKind.Local), null, new DateTime(2019, 2, 1, 19, 3, 34, 826, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "BankTransactionCategorys",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "Created", "KeyWords", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 1, 19, 3, 34, 826, DateTimeKind.Local), null, new DateTime(2019, 2, 1, 19, 3, 34, 826, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "BankTransactionCategorys",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "Created", "KeyWords", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 1, 19, 3, 34, 826, DateTimeKind.Local), null, new DateTime(2019, 2, 1, 19, 3, 34, 826, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "BankTransactionCategorys",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "Created", "KeyWords", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 1, 19, 3, 34, 826, DateTimeKind.Local), null, new DateTime(2019, 2, 1, 19, 3, 34, 826, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "BankTransactionCategorys",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 1, 19, 3, 34, 826, DateTimeKind.Local), new DateTime(2019, 2, 1, 19, 3, 34, 826, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 1, 19, 3, 34, 826, DateTimeKind.Local), new DateTime(2019, 2, 1, 19, 3, 34, 826, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 1, 19, 3, 34, 826, DateTimeKind.Local), new DateTime(2019, 2, 1, 19, 3, 34, 826, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 1, 19, 3, 34, 826, DateTimeKind.Local), new DateTime(2019, 2, 1, 19, 3, 34, 826, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 1, 19, 3, 34, 826, DateTimeKind.Local), new DateTime(2019, 2, 1, 19, 3, 34, 826, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 1, 19, 3, 34, 826, DateTimeKind.Local), new DateTime(2019, 2, 1, 19, 3, 34, 826, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 1, 19, 3, 34, 826, DateTimeKind.Local), new DateTime(2019, 2, 1, 19, 3, 34, 826, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 1, 19, 3, 34, 826, DateTimeKind.Local), new DateTime(2019, 2, 1, 19, 3, 34, 826, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 1, 19, 3, 34, 826, DateTimeKind.Local), new DateTime(2019, 2, 1, 19, 3, 34, 826, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 1, 19, 3, 34, 826, DateTimeKind.Local), new DateTime(2019, 2, 1, 19, 3, 34, 826, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 1, 19, 3, 34, 826, DateTimeKind.Local), new DateTime(2019, 2, 1, 19, 3, 34, 826, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 1, 19, 3, 34, 826, DateTimeKind.Local), new DateTime(2019, 2, 1, 19, 3, 34, 826, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 1, 19, 3, 34, 826, DateTimeKind.Local), new DateTime(2019, 2, 1, 19, 3, 34, 826, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 1, 19, 3, 34, 826, DateTimeKind.Local), new DateTime(2019, 2, 1, 19, 3, 34, 826, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 1, 19, 3, 34, 826, DateTimeKind.Local), new DateTime(2019, 2, 1, 19, 3, 34, 826, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 1, 19, 3, 34, 826, DateTimeKind.Local), new DateTime(2019, 2, 1, 19, 3, 34, 826, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 1, 19, 3, 34, 826, DateTimeKind.Local), new DateTime(2019, 2, 1, 19, 3, 34, 826, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 1, 19, 3, 34, 826, DateTimeKind.Local), new DateTime(2019, 2, 1, 19, 3, 34, 826, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 1, 19, 3, 34, 826, DateTimeKind.Local), new DateTime(2019, 2, 1, 19, 3, 34, 826, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 1, 19, 3, 34, 826, DateTimeKind.Local), new DateTime(2019, 2, 1, 19, 3, 34, 826, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "ID",
                keyValue: 20,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 1, 19, 3, 34, 826, DateTimeKind.Local), new DateTime(2019, 2, 1, 19, 3, 34, 826, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "ID",
                keyValue: 21,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 1, 19, 3, 34, 826, DateTimeKind.Local), new DateTime(2019, 2, 1, 19, 3, 34, 826, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "ID",
                keyValue: 22,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 1, 19, 3, 34, 826, DateTimeKind.Local), new DateTime(2019, 2, 1, 19, 3, 34, 826, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PlayerPositions",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 1, 19, 3, 34, 826, DateTimeKind.Local), new DateTime(2019, 2, 1, 19, 3, 34, 826, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PlayerPositions",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 1, 19, 3, 34, 826, DateTimeKind.Local), new DateTime(2019, 2, 1, 19, 3, 34, 826, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PlayerPositions",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 1, 19, 3, 34, 826, DateTimeKind.Local), new DateTime(2019, 2, 1, 19, 3, 34, 826, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PlayerPositions",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 1, 19, 3, 34, 826, DateTimeKind.Local), new DateTime(2019, 2, 1, 19, 3, 34, 826, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PlayerPositions",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 1, 19, 3, 34, 826, DateTimeKind.Local), new DateTime(2019, 2, 1, 19, 3, 34, 826, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PlayerPositions",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 1, 19, 3, 34, 826, DateTimeKind.Local), new DateTime(2019, 2, 1, 19, 3, 34, 826, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PlayerPositions",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 1, 19, 3, 34, 826, DateTimeKind.Local), new DateTime(2019, 2, 1, 19, 3, 34, 826, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PlayerPositions",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 1, 19, 3, 34, 826, DateTimeKind.Local), new DateTime(2019, 2, 1, 19, 3, 34, 826, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PlayerPositions",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 1, 19, 3, 34, 826, DateTimeKind.Local), new DateTime(2019, 2, 1, 19, 3, 34, 826, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PlayerPositions",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 1, 19, 3, 34, 826, DateTimeKind.Local), new DateTime(2019, 2, 1, 19, 3, 34, 826, DateTimeKind.Local) });

            migrationBuilder.AddForeignKey(
                name: "FK_BankAccounts_Persons_PersonID",
                table: "BankAccounts",
                column: "PersonID",
                principalTable: "Persons",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
