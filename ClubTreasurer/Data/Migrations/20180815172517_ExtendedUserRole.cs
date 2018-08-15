using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ClubTreasurer.Data.Migrations
{
    public partial class ExtendedUserRole : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PostalCode",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Province",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Street",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "AspNetRoles",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModified",
                table: "AspNetRoles",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "LastModifiedById",
                table: "AspNetRoles",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoles_LastModifiedById",
                table: "AspNetRoles",
                column: "LastModifiedById");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetRoles_AspNetUsers_LastModifiedById",
                table: "AspNetRoles",
                column: "LastModifiedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetRoles_AspNetUsers_LastModifiedById",
                table: "AspNetRoles");

            migrationBuilder.DropIndex(
                name: "IX_AspNetRoles_LastModifiedById",
                table: "AspNetRoles");

            migrationBuilder.DropColumn(
                name: "City",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Country",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "PostalCode",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Province",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Street",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "AspNetRoles");

            migrationBuilder.DropColumn(
                name: "LastModified",
                table: "AspNetRoles");

            migrationBuilder.DropColumn(
                name: "LastModifiedById",
                table: "AspNetRoles");

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: "");

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
    }
}
