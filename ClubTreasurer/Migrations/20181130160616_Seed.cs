using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ClubTreasurer.Migrations
{
    public partial class Seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "City", "ConcurrencyStamp", "Country", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PostalCode", "Province", "SecurityStamp", "Street", "TwoFactorEnabled", "UserName" },
                values: new object[] { "75d62078-9fbd-4f99-aaf1-074f2e5a8bea", 0, null, "2ecfe8fb-fb34-4d2a-885f-cfc4940761cf", null, "fake@fake.com", true, null, null, false, null, null, null, null, null, false, null, null, null, null, false, "seeder" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "LastModified", "LastModifiedById", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "cad39fe5-7cbd-4af5-a67d-1d2fa9a3c121", "6374d185-752b-4235-809a-f8d99d12e170", "Administrator", new DateTime(2018, 11, 30, 17, 6, 15, 774, DateTimeKind.Local), "75d62078-9fbd-4f99-aaf1-074f2e5a8bea", "Administrator", null },
                    { "72f03ad1-0280-4082-8e9b-0b3a47033ac4", "b07b8296-b67c-4d71-8412-46b9f89baf4d", "CRUD operations on finances", new DateTime(2018, 11, 30, 17, 6, 15, 774, DateTimeKind.Local), "75d62078-9fbd-4f99-aaf1-074f2e5a8bea", "FinaceEditor", null },
                    { "0a0ba4e1-dac9-4113-85cd-20493efd0124", "a3b631de-85d1-42a9-ae52-281060f46614", "Read operations on finances", new DateTime(2018, 11, 30, 17, 6, 15, 774, DateTimeKind.Local), "75d62078-9fbd-4f99-aaf1-074f2e5a8bea", "FinanceReader", null }
                });

            migrationBuilder.InsertData(
                table: "BankTransactionCategorys",
                columns: new[] { "ID", "Created", "Description", "LastModified", "LastModifiedById", "Name" },
                values: new object[,]
                {
                    { 6, new DateTime(2018, 11, 30, 17, 6, 15, 774, DateTimeKind.Local), null, new DateTime(2018, 11, 30, 17, 6, 15, 774, DateTimeKind.Local), "75d62078-9fbd-4f99-aaf1-074f2e5a8bea", "Travel Expenses" },
                    { 5, new DateTime(2018, 11, 30, 17, 6, 15, 774, DateTimeKind.Local), null, new DateTime(2018, 11, 30, 17, 6, 15, 774, DateTimeKind.Local), "75d62078-9fbd-4f99-aaf1-074f2e5a8bea", "Sponsorship" },
                    { 4, new DateTime(2018, 11, 30, 17, 6, 15, 774, DateTimeKind.Local), null, new DateTime(2018, 11, 30, 17, 6, 15, 774, DateTimeKind.Local), "75d62078-9fbd-4f99-aaf1-074f2e5a8bea", "Old Boys Supporters" },
                    { 7, new DateTime(2018, 11, 30, 17, 6, 15, 774, DateTimeKind.Local), null, new DateTime(2018, 11, 30, 17, 6, 15, 774, DateTimeKind.Local), "75d62078-9fbd-4f99-aaf1-074f2e5a8bea", "Coaches Wages" },
                    { 2, new DateTime(2018, 11, 30, 17, 6, 15, 774, DateTimeKind.Local), null, new DateTime(2018, 11, 30, 17, 6, 15, 774, DateTimeKind.Local), "75d62078-9fbd-4f99-aaf1-074f2e5a8bea", "Gym Fees" },
                    { 1, new DateTime(2018, 11, 30, 17, 6, 15, 774, DateTimeKind.Local), null, new DateTime(2018, 11, 30, 17, 6, 15, 774, DateTimeKind.Local), "75d62078-9fbd-4f99-aaf1-074f2e5a8bea", "Coaching Fees" },
                    { 3, new DateTime(2018, 11, 30, 17, 6, 15, 774, DateTimeKind.Local), null, new DateTime(2018, 11, 30, 17, 6, 15, 774, DateTimeKind.Local), "75d62078-9fbd-4f99-aaf1-074f2e5a8bea", "Membership Fees" }
                });

            migrationBuilder.InsertData(
                table: "PlayerPositions",
                columns: new[] { "ID", "Created", "LastModified", "LastModifiedById", "Name" },
                values: new object[,]
                {
                    { 9, new DateTime(2018, 11, 30, 17, 6, 15, 774, DateTimeKind.Local), new DateTime(2018, 11, 30, 17, 6, 15, 774, DateTimeKind.Local), "75d62078-9fbd-4f99-aaf1-074f2e5a8bea", "Hooker" },
                    { 1, new DateTime(2018, 11, 30, 17, 6, 15, 774, DateTimeKind.Local), new DateTime(2018, 11, 30, 17, 6, 15, 774, DateTimeKind.Local), "75d62078-9fbd-4f99-aaf1-074f2e5a8bea", "Full Back" },
                    { 2, new DateTime(2018, 11, 30, 17, 6, 15, 774, DateTimeKind.Local), new DateTime(2018, 11, 30, 17, 6, 15, 774, DateTimeKind.Local), "75d62078-9fbd-4f99-aaf1-074f2e5a8bea", "Winger" },
                    { 3, new DateTime(2018, 11, 30, 17, 6, 15, 774, DateTimeKind.Local), new DateTime(2018, 11, 30, 17, 6, 15, 774, DateTimeKind.Local), "75d62078-9fbd-4f99-aaf1-074f2e5a8bea", "Center" },
                    { 4, new DateTime(2018, 11, 30, 17, 6, 15, 774, DateTimeKind.Local), new DateTime(2018, 11, 30, 17, 6, 15, 774, DateTimeKind.Local), "75d62078-9fbd-4f99-aaf1-074f2e5a8bea", "Out Half" },
                    { 5, new DateTime(2018, 11, 30, 17, 6, 15, 774, DateTimeKind.Local), new DateTime(2018, 11, 30, 17, 6, 15, 774, DateTimeKind.Local), "75d62078-9fbd-4f99-aaf1-074f2e5a8bea", "Scrum Half" },
                    { 6, new DateTime(2018, 11, 30, 17, 6, 15, 774, DateTimeKind.Local), new DateTime(2018, 11, 30, 17, 6, 15, 774, DateTimeKind.Local), "75d62078-9fbd-4f99-aaf1-074f2e5a8bea", "Number 8" },
                    { 7, new DateTime(2018, 11, 30, 17, 6, 15, 774, DateTimeKind.Local), new DateTime(2018, 11, 30, 17, 6, 15, 774, DateTimeKind.Local), "75d62078-9fbd-4f99-aaf1-074f2e5a8bea", "Flanker" },
                    { 8, new DateTime(2018, 11, 30, 17, 6, 15, 774, DateTimeKind.Local), new DateTime(2018, 11, 30, 17, 6, 15, 774, DateTimeKind.Local), "75d62078-9fbd-4f99-aaf1-074f2e5a8bea", "Second Row" },
                    { 10, new DateTime(2018, 11, 30, 17, 6, 15, 774, DateTimeKind.Local), new DateTime(2018, 11, 30, 17, 6, 15, 774, DateTimeKind.Local), "75d62078-9fbd-4f99-aaf1-074f2e5a8bea", "Prop" }
                });

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "ID", "Created", "DOB", "Discriminator", "Email", "FirstName", "LastModified", "LastModifiedById", "LastName", "Image", "PositionId" },
                values: new object[,]
                {
                    { 4, new DateTime(2018, 11, 30, 17, 6, 15, 774, DateTimeKind.Local), new DateTime(1991, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Player", null, "Kristin", new DateTime(2018, 11, 30, 17, 6, 15, 774, DateTimeKind.Local), "75d62078-9fbd-4f99-aaf1-074f2e5a8bea", "Hiltpot", null, 2 },
                    { 5, new DateTime(2018, 11, 30, 17, 6, 15, 774, DateTimeKind.Local), new DateTime(1990, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Player", null, "Philip", new DateTime(2018, 11, 30, 17, 6, 15, 774, DateTimeKind.Local), "75d62078-9fbd-4f99-aaf1-074f2e5a8bea", "Westerlund", null, 10 },
                    { 3, new DateTime(2018, 11, 30, 17, 6, 15, 774, DateTimeKind.Local), new DateTime(1998, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Player", null, "Julia", new DateTime(2018, 11, 30, 17, 6, 15, 774, DateTimeKind.Local), "75d62078-9fbd-4f99-aaf1-074f2e5a8bea", "Hensler", null, 10 },
                    { 1, new DateTime(2018, 11, 30, 17, 6, 15, 774, DateTimeKind.Local), new DateTime(1989, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Player", null, "Max", new DateTime(2018, 11, 30, 17, 6, 15, 774, DateTimeKind.Local), "75d62078-9fbd-4f99-aaf1-074f2e5a8bea", "Büttner", null, 9 },
                    { 15, new DateTime(2018, 11, 30, 17, 6, 15, 774, DateTimeKind.Local), new DateTime(1990, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Player", null, "Sebastian", new DateTime(2018, 11, 30, 17, 6, 15, 774, DateTimeKind.Local), "75d62078-9fbd-4f99-aaf1-074f2e5a8bea", "Müller", null, 8 },
                    { 9, new DateTime(2018, 11, 30, 17, 6, 15, 774, DateTimeKind.Local), new DateTime(1994, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Player", null, "Thomas", new DateTime(2018, 11, 30, 17, 6, 15, 774, DateTimeKind.Local), "75d62078-9fbd-4f99-aaf1-074f2e5a8bea", "Tripp", null, 8 },
                    { 21, new DateTime(2018, 11, 30, 17, 6, 15, 774, DateTimeKind.Local), new DateTime(1991, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Player", null, "Lukas", new DateTime(2018, 11, 30, 17, 6, 15, 774, DateTimeKind.Local), "75d62078-9fbd-4f99-aaf1-074f2e5a8bea", "Kolb", null, 7 },
                    { 19, new DateTime(2018, 11, 30, 17, 6, 15, 774, DateTimeKind.Local), new DateTime(1995, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Player", null, "Isabella", new DateTime(2018, 11, 30, 17, 6, 15, 774, DateTimeKind.Local), "75d62078-9fbd-4f99-aaf1-074f2e5a8bea", "Luke", null, 5 },
                    { 17, new DateTime(2018, 11, 30, 17, 6, 15, 774, DateTimeKind.Local), new DateTime(1996, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Player", null, "Tom", new DateTime(2018, 11, 30, 17, 6, 15, 774, DateTimeKind.Local), "75d62078-9fbd-4f99-aaf1-074f2e5a8bea", "Millen", null, 5 },
                    { 2, new DateTime(2018, 11, 30, 17, 6, 15, 774, DateTimeKind.Local), new DateTime(1983, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Player", null, "Jeremie", new DateTime(2018, 11, 30, 17, 6, 15, 774, DateTimeKind.Local), "75d62078-9fbd-4f99-aaf1-074f2e5a8bea", "DeJean", null, 5 },
                    { 18, new DateTime(2018, 11, 30, 17, 6, 15, 774, DateTimeKind.Local), new DateTime(1985, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Player", null, "Mathias", new DateTime(2018, 11, 30, 17, 6, 15, 774, DateTimeKind.Local), "75d62078-9fbd-4f99-aaf1-074f2e5a8bea", "Märk", null, 4 },
                    { 11, new DateTime(2018, 11, 30, 17, 6, 15, 774, DateTimeKind.Local), new DateTime(1995, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Player", null, "Florian", new DateTime(2018, 11, 30, 17, 6, 15, 774, DateTimeKind.Local), "75d62078-9fbd-4f99-aaf1-074f2e5a8bea", "Rudiferia", null, 4 },
                    { 16, new DateTime(2018, 11, 30, 17, 6, 15, 774, DateTimeKind.Local), new DateTime(1995, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Player", null, "Benjamin", new DateTime(2018, 11, 30, 17, 6, 15, 774, DateTimeKind.Local), "75d62078-9fbd-4f99-aaf1-074f2e5a8bea", "Rabl", null, 3 },
                    { 20, new DateTime(2018, 11, 30, 17, 6, 15, 774, DateTimeKind.Local), new DateTime(1989, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Player", null, "Gerald", new DateTime(2018, 11, 30, 17, 6, 15, 774, DateTimeKind.Local), "75d62078-9fbd-4f99-aaf1-074f2e5a8bea", "Lerchbaumer", null, 2 },
                    { 14, new DateTime(2018, 11, 30, 17, 6, 15, 774, DateTimeKind.Local), new DateTime(1990, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Player", null, "Nesar", new DateTime(2018, 11, 30, 17, 6, 15, 774, DateTimeKind.Local), "75d62078-9fbd-4f99-aaf1-074f2e5a8bea", "Nazari", null, 2 },
                    { 13, new DateTime(2018, 11, 30, 17, 6, 15, 774, DateTimeKind.Local), new DateTime(1993, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Player", null, "Christian", new DateTime(2018, 11, 30, 17, 6, 15, 774, DateTimeKind.Local), "75d62078-9fbd-4f99-aaf1-074f2e5a8bea", "Pöhl", null, 2 },
                    { 10, new DateTime(2018, 11, 30, 17, 6, 15, 774, DateTimeKind.Local), new DateTime(1998, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Player", null, "Davide", new DateTime(2018, 11, 30, 17, 6, 15, 774, DateTimeKind.Local), "75d62078-9fbd-4f99-aaf1-074f2e5a8bea", "Sorvillo", null, 2 },
                    { 8, new DateTime(2018, 11, 30, 17, 6, 15, 774, DateTimeKind.Local), new DateTime(1989, 4, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Player", null, "Nils", new DateTime(2018, 11, 30, 17, 6, 15, 774, DateTimeKind.Local), "75d62078-9fbd-4f99-aaf1-074f2e5a8bea", "Unthan", null, 2 },
                    { 7, new DateTime(2018, 11, 30, 17, 6, 15, 774, DateTimeKind.Local), new DateTime(1994, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Player", null, "Anna", new DateTime(2018, 11, 30, 17, 6, 15, 774, DateTimeKind.Local), "75d62078-9fbd-4f99-aaf1-074f2e5a8bea", "Wallensteiner", null, 2 },
                    { 6, new DateTime(2018, 11, 30, 17, 6, 15, 774, DateTimeKind.Local), new DateTime(1998, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Player", null, "Hannah", new DateTime(2018, 11, 30, 17, 6, 15, 774, DateTimeKind.Local), "75d62078-9fbd-4f99-aaf1-074f2e5a8bea", "Werkgarner", null, 2 },
                    { 12, new DateTime(2018, 11, 30, 17, 6, 15, 774, DateTimeKind.Local), new DateTime(1991, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Player", null, "Barbara", new DateTime(2018, 11, 30, 17, 6, 15, 774, DateTimeKind.Local), "75d62078-9fbd-4f99-aaf1-074f2e5a8bea", "Rieger", null, 10 },
                    { 22, new DateTime(2018, 11, 30, 17, 6, 15, 774, DateTimeKind.Local), new DateTime(1993, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Player", null, "Khvistani", new DateTime(2018, 11, 30, 17, 6, 15, 774, DateTimeKind.Local), "75d62078-9fbd-4f99-aaf1-074f2e5a8bea", "Giorgi", null, 10 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "0a0ba4e1-dac9-4113-85cd-20493efd0124", "a3b631de-85d1-42a9-ae52-281060f46614" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "72f03ad1-0280-4082-8e9b-0b3a47033ac4", "b07b8296-b67c-4d71-8412-46b9f89baf4d" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "cad39fe5-7cbd-4af5-a67d-1d2fa9a3c121", "6374d185-752b-4235-809a-f8d99d12e170" });

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
                table: "Persons",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "ID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "ID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "ID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "ID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "ID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "ID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "ID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "ID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "ID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "ID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "ID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "ID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "ID",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "ID",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "ID",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "ID",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "PlayerPositions",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PlayerPositions",
                keyColumn: "ID",
                keyValue: 6);

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

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "75d62078-9fbd-4f99-aaf1-074f2e5a8bea", "2ecfe8fb-fb34-4d2a-885f-cfc4940761cf" });
        }
    }
}
