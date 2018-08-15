using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ClubTreasurer.Data.Migrations
{
    public partial class Seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "BankTransactionCategorys",
                columns: new[] { "ID", "Created", "Description", "LastModified", "LastModifiedById", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2018, 8, 15, 18, 29, 41, 364, DateTimeKind.Local), null, new DateTime(2018, 8, 15, 18, 29, 41, 364, DateTimeKind.Local), "c98c8716-76a3-4c21-a155-e696959ec715", "Coaching Fees" },
                    { 2, new DateTime(2018, 8, 15, 18, 29, 41, 364, DateTimeKind.Local), null, new DateTime(2018, 8, 15, 18, 29, 41, 364, DateTimeKind.Local), "c98c8716-76a3-4c21-a155-e696959ec715", "Gym Fees" },
                    { 3, new DateTime(2018, 8, 15, 18, 29, 41, 364, DateTimeKind.Local), null, new DateTime(2018, 8, 15, 18, 29, 41, 364, DateTimeKind.Local), "c98c8716-76a3-4c21-a155-e696959ec715", "Membership Fees" },
                    { 4, new DateTime(2018, 8, 15, 18, 29, 41, 364, DateTimeKind.Local), null, new DateTime(2018, 8, 15, 18, 29, 41, 364, DateTimeKind.Local), "c98c8716-76a3-4c21-a155-e696959ec715", "Old Boys Supporters" },
                    { 5, new DateTime(2018, 8, 15, 18, 29, 41, 364, DateTimeKind.Local), null, new DateTime(2018, 8, 15, 18, 29, 41, 364, DateTimeKind.Local), "c98c8716-76a3-4c21-a155-e696959ec715", "Sponsorship" },
                    { 6, new DateTime(2018, 8, 15, 18, 29, 41, 364, DateTimeKind.Local), null, new DateTime(2018, 8, 15, 18, 29, 41, 364, DateTimeKind.Local), "c98c8716-76a3-4c21-a155-e696959ec715", "Travel Expenses" },
                    { 7, new DateTime(2018, 8, 15, 18, 29, 41, 364, DateTimeKind.Local), null, new DateTime(2018, 8, 15, 18, 29, 41, 364, DateTimeKind.Local), "c98c8716-76a3-4c21-a155-e696959ec715", "Coaches Wages" }
                });

            migrationBuilder.InsertData(
                table: "PlayerPositions",
                columns: new[] { "ID", "Created", "LastModified", "LastModifiedById", "Name" },
                values: new object[,]
                {
                    { 8, new DateTime(2018, 8, 15, 18, 29, 41, 364, DateTimeKind.Local), new DateTime(2018, 8, 15, 18, 29, 41, 364, DateTimeKind.Local), "c98c8716-76a3-4c21-a155-e696959ec715", "Second Row" },
                    { 7, new DateTime(2018, 8, 15, 18, 29, 41, 364, DateTimeKind.Local), new DateTime(2018, 8, 15, 18, 29, 41, 364, DateTimeKind.Local), "c98c8716-76a3-4c21-a155-e696959ec715", "Flanker" },
                    { 6, new DateTime(2018, 8, 15, 18, 29, 41, 364, DateTimeKind.Local), new DateTime(2018, 8, 15, 18, 29, 41, 364, DateTimeKind.Local), "c98c8716-76a3-4c21-a155-e696959ec715", "Number 8" },
                    { 5, new DateTime(2018, 8, 15, 18, 29, 41, 364, DateTimeKind.Local), new DateTime(2018, 8, 15, 18, 29, 41, 364, DateTimeKind.Local), "c98c8716-76a3-4c21-a155-e696959ec715", "Scrum Half" },
                    { 2, new DateTime(2018, 8, 15, 18, 29, 41, 364, DateTimeKind.Local), new DateTime(2018, 8, 15, 18, 29, 41, 364, DateTimeKind.Local), "c98c8716-76a3-4c21-a155-e696959ec715", "Winger" },
                    { 3, new DateTime(2018, 8, 15, 18, 29, 41, 364, DateTimeKind.Local), new DateTime(2018, 8, 15, 18, 29, 41, 364, DateTimeKind.Local), "c98c8716-76a3-4c21-a155-e696959ec715", "Center" },
                    { 9, new DateTime(2018, 8, 15, 18, 29, 41, 364, DateTimeKind.Local), new DateTime(2018, 8, 15, 18, 29, 41, 364, DateTimeKind.Local), "c98c8716-76a3-4c21-a155-e696959ec715", "Hooker" },
                    { 1, new DateTime(2018, 8, 15, 18, 29, 41, 364, DateTimeKind.Local), new DateTime(2018, 8, 15, 18, 29, 41, 364, DateTimeKind.Local), "c98c8716-76a3-4c21-a155-e696959ec715", "Full Back" },
                    { 4, new DateTime(2018, 8, 15, 18, 29, 41, 364, DateTimeKind.Local), new DateTime(2018, 8, 15, 18, 29, 41, 364, DateTimeKind.Local), "c98c8716-76a3-4c21-a155-e696959ec715", "Out Half" },
                    { 10, new DateTime(2018, 8, 15, 18, 29, 41, 364, DateTimeKind.Local), new DateTime(2018, 8, 15, 18, 29, 41, 364, DateTimeKind.Local), "c98c8716-76a3-4c21-a155-e696959ec715", "Prop" }
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
