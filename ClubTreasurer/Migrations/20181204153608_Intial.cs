using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ClubTreasurer.Migrations
{
    public partial class Intial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Street = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    Province = table.Column<string>(nullable: true),
                    PostalCode = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    LastModified = table.Column<DateTime>(nullable: false),
                    LastModifiedById = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoles_AspNetUsers_LastModifiedById",
                        column: x => x.LastModifiedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    Name = table.Column<string>(maxLength: 128, nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BankTransactionCategorys",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Created = table.Column<DateTime>(nullable: false),
                    LastModified = table.Column<DateTime>(nullable: false),
                    LastModifiedById = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BankTransactionCategorys", x => x.ID);
                    table.ForeignKey(
                        name: "FK_BankTransactionCategorys_AspNetUsers_LastModifiedById",
                        column: x => x.LastModifiedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PlayerPositions",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false),
                    Created = table.Column<DateTime>(nullable: false),
                    LastModified = table.Column<DateTime>(nullable: false),
                    LastModifiedById = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlayerPositions", x => x.ID);
                    table.ForeignKey(
                        name: "FK_PlayerPositions_AspNetUsers_LastModifiedById",
                        column: x => x.LastModifiedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Persons",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    DOB = table.Column<DateTime>(nullable: false),
                    Created = table.Column<DateTime>(nullable: false),
                    LastModified = table.Column<DateTime>(nullable: false),
                    LastModifiedById = table.Column<string>(nullable: true),
                    Discriminator = table.Column<string>(nullable: false),
                    Image = table.Column<byte[]>(nullable: true),
                    PositionId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persons", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Persons_AspNetUsers_LastModifiedById",
                        column: x => x.LastModifiedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Persons_PlayerPositions_PositionId",
                        column: x => x.PositionId,
                        principalTable: "PlayerPositions",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BankAccounts",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IBAN = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    PersonId = table.Column<int>(nullable: false),
                    Created = table.Column<DateTime>(nullable: false),
                    LastModified = table.Column<DateTime>(nullable: false),
                    LastModifiedById = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BankAccounts", x => x.ID);
                    table.ForeignKey(
                        name: "FK_BankAccounts_AspNetUsers_LastModifiedById",
                        column: x => x.LastModifiedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BankAccounts_Persons_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Persons",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BankTransactions",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Amount = table.Column<decimal>(nullable: false),
                    Reference = table.Column<string>(nullable: true),
                    ReferenceNumber = table.Column<string>(nullable: true),
                    TransactionCategoryId = table.Column<int>(nullable: false),
                    AccountId = table.Column<int>(nullable: false),
                    Created = table.Column<DateTime>(nullable: false),
                    LastModified = table.Column<DateTime>(nullable: false),
                    LastModifiedById = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BankTransactions", x => x.ID);
                    table.ForeignKey(
                        name: "FK_BankTransactions_BankAccounts_AccountId",
                        column: x => x.AccountId,
                        principalTable: "BankAccounts",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BankTransactions_AspNetUsers_LastModifiedById",
                        column: x => x.LastModifiedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BankTransactions_BankTransactionCategorys_TransactionCategoryId",
                        column: x => x.TransactionCategoryId,
                        principalTable: "BankTransactionCategorys",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "City", "ConcurrencyStamp", "Country", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PostalCode", "Province", "SecurityStamp", "Street", "TwoFactorEnabled", "UserName" },
                values: new object[] { "e2a8bd78-87eb-4e39-aafd-fd9d67e3c48e", 0, null, "a7b76316-fbc8-41d4-9ff8-a5adcb9b55d1", null, "fake@fake.com", true, null, null, false, null, null, null, null, null, false, null, null, null, null, false, "seeder" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "LastModified", "LastModifiedById", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "920d780a-5b19-4628-97b4-a23e2894a4c9", "1a67a31b-16c3-4d64-8ce0-d64f4fcb0be9", "CRUD operations on finances", new DateTime(2018, 12, 4, 16, 36, 7, 193, DateTimeKind.Local), "e2a8bd78-87eb-4e39-aafd-fd9d67e3c48e", "FinaceEditor", null },
                    { "fc9555af-19a8-4e8c-a6b3-6e7e0878d5c3", "0212e5b3-a997-494b-9fb4-7bf0c73c71fd", "Read operations on finances", new DateTime(2018, 12, 4, 16, 36, 7, 193, DateTimeKind.Local), "e2a8bd78-87eb-4e39-aafd-fd9d67e3c48e", "FinanceReader", null }
                });

            migrationBuilder.InsertData(
                table: "BankTransactionCategorys",
                columns: new[] { "ID", "Created", "Description", "LastModified", "LastModifiedById", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2018, 12, 4, 16, 36, 7, 193, DateTimeKind.Local), null, new DateTime(2018, 12, 4, 16, 36, 7, 193, DateTimeKind.Local), "e2a8bd78-87eb-4e39-aafd-fd9d67e3c48e", "Coaching Fees" },
                    { 2, new DateTime(2018, 12, 4, 16, 36, 7, 193, DateTimeKind.Local), null, new DateTime(2018, 12, 4, 16, 36, 7, 193, DateTimeKind.Local), "e2a8bd78-87eb-4e39-aafd-fd9d67e3c48e", "Gym Fees" },
                    { 3, new DateTime(2018, 12, 4, 16, 36, 7, 193, DateTimeKind.Local), null, new DateTime(2018, 12, 4, 16, 36, 7, 193, DateTimeKind.Local), "e2a8bd78-87eb-4e39-aafd-fd9d67e3c48e", "Membership Fees" },
                    { 4, new DateTime(2018, 12, 4, 16, 36, 7, 193, DateTimeKind.Local), null, new DateTime(2018, 12, 4, 16, 36, 7, 193, DateTimeKind.Local), "e2a8bd78-87eb-4e39-aafd-fd9d67e3c48e", "Old Boys Supporters" },
                    { 5, new DateTime(2018, 12, 4, 16, 36, 7, 193, DateTimeKind.Local), null, new DateTime(2018, 12, 4, 16, 36, 7, 193, DateTimeKind.Local), "e2a8bd78-87eb-4e39-aafd-fd9d67e3c48e", "Sponsorship" },
                    { 6, new DateTime(2018, 12, 4, 16, 36, 7, 193, DateTimeKind.Local), null, new DateTime(2018, 12, 4, 16, 36, 7, 193, DateTimeKind.Local), "e2a8bd78-87eb-4e39-aafd-fd9d67e3c48e", "Travel Expenses" },
                    { 7, new DateTime(2018, 12, 4, 16, 36, 7, 193, DateTimeKind.Local), null, new DateTime(2018, 12, 4, 16, 36, 7, 193, DateTimeKind.Local), "e2a8bd78-87eb-4e39-aafd-fd9d67e3c48e", "Coaches Wages" }
                });

            migrationBuilder.InsertData(
                table: "PlayerPositions",
                columns: new[] { "ID", "Created", "LastModified", "LastModifiedById", "Name" },
                values: new object[,]
                {
                    { 8, new DateTime(2018, 12, 4, 16, 36, 7, 193, DateTimeKind.Local), new DateTime(2018, 12, 4, 16, 36, 7, 193, DateTimeKind.Local), "e2a8bd78-87eb-4e39-aafd-fd9d67e3c48e", "Second Row" },
                    { 7, new DateTime(2018, 12, 4, 16, 36, 7, 193, DateTimeKind.Local), new DateTime(2018, 12, 4, 16, 36, 7, 193, DateTimeKind.Local), "e2a8bd78-87eb-4e39-aafd-fd9d67e3c48e", "Flanker" },
                    { 6, new DateTime(2018, 12, 4, 16, 36, 7, 193, DateTimeKind.Local), new DateTime(2018, 12, 4, 16, 36, 7, 193, DateTimeKind.Local), "e2a8bd78-87eb-4e39-aafd-fd9d67e3c48e", "Number 8" },
                    { 5, new DateTime(2018, 12, 4, 16, 36, 7, 193, DateTimeKind.Local), new DateTime(2018, 12, 4, 16, 36, 7, 193, DateTimeKind.Local), "e2a8bd78-87eb-4e39-aafd-fd9d67e3c48e", "Scrum Half" },
                    { 1, new DateTime(2018, 12, 4, 16, 36, 7, 193, DateTimeKind.Local), new DateTime(2018, 12, 4, 16, 36, 7, 193, DateTimeKind.Local), "e2a8bd78-87eb-4e39-aafd-fd9d67e3c48e", "Full Back" },
                    { 3, new DateTime(2018, 12, 4, 16, 36, 7, 193, DateTimeKind.Local), new DateTime(2018, 12, 4, 16, 36, 7, 193, DateTimeKind.Local), "e2a8bd78-87eb-4e39-aafd-fd9d67e3c48e", "Center" },
                    { 2, new DateTime(2018, 12, 4, 16, 36, 7, 193, DateTimeKind.Local), new DateTime(2018, 12, 4, 16, 36, 7, 193, DateTimeKind.Local), "e2a8bd78-87eb-4e39-aafd-fd9d67e3c48e", "Winger" },
                    { 9, new DateTime(2018, 12, 4, 16, 36, 7, 193, DateTimeKind.Local), new DateTime(2018, 12, 4, 16, 36, 7, 193, DateTimeKind.Local), "e2a8bd78-87eb-4e39-aafd-fd9d67e3c48e", "Hooker" },
                    { 4, new DateTime(2018, 12, 4, 16, 36, 7, 193, DateTimeKind.Local), new DateTime(2018, 12, 4, 16, 36, 7, 193, DateTimeKind.Local), "e2a8bd78-87eb-4e39-aafd-fd9d67e3c48e", "Out Half" },
                    { 10, new DateTime(2018, 12, 4, 16, 36, 7, 193, DateTimeKind.Local), new DateTime(2018, 12, 4, 16, 36, 7, 193, DateTimeKind.Local), "e2a8bd78-87eb-4e39-aafd-fd9d67e3c48e", "Prop" }
                });

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "ID", "Created", "DOB", "Discriminator", "Email", "FirstName", "LastModified", "LastModifiedById", "LastName", "Image", "PositionId" },
                values: new object[,]
                {
                    { 4, new DateTime(2018, 12, 4, 16, 36, 7, 193, DateTimeKind.Local), new DateTime(1991, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Player", null, "Kristin", new DateTime(2018, 12, 4, 16, 36, 7, 193, DateTimeKind.Local), "e2a8bd78-87eb-4e39-aafd-fd9d67e3c48e", "Hiltpot", null, 2 },
                    { 5, new DateTime(2018, 12, 4, 16, 36, 7, 193, DateTimeKind.Local), new DateTime(1990, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Player", null, "Philip", new DateTime(2018, 12, 4, 16, 36, 7, 193, DateTimeKind.Local), "e2a8bd78-87eb-4e39-aafd-fd9d67e3c48e", "Westerlund", null, 10 },
                    { 3, new DateTime(2018, 12, 4, 16, 36, 7, 193, DateTimeKind.Local), new DateTime(1998, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Player", null, "Julia", new DateTime(2018, 12, 4, 16, 36, 7, 193, DateTimeKind.Local), "e2a8bd78-87eb-4e39-aafd-fd9d67e3c48e", "Hensler", null, 10 },
                    { 1, new DateTime(2018, 12, 4, 16, 36, 7, 193, DateTimeKind.Local), new DateTime(1989, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Player", null, "Max", new DateTime(2018, 12, 4, 16, 36, 7, 193, DateTimeKind.Local), "e2a8bd78-87eb-4e39-aafd-fd9d67e3c48e", "Büttner", null, 9 },
                    { 15, new DateTime(2018, 12, 4, 16, 36, 7, 193, DateTimeKind.Local), new DateTime(1990, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Player", null, "Sebastian", new DateTime(2018, 12, 4, 16, 36, 7, 193, DateTimeKind.Local), "e2a8bd78-87eb-4e39-aafd-fd9d67e3c48e", "Müller", null, 8 },
                    { 9, new DateTime(2018, 12, 4, 16, 36, 7, 193, DateTimeKind.Local), new DateTime(1994, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Player", null, "Thomas", new DateTime(2018, 12, 4, 16, 36, 7, 193, DateTimeKind.Local), "e2a8bd78-87eb-4e39-aafd-fd9d67e3c48e", "Tripp", null, 8 },
                    { 21, new DateTime(2018, 12, 4, 16, 36, 7, 193, DateTimeKind.Local), new DateTime(1991, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Player", null, "Lukas", new DateTime(2018, 12, 4, 16, 36, 7, 193, DateTimeKind.Local), "e2a8bd78-87eb-4e39-aafd-fd9d67e3c48e", "Kolb", null, 7 },
                    { 19, new DateTime(2018, 12, 4, 16, 36, 7, 193, DateTimeKind.Local), new DateTime(1995, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Player", null, "Isabella", new DateTime(2018, 12, 4, 16, 36, 7, 193, DateTimeKind.Local), "e2a8bd78-87eb-4e39-aafd-fd9d67e3c48e", "Luke", null, 5 },
                    { 17, new DateTime(2018, 12, 4, 16, 36, 7, 193, DateTimeKind.Local), new DateTime(1996, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Player", null, "Tom", new DateTime(2018, 12, 4, 16, 36, 7, 193, DateTimeKind.Local), "e2a8bd78-87eb-4e39-aafd-fd9d67e3c48e", "Millen", null, 5 },
                    { 2, new DateTime(2018, 12, 4, 16, 36, 7, 193, DateTimeKind.Local), new DateTime(1983, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Player", null, "Jeremie", new DateTime(2018, 12, 4, 16, 36, 7, 193, DateTimeKind.Local), "e2a8bd78-87eb-4e39-aafd-fd9d67e3c48e", "DeJean", null, 5 },
                    { 18, new DateTime(2018, 12, 4, 16, 36, 7, 193, DateTimeKind.Local), new DateTime(1985, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Player", null, "Mathias", new DateTime(2018, 12, 4, 16, 36, 7, 193, DateTimeKind.Local), "e2a8bd78-87eb-4e39-aafd-fd9d67e3c48e", "Märk", null, 4 },
                    { 11, new DateTime(2018, 12, 4, 16, 36, 7, 193, DateTimeKind.Local), new DateTime(1995, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Player", null, "Florian", new DateTime(2018, 12, 4, 16, 36, 7, 193, DateTimeKind.Local), "e2a8bd78-87eb-4e39-aafd-fd9d67e3c48e", "Rudiferia", null, 4 },
                    { 16, new DateTime(2018, 12, 4, 16, 36, 7, 193, DateTimeKind.Local), new DateTime(1995, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Player", null, "Benjamin", new DateTime(2018, 12, 4, 16, 36, 7, 193, DateTimeKind.Local), "e2a8bd78-87eb-4e39-aafd-fd9d67e3c48e", "Rabl", null, 3 },
                    { 20, new DateTime(2018, 12, 4, 16, 36, 7, 193, DateTimeKind.Local), new DateTime(1989, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Player", null, "Gerald", new DateTime(2018, 12, 4, 16, 36, 7, 193, DateTimeKind.Local), "e2a8bd78-87eb-4e39-aafd-fd9d67e3c48e", "Lerchbaumer", null, 2 },
                    { 14, new DateTime(2018, 12, 4, 16, 36, 7, 193, DateTimeKind.Local), new DateTime(1990, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Player", null, "Nesar", new DateTime(2018, 12, 4, 16, 36, 7, 193, DateTimeKind.Local), "e2a8bd78-87eb-4e39-aafd-fd9d67e3c48e", "Nazari", null, 2 },
                    { 13, new DateTime(2018, 12, 4, 16, 36, 7, 193, DateTimeKind.Local), new DateTime(1993, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Player", null, "Christian", new DateTime(2018, 12, 4, 16, 36, 7, 193, DateTimeKind.Local), "e2a8bd78-87eb-4e39-aafd-fd9d67e3c48e", "Pöhl", null, 2 },
                    { 10, new DateTime(2018, 12, 4, 16, 36, 7, 193, DateTimeKind.Local), new DateTime(1998, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Player", null, "Davide", new DateTime(2018, 12, 4, 16, 36, 7, 193, DateTimeKind.Local), "e2a8bd78-87eb-4e39-aafd-fd9d67e3c48e", "Sorvillo", null, 2 },
                    { 8, new DateTime(2018, 12, 4, 16, 36, 7, 193, DateTimeKind.Local), new DateTime(1989, 4, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Player", null, "Nils", new DateTime(2018, 12, 4, 16, 36, 7, 193, DateTimeKind.Local), "e2a8bd78-87eb-4e39-aafd-fd9d67e3c48e", "Unthan", null, 2 },
                    { 7, new DateTime(2018, 12, 4, 16, 36, 7, 193, DateTimeKind.Local), new DateTime(1994, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Player", null, "Anna", new DateTime(2018, 12, 4, 16, 36, 7, 193, DateTimeKind.Local), "e2a8bd78-87eb-4e39-aafd-fd9d67e3c48e", "Wallensteiner", null, 2 },
                    { 6, new DateTime(2018, 12, 4, 16, 36, 7, 193, DateTimeKind.Local), new DateTime(1998, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Player", null, "Hannah", new DateTime(2018, 12, 4, 16, 36, 7, 193, DateTimeKind.Local), "e2a8bd78-87eb-4e39-aafd-fd9d67e3c48e", "Werkgarner", null, 2 },
                    { 12, new DateTime(2018, 12, 4, 16, 36, 7, 193, DateTimeKind.Local), new DateTime(1991, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Player", null, "Barbara", new DateTime(2018, 12, 4, 16, 36, 7, 193, DateTimeKind.Local), "e2a8bd78-87eb-4e39-aafd-fd9d67e3c48e", "Rieger", null, 10 },
                    { 22, new DateTime(2018, 12, 4, 16, 36, 7, 193, DateTimeKind.Local), new DateTime(1993, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Player", null, "Khvistani", new DateTime(2018, 12, 4, 16, 36, 7, 193, DateTimeKind.Local), "e2a8bd78-87eb-4e39-aafd-fd9d67e3c48e", "Giorgi", null, 10 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoles_LastModifiedById",
                table: "AspNetRoles",
                column: "LastModifiedById");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_BankAccounts_IBAN",
                table: "BankAccounts",
                column: "IBAN",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_BankAccounts_LastModifiedById",
                table: "BankAccounts",
                column: "LastModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_BankAccounts_PersonId",
                table: "BankAccounts",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_BankTransactionCategorys_LastModifiedById",
                table: "BankTransactionCategorys",
                column: "LastModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_BankTransactions_AccountId",
                table: "BankTransactions",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_BankTransactions_LastModifiedById",
                table: "BankTransactions",
                column: "LastModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_BankTransactions_TransactionCategoryId",
                table: "BankTransactions",
                column: "TransactionCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Persons_LastModifiedById",
                table: "Persons",
                column: "LastModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_Persons_PositionId",
                table: "Persons",
                column: "PositionId");

            migrationBuilder.CreateIndex(
                name: "IX_PlayerPositions_LastModifiedById",
                table: "PlayerPositions",
                column: "LastModifiedById");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "BankTransactions");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "BankAccounts");

            migrationBuilder.DropTable(
                name: "BankTransactionCategorys");

            migrationBuilder.DropTable(
                name: "Persons");

            migrationBuilder.DropTable(
                name: "PlayerPositions");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
