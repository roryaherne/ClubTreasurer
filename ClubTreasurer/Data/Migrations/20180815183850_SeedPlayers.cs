using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ClubTreasurer.Data.Migrations
{
    public partial class SeedPlayers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "BankTransactionCategorys",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2018, 8, 15, 20, 38, 49, 967, DateTimeKind.Local), new DateTime(2018, 8, 15, 20, 38, 49, 967, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "BankTransactionCategorys",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2018, 8, 15, 20, 38, 49, 967, DateTimeKind.Local), new DateTime(2018, 8, 15, 20, 38, 49, 967, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "BankTransactionCategorys",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2018, 8, 15, 20, 38, 49, 967, DateTimeKind.Local), new DateTime(2018, 8, 15, 20, 38, 49, 967, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "BankTransactionCategorys",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2018, 8, 15, 20, 38, 49, 967, DateTimeKind.Local), new DateTime(2018, 8, 15, 20, 38, 49, 967, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "BankTransactionCategorys",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2018, 8, 15, 20, 38, 49, 967, DateTimeKind.Local), new DateTime(2018, 8, 15, 20, 38, 49, 967, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "BankTransactionCategorys",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2018, 8, 15, 20, 38, 49, 967, DateTimeKind.Local), new DateTime(2018, 8, 15, 20, 38, 49, 967, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "BankTransactionCategorys",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2018, 8, 15, 20, 38, 49, 967, DateTimeKind.Local), new DateTime(2018, 8, 15, 20, 38, 49, 967, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "ID", "Created", "DOB", "Discriminator", "Email", "FirstName", "LastModified", "LastModifiedById", "LastName", "Image", "PositionId" },
                values: new object[,]
                {
                    { 15, new DateTime(2018, 8, 15, 20, 38, 49, 967, DateTimeKind.Local), new DateTime(1990, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Player", null, "Sebastian", new DateTime(2018, 8, 15, 20, 38, 49, 967, DateTimeKind.Local), "cc07b6bb-3f27-4123-a6e5-41a610794478", "Müller", null, 8 },
                    { 16, new DateTime(2018, 8, 15, 20, 38, 49, 967, DateTimeKind.Local), new DateTime(1995, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Player", null, "Benjamin", new DateTime(2018, 8, 15, 20, 38, 49, 967, DateTimeKind.Local), "cc07b6bb-3f27-4123-a6e5-41a610794478", "Rabl", null, 3 },
                    { 17, new DateTime(2018, 8, 15, 20, 38, 49, 967, DateTimeKind.Local), new DateTime(1996, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Player", null, "Tom", new DateTime(2018, 8, 15, 20, 38, 49, 967, DateTimeKind.Local), "cc07b6bb-3f27-4123-a6e5-41a610794478", "Millen", null, 5 },
                    { 18, new DateTime(2018, 8, 15, 20, 38, 49, 967, DateTimeKind.Local), new DateTime(1985, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Player", null, "Mathias", new DateTime(2018, 8, 15, 20, 38, 49, 967, DateTimeKind.Local), "cc07b6bb-3f27-4123-a6e5-41a610794478", "Märk", null, 4 },
                    { 21, new DateTime(2018, 8, 15, 20, 38, 49, 967, DateTimeKind.Local), new DateTime(1991, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Player", null, "Lukas", new DateTime(2018, 8, 15, 20, 38, 49, 967, DateTimeKind.Local), "cc07b6bb-3f27-4123-a6e5-41a610794478", "Kolb", null, 7 },
                    { 20, new DateTime(2018, 8, 15, 20, 38, 49, 967, DateTimeKind.Local), new DateTime(1989, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Player", null, "Gerald", new DateTime(2018, 8, 15, 20, 38, 49, 967, DateTimeKind.Local), "cc07b6bb-3f27-4123-a6e5-41a610794478", "Lerchbaumer", null, 2 },
                    { 14, new DateTime(2018, 8, 15, 20, 38, 49, 967, DateTimeKind.Local), new DateTime(1990, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Player", null, "Nesar", new DateTime(2018, 8, 15, 20, 38, 49, 967, DateTimeKind.Local), "cc07b6bb-3f27-4123-a6e5-41a610794478", "Nazari", null, 2 },
                    { 22, new DateTime(2018, 8, 15, 20, 38, 49, 967, DateTimeKind.Local), new DateTime(1993, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Player", null, "Khvistani", new DateTime(2018, 8, 15, 20, 38, 49, 967, DateTimeKind.Local), "cc07b6bb-3f27-4123-a6e5-41a610794478", "Giorgi", null, 10 },
                    { 19, new DateTime(2018, 8, 15, 20, 38, 49, 967, DateTimeKind.Local), new DateTime(1995, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Player", null, "Isabella", new DateTime(2018, 8, 15, 20, 38, 49, 967, DateTimeKind.Local), "cc07b6bb-3f27-4123-a6e5-41a610794478", "Luke", null, 5 },
                    { 12, new DateTime(2018, 8, 15, 20, 38, 49, 967, DateTimeKind.Local), new DateTime(1991, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Player", null, "Barbara", new DateTime(2018, 8, 15, 20, 38, 49, 967, DateTimeKind.Local), "cc07b6bb-3f27-4123-a6e5-41a610794478", "Rieger", null, 10 },
                    { 13, new DateTime(2018, 8, 15, 20, 38, 49, 967, DateTimeKind.Local), new DateTime(1993, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Player", null, "Christian", new DateTime(2018, 8, 15, 20, 38, 49, 967, DateTimeKind.Local), "cc07b6bb-3f27-4123-a6e5-41a610794478", "Pöhl", null, 2 },
                    { 10, new DateTime(2018, 8, 15, 20, 38, 49, 967, DateTimeKind.Local), new DateTime(1998, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Player", null, "Davide", new DateTime(2018, 8, 15, 20, 38, 49, 967, DateTimeKind.Local), "cc07b6bb-3f27-4123-a6e5-41a610794478", "Sorvillo", null, 2 },
                    { 11, new DateTime(2018, 8, 15, 20, 38, 49, 967, DateTimeKind.Local), new DateTime(1995, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Player", null, "Florian", new DateTime(2018, 8, 15, 20, 38, 49, 967, DateTimeKind.Local), "cc07b6bb-3f27-4123-a6e5-41a610794478", "Rudiferia", null, 4 },
                    { 2, new DateTime(2018, 8, 15, 20, 38, 49, 967, DateTimeKind.Local), new DateTime(1983, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Player", null, "Jeremie", new DateTime(2018, 8, 15, 20, 38, 49, 967, DateTimeKind.Local), "cc07b6bb-3f27-4123-a6e5-41a610794478", "DeJean", null, 5 },
                    { 3, new DateTime(2018, 8, 15, 20, 38, 49, 967, DateTimeKind.Local), new DateTime(1998, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Player", null, "Julia", new DateTime(2018, 8, 15, 20, 38, 49, 967, DateTimeKind.Local), "cc07b6bb-3f27-4123-a6e5-41a610794478", "Hensler", null, 10 },
                    { 4, new DateTime(2018, 8, 15, 20, 38, 49, 967, DateTimeKind.Local), new DateTime(1991, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Player", null, "Kristin", new DateTime(2018, 8, 15, 20, 38, 49, 967, DateTimeKind.Local), "cc07b6bb-3f27-4123-a6e5-41a610794478", "Hiltpot", null, 2 },
                    { 5, new DateTime(2018, 8, 15, 20, 38, 49, 967, DateTimeKind.Local), new DateTime(1990, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Player", null, "Philip", new DateTime(2018, 8, 15, 20, 38, 49, 967, DateTimeKind.Local), "cc07b6bb-3f27-4123-a6e5-41a610794478", "Westerlund", null, 10 },
                    { 1, new DateTime(2018, 8, 15, 20, 38, 49, 967, DateTimeKind.Local), new DateTime(1989, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Player", null, "Max", new DateTime(2018, 8, 15, 20, 38, 49, 967, DateTimeKind.Local), "cc07b6bb-3f27-4123-a6e5-41a610794478", "Büttner", null, 9 },
                    { 7, new DateTime(2018, 8, 15, 20, 38, 49, 967, DateTimeKind.Local), new DateTime(1994, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Player", null, "Anna", new DateTime(2018, 8, 15, 20, 38, 49, 967, DateTimeKind.Local), "cc07b6bb-3f27-4123-a6e5-41a610794478", "Wallensteiner", null, 2 },
                    { 8, new DateTime(2018, 8, 15, 20, 38, 49, 967, DateTimeKind.Local), new DateTime(1989, 4, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Player", null, "Nils", new DateTime(2018, 8, 15, 20, 38, 49, 967, DateTimeKind.Local), "cc07b6bb-3f27-4123-a6e5-41a610794478", "Unthan", null, 2 },
                    { 9, new DateTime(2018, 8, 15, 20, 38, 49, 967, DateTimeKind.Local), new DateTime(1994, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Player", null, "Thomas", new DateTime(2018, 8, 15, 20, 38, 49, 967, DateTimeKind.Local), "cc07b6bb-3f27-4123-a6e5-41a610794478", "Tripp", null, 8 },
                    { 6, new DateTime(2018, 8, 15, 20, 38, 49, 967, DateTimeKind.Local), new DateTime(1998, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Player", null, "Hannah", new DateTime(2018, 8, 15, 20, 38, 49, 967, DateTimeKind.Local), "cc07b6bb-3f27-4123-a6e5-41a610794478", "Werkgarner", null, 2 }
                });

            migrationBuilder.UpdateData(
                table: "PlayerPositions",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2018, 8, 15, 20, 38, 49, 967, DateTimeKind.Local), new DateTime(2018, 8, 15, 20, 38, 49, 967, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PlayerPositions",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2018, 8, 15, 20, 38, 49, 967, DateTimeKind.Local), new DateTime(2018, 8, 15, 20, 38, 49, 967, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PlayerPositions",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2018, 8, 15, 20, 38, 49, 967, DateTimeKind.Local), new DateTime(2018, 8, 15, 20, 38, 49, 967, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PlayerPositions",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2018, 8, 15, 20, 38, 49, 967, DateTimeKind.Local), new DateTime(2018, 8, 15, 20, 38, 49, 967, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PlayerPositions",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2018, 8, 15, 20, 38, 49, 967, DateTimeKind.Local), new DateTime(2018, 8, 15, 20, 38, 49, 967, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PlayerPositions",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2018, 8, 15, 20, 38, 49, 967, DateTimeKind.Local), new DateTime(2018, 8, 15, 20, 38, 49, 967, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PlayerPositions",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2018, 8, 15, 20, 38, 49, 967, DateTimeKind.Local), new DateTime(2018, 8, 15, 20, 38, 49, 967, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PlayerPositions",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2018, 8, 15, 20, 38, 49, 967, DateTimeKind.Local), new DateTime(2018, 8, 15, 20, 38, 49, 967, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PlayerPositions",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2018, 8, 15, 20, 38, 49, 967, DateTimeKind.Local), new DateTime(2018, 8, 15, 20, 38, 49, 967, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PlayerPositions",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2018, 8, 15, 20, 38, 49, 967, DateTimeKind.Local), new DateTime(2018, 8, 15, 20, 38, 49, 967, DateTimeKind.Local) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.UpdateData(
                table: "BankTransactionCategorys",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2018, 8, 15, 20, 12, 56, 877, DateTimeKind.Local), new DateTime(2018, 8, 15, 20, 12, 56, 877, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "BankTransactionCategorys",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2018, 8, 15, 20, 12, 56, 877, DateTimeKind.Local), new DateTime(2018, 8, 15, 20, 12, 56, 877, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "BankTransactionCategorys",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2018, 8, 15, 20, 12, 56, 877, DateTimeKind.Local), new DateTime(2018, 8, 15, 20, 12, 56, 877, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "BankTransactionCategorys",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2018, 8, 15, 20, 12, 56, 877, DateTimeKind.Local), new DateTime(2018, 8, 15, 20, 12, 56, 877, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "BankTransactionCategorys",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2018, 8, 15, 20, 12, 56, 877, DateTimeKind.Local), new DateTime(2018, 8, 15, 20, 12, 56, 877, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "BankTransactionCategorys",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2018, 8, 15, 20, 12, 56, 877, DateTimeKind.Local), new DateTime(2018, 8, 15, 20, 12, 56, 877, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "BankTransactionCategorys",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2018, 8, 15, 20, 12, 56, 877, DateTimeKind.Local), new DateTime(2018, 8, 15, 20, 12, 56, 877, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PlayerPositions",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2018, 8, 15, 20, 12, 56, 877, DateTimeKind.Local), new DateTime(2018, 8, 15, 20, 12, 56, 877, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PlayerPositions",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2018, 8, 15, 20, 12, 56, 877, DateTimeKind.Local), new DateTime(2018, 8, 15, 20, 12, 56, 877, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PlayerPositions",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2018, 8, 15, 20, 12, 56, 877, DateTimeKind.Local), new DateTime(2018, 8, 15, 20, 12, 56, 877, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PlayerPositions",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2018, 8, 15, 20, 12, 56, 877, DateTimeKind.Local), new DateTime(2018, 8, 15, 20, 12, 56, 877, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PlayerPositions",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2018, 8, 15, 20, 12, 56, 877, DateTimeKind.Local), new DateTime(2018, 8, 15, 20, 12, 56, 877, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PlayerPositions",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2018, 8, 15, 20, 12, 56, 877, DateTimeKind.Local), new DateTime(2018, 8, 15, 20, 12, 56, 877, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PlayerPositions",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2018, 8, 15, 20, 12, 56, 877, DateTimeKind.Local), new DateTime(2018, 8, 15, 20, 12, 56, 877, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PlayerPositions",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2018, 8, 15, 20, 12, 56, 877, DateTimeKind.Local), new DateTime(2018, 8, 15, 20, 12, 56, 877, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PlayerPositions",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2018, 8, 15, 20, 12, 56, 877, DateTimeKind.Local), new DateTime(2018, 8, 15, 20, 12, 56, 877, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PlayerPositions",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2018, 8, 15, 20, 12, 56, 877, DateTimeKind.Local), new DateTime(2018, 8, 15, 20, 12, 56, 877, DateTimeKind.Local) });
        }
    }
}
