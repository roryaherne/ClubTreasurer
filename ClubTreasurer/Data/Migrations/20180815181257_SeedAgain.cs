using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ClubTreasurer.Data.Migrations
{
    public partial class SeedAgain : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "BankTransactionCategorys",
                columns: new[] { "ID", "Created", "Description", "LastModified", "LastModifiedById", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2018, 8, 15, 20, 12, 56, 877, DateTimeKind.Local), null, new DateTime(2018, 8, 15, 20, 12, 56, 877, DateTimeKind.Local), "cc07b6bb-3f27-4123-a6e5-41a610794478", "Coaching Fees" },
                    { 2, new DateTime(2018, 8, 15, 20, 12, 56, 877, DateTimeKind.Local), null, new DateTime(2018, 8, 15, 20, 12, 56, 877, DateTimeKind.Local), "cc07b6bb-3f27-4123-a6e5-41a610794478", "Gym Fees" },
                    { 3, new DateTime(2018, 8, 15, 20, 12, 56, 877, DateTimeKind.Local), null, new DateTime(2018, 8, 15, 20, 12, 56, 877, DateTimeKind.Local), "cc07b6bb-3f27-4123-a6e5-41a610794478", "Membership Fees" },
                    { 4, new DateTime(2018, 8, 15, 20, 12, 56, 877, DateTimeKind.Local), null, new DateTime(2018, 8, 15, 20, 12, 56, 877, DateTimeKind.Local), "cc07b6bb-3f27-4123-a6e5-41a610794478", "Old Boys Supporters" },
                    { 5, new DateTime(2018, 8, 15, 20, 12, 56, 877, DateTimeKind.Local), null, new DateTime(2018, 8, 15, 20, 12, 56, 877, DateTimeKind.Local), "cc07b6bb-3f27-4123-a6e5-41a610794478", "Sponsorship" },
                    { 6, new DateTime(2018, 8, 15, 20, 12, 56, 877, DateTimeKind.Local), null, new DateTime(2018, 8, 15, 20, 12, 56, 877, DateTimeKind.Local), "cc07b6bb-3f27-4123-a6e5-41a610794478", "Travel Expenses" },
                    { 7, new DateTime(2018, 8, 15, 20, 12, 56, 877, DateTimeKind.Local), null, new DateTime(2018, 8, 15, 20, 12, 56, 877, DateTimeKind.Local), "cc07b6bb-3f27-4123-a6e5-41a610794478", "Coaches Wages" }
                });

            migrationBuilder.InsertData(
                table: "PlayerPositions",
                columns: new[] { "ID", "Created", "LastModified", "LastModifiedById", "Name" },
                values: new object[,]
                {
                    { 8, new DateTime(2018, 8, 15, 20, 12, 56, 877, DateTimeKind.Local), new DateTime(2018, 8, 15, 20, 12, 56, 877, DateTimeKind.Local), "cc07b6bb-3f27-4123-a6e5-41a610794478", "Second Row" },
                    { 7, new DateTime(2018, 8, 15, 20, 12, 56, 877, DateTimeKind.Local), new DateTime(2018, 8, 15, 20, 12, 56, 877, DateTimeKind.Local), "cc07b6bb-3f27-4123-a6e5-41a610794478", "Flanker" },
                    { 6, new DateTime(2018, 8, 15, 20, 12, 56, 877, DateTimeKind.Local), new DateTime(2018, 8, 15, 20, 12, 56, 877, DateTimeKind.Local), "cc07b6bb-3f27-4123-a6e5-41a610794478", "Number 8" },
                    { 5, new DateTime(2018, 8, 15, 20, 12, 56, 877, DateTimeKind.Local), new DateTime(2018, 8, 15, 20, 12, 56, 877, DateTimeKind.Local), "cc07b6bb-3f27-4123-a6e5-41a610794478", "Scrum Half" },
                    { 2, new DateTime(2018, 8, 15, 20, 12, 56, 877, DateTimeKind.Local), new DateTime(2018, 8, 15, 20, 12, 56, 877, DateTimeKind.Local), "cc07b6bb-3f27-4123-a6e5-41a610794478", "Winger" },
                    { 3, new DateTime(2018, 8, 15, 20, 12, 56, 877, DateTimeKind.Local), new DateTime(2018, 8, 15, 20, 12, 56, 877, DateTimeKind.Local), "cc07b6bb-3f27-4123-a6e5-41a610794478", "Center" },
                    { 9, new DateTime(2018, 8, 15, 20, 12, 56, 877, DateTimeKind.Local), new DateTime(2018, 8, 15, 20, 12, 56, 877, DateTimeKind.Local), "cc07b6bb-3f27-4123-a6e5-41a610794478", "Hooker" },
                    { 1, new DateTime(2018, 8, 15, 20, 12, 56, 877, DateTimeKind.Local), new DateTime(2018, 8, 15, 20, 12, 56, 877, DateTimeKind.Local), "cc07b6bb-3f27-4123-a6e5-41a610794478", "Full Back" },
                    { 4, new DateTime(2018, 8, 15, 20, 12, 56, 877, DateTimeKind.Local), new DateTime(2018, 8, 15, 20, 12, 56, 877, DateTimeKind.Local), "cc07b6bb-3f27-4123-a6e5-41a610794478", "Out Half" },
                    { 10, new DateTime(2018, 8, 15, 20, 12, 56, 877, DateTimeKind.Local), new DateTime(2018, 8, 15, 20, 12, 56, 877, DateTimeKind.Local), "cc07b6bb-3f27-4123-a6e5-41a610794478", "Prop" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BankTransactionCategorys",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "BankTransactionCategorys",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "BankTransactionCategorys",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "BankTransactionCategorys",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "BankTransactionCategorys",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "BankTransactionCategorys",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "BankTransactionCategorys",
                keyColumn: "ID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "PlayerPositions",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PlayerPositions",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "PlayerPositions",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "PlayerPositions",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "PlayerPositions",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "PlayerPositions",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "PlayerPositions",
                keyColumn: "ID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "PlayerPositions",
                keyColumn: "ID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "PlayerPositions",
                keyColumn: "ID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "PlayerPositions",
                keyColumn: "ID",
                keyValue: 10);
        }
    }
}
