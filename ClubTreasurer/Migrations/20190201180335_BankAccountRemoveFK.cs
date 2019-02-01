using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ClubTreasurer.Migrations
{
    public partial class BankAccountRemoveFK : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BankAccounts_Persons_PersonId",
                table: "BankAccounts");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "1c119311-17d7-4d20-a1e5-00f426e30475", "351ec1cd-2d82-44c2-a6b6-e52e2b5ba45e" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "8ec7d191-ce84-4b01-a69f-174458c75646", "00b520bd-083b-4dbd-aedd-8e379b381591" });

            migrationBuilder.RenameColumn(
                name: "PersonId",
                table: "BankAccounts",
                newName: "PersonID");

            migrationBuilder.RenameIndex(
                name: "IX_BankAccounts_PersonId",
                table: "BankAccounts",
                newName: "IX_BankAccounts_PersonID");

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Persons",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PersonID",
                table: "BankAccounts",
                nullable: true,
                oldClrType: typeof(int));

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
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 1, 19, 3, 34, 826, DateTimeKind.Local), new DateTime(2019, 2, 1, 19, 3, 34, 826, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "BankTransactionCategorys",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 1, 19, 3, 34, 826, DateTimeKind.Local), new DateTime(2019, 2, 1, 19, 3, 34, 826, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "BankTransactionCategorys",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 1, 19, 3, 34, 826, DateTimeKind.Local), new DateTime(2019, 2, 1, 19, 3, 34, 826, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "BankTransactionCategorys",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 1, 19, 3, 34, 826, DateTimeKind.Local), new DateTime(2019, 2, 1, 19, 3, 34, 826, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "BankTransactionCategorys",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 1, 19, 3, 34, 826, DateTimeKind.Local), new DateTime(2019, 2, 1, 19, 3, 34, 826, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "BankTransactionCategorys",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2019, 2, 1, 19, 3, 34, 826, DateTimeKind.Local), new DateTime(2019, 2, 1, 19, 3, 34, 826, DateTimeKind.Local) });

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "Title",
                table: "Persons");

            migrationBuilder.RenameColumn(
                name: "PersonID",
                table: "BankAccounts",
                newName: "PersonId");

            migrationBuilder.RenameIndex(
                name: "IX_BankAccounts_PersonID",
                table: "BankAccounts",
                newName: "IX_BankAccounts_PersonId");

            migrationBuilder.AlterColumn<int>(
                name: "PersonId",
                table: "BankAccounts",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

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

            migrationBuilder.AddForeignKey(
                name: "FK_BankAccounts_Persons_PersonId",
                table: "BankAccounts",
                column: "PersonId",
                principalTable: "Persons",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
