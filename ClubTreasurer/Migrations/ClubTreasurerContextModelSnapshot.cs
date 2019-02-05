﻿// <auto-generated />
using System;
using ClubTreasurer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ClubTreasurer.Migrations
{
    [DbContext(typeof(ClubTreasurerContext))]
    partial class ClubTreasurerContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ClubTreasurer.Models.AppRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Description");

                    b.Property<DateTime>("LastModified");

                    b.Property<string>("LastModifiedById");

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("LastModifiedById");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");

                    b.HasData(
                        new { Id = "589ef4c9-d67a-4355-b56b-cfd5b098f1f1", ConcurrencyStamp = "a60ec7b2-54dd-4292-ae12-2881ecc8486b", Description = "CRUD operations on finances", LastModified = new DateTime(2019, 2, 5, 11, 7, 56, 652, DateTimeKind.Local), LastModifiedById = "e2a8bd78-87eb-4e39-aafd-fd9d67e3c48e", Name = "FinaceEditor" },
                        new { Id = "44ef7f76-eabd-497b-8535-05569afff7af", ConcurrencyStamp = "8c6af3aa-d838-4ba9-a94f-6f2360df1b45", Description = "Read operations on finances", LastModified = new DateTime(2019, 2, 5, 11, 7, 56, 652, DateTimeKind.Local), LastModifiedById = "e2a8bd78-87eb-4e39-aafd-fd9d67e3c48e", Name = "FinanceReader" }
                    );
                });

            modelBuilder.Entity("ClubTreasurer.Models.AppUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("City");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Country");

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("PostalCode");

                    b.Property<string>("Province");

                    b.Property<string>("SecurityStamp");

                    b.Property<string>("Street");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");

                    b.HasData(
                        new { Id = "e2a8bd78-87eb-4e39-aafd-fd9d67e3c48e", AccessFailedCount = 0, ConcurrencyStamp = "06efcae3-8e87-4b9d-a64b-6def6475e538", Email = "fake@fake.com", EmailConfirmed = true, LockoutEnabled = false, PhoneNumberConfirmed = false, TwoFactorEnabled = false, UserName = "seeder" }
                    );
                });

            modelBuilder.Entity("ClubTreasurer.Models.BankAccount", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Created");

                    b.Property<string>("IBAN")
                        .IsRequired();

                    b.Property<DateTime>("LastModified");

                    b.Property<string>("LastModifiedById");

                    b.Property<string>("Name");

                    b.Property<int?>("PersonId");

                    b.HasKey("ID");

                    b.HasIndex("IBAN")
                        .IsUnique();

                    b.HasIndex("LastModifiedById");

                    b.HasIndex("PersonId");

                    b.ToTable("BankAccounts");
                });

            modelBuilder.Entity("ClubTreasurer.Models.BankTransaction", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AccountId");

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("BookingDate");

                    b.Property<DateTime>("Created");

                    b.Property<DateTime>("LastModified");

                    b.Property<string>("LastModifiedById");

                    b.Property<string>("Reference");

                    b.Property<string>("ReferenceNumber");

                    b.Property<int>("TransactionCategoryId");

                    b.HasKey("ID");

                    b.HasIndex("AccountId");

                    b.HasIndex("LastModifiedById");

                    b.HasIndex("TransactionCategoryId");

                    b.ToTable("BankTransactions");
                });

            modelBuilder.Entity("ClubTreasurer.Models.BankTransactionCategory", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Created");

                    b.Property<string>("Description");

                    b.Property<string>("KeyWords");

                    b.Property<DateTime>("LastModified");

                    b.Property<string>("LastModifiedById");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("ID");

                    b.HasIndex("LastModifiedById");

                    b.ToTable("BankTransactionCategorys");

                    b.HasData(
                        new { ID = 1, Created = new DateTime(2019, 2, 5, 11, 7, 56, 652, DateTimeKind.Local), KeyWords = "coaching", LastModified = new DateTime(2019, 2, 5, 11, 7, 56, 652, DateTimeKind.Local), LastModifiedById = "e2a8bd78-87eb-4e39-aafd-fd9d67e3c48e", Name = "Coaching Fees" },
                        new { ID = 2, Created = new DateTime(2019, 2, 5, 11, 7, 56, 652, DateTimeKind.Local), KeyWords = "gym,fitness", LastModified = new DateTime(2019, 2, 5, 11, 7, 56, 652, DateTimeKind.Local), LastModifiedById = "e2a8bd78-87eb-4e39-aafd-fd9d67e3c48e", Name = "Gym Fees" },
                        new { ID = 3, Created = new DateTime(2019, 2, 5, 11, 7, 56, 652, DateTimeKind.Local), KeyWords = "mitglied,membership", LastModified = new DateTime(2019, 2, 5, 11, 7, 56, 652, DateTimeKind.Local), LastModifiedById = "e2a8bd78-87eb-4e39-aafd-fd9d67e3c48e", Name = "Membership Fees" },
                        new { ID = 4, Created = new DateTime(2019, 2, 5, 11, 7, 56, 652, DateTimeKind.Local), KeyWords = "old boys,oldboys", LastModified = new DateTime(2019, 2, 5, 11, 7, 56, 652, DateTimeKind.Local), LastModifiedById = "e2a8bd78-87eb-4e39-aafd-fd9d67e3c48e", Name = "Old Boys Supporters" },
                        new { ID = 5, Created = new DateTime(2019, 2, 5, 11, 7, 56, 652, DateTimeKind.Local), KeyWords = "sponsor", LastModified = new DateTime(2019, 2, 5, 11, 7, 56, 652, DateTimeKind.Local), LastModifiedById = "e2a8bd78-87eb-4e39-aafd-fd9d67e3c48e", Name = "Sponsorship" },
                        new { ID = 6, Created = new DateTime(2019, 2, 5, 11, 7, 56, 652, DateTimeKind.Local), KeyWords = "travel,fuel,train,zug", LastModified = new DateTime(2019, 2, 5, 11, 7, 56, 652, DateTimeKind.Local), LastModifiedById = "e2a8bd78-87eb-4e39-aafd-fd9d67e3c48e", Name = "Travel Expenses" },
                        new { ID = 7, Created = new DateTime(2019, 2, 5, 11, 7, 56, 652, DateTimeKind.Local), LastModified = new DateTime(2019, 2, 5, 11, 7, 56, 652, DateTimeKind.Local), LastModifiedById = "e2a8bd78-87eb-4e39-aafd-fd9d67e3c48e", Name = "Coaches Wages" }
                    );
                });

            modelBuilder.Entity("ClubTreasurer.Models.Person", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Created");

                    b.Property<DateTime>("DOB");

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<string>("Email");

                    b.Property<string>("FirstName");

                    b.Property<DateTime>("LastModified");

                    b.Property<string>("LastModifiedById");

                    b.Property<string>("LastName");

                    b.Property<string>("Title");

                    b.HasKey("ID");

                    b.HasIndex("LastModifiedById");

                    b.ToTable("Persons");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Person");
                });

            modelBuilder.Entity("ClubTreasurer.Models.PlayerPosition", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Created");

                    b.Property<DateTime>("LastModified");

                    b.Property<string>("LastModifiedById");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("ID");

                    b.HasIndex("LastModifiedById");

                    b.ToTable("PlayerPositions");

                    b.HasData(
                        new { ID = 1, Created = new DateTime(2019, 2, 5, 11, 7, 56, 652, DateTimeKind.Local), LastModified = new DateTime(2019, 2, 5, 11, 7, 56, 652, DateTimeKind.Local), LastModifiedById = "e2a8bd78-87eb-4e39-aafd-fd9d67e3c48e", Name = "Full Back" },
                        new { ID = 2, Created = new DateTime(2019, 2, 5, 11, 7, 56, 652, DateTimeKind.Local), LastModified = new DateTime(2019, 2, 5, 11, 7, 56, 652, DateTimeKind.Local), LastModifiedById = "e2a8bd78-87eb-4e39-aafd-fd9d67e3c48e", Name = "Winger" },
                        new { ID = 3, Created = new DateTime(2019, 2, 5, 11, 7, 56, 652, DateTimeKind.Local), LastModified = new DateTime(2019, 2, 5, 11, 7, 56, 652, DateTimeKind.Local), LastModifiedById = "e2a8bd78-87eb-4e39-aafd-fd9d67e3c48e", Name = "Center" },
                        new { ID = 4, Created = new DateTime(2019, 2, 5, 11, 7, 56, 652, DateTimeKind.Local), LastModified = new DateTime(2019, 2, 5, 11, 7, 56, 652, DateTimeKind.Local), LastModifiedById = "e2a8bd78-87eb-4e39-aafd-fd9d67e3c48e", Name = "Out Half" },
                        new { ID = 5, Created = new DateTime(2019, 2, 5, 11, 7, 56, 652, DateTimeKind.Local), LastModified = new DateTime(2019, 2, 5, 11, 7, 56, 652, DateTimeKind.Local), LastModifiedById = "e2a8bd78-87eb-4e39-aafd-fd9d67e3c48e", Name = "Scrum Half" },
                        new { ID = 6, Created = new DateTime(2019, 2, 5, 11, 7, 56, 652, DateTimeKind.Local), LastModified = new DateTime(2019, 2, 5, 11, 7, 56, 652, DateTimeKind.Local), LastModifiedById = "e2a8bd78-87eb-4e39-aafd-fd9d67e3c48e", Name = "Number 8" },
                        new { ID = 7, Created = new DateTime(2019, 2, 5, 11, 7, 56, 652, DateTimeKind.Local), LastModified = new DateTime(2019, 2, 5, 11, 7, 56, 652, DateTimeKind.Local), LastModifiedById = "e2a8bd78-87eb-4e39-aafd-fd9d67e3c48e", Name = "Flanker" },
                        new { ID = 8, Created = new DateTime(2019, 2, 5, 11, 7, 56, 652, DateTimeKind.Local), LastModified = new DateTime(2019, 2, 5, 11, 7, 56, 652, DateTimeKind.Local), LastModifiedById = "e2a8bd78-87eb-4e39-aafd-fd9d67e3c48e", Name = "Second Row" },
                        new { ID = 9, Created = new DateTime(2019, 2, 5, 11, 7, 56, 652, DateTimeKind.Local), LastModified = new DateTime(2019, 2, 5, 11, 7, 56, 652, DateTimeKind.Local), LastModifiedById = "e2a8bd78-87eb-4e39-aafd-fd9d67e3c48e", Name = "Hooker" },
                        new { ID = 10, Created = new DateTime(2019, 2, 5, 11, 7, 56, 652, DateTimeKind.Local), LastModified = new DateTime(2019, 2, 5, 11, 7, 56, 652, DateTimeKind.Local), LastModifiedById = "e2a8bd78-87eb-4e39-aafd-fd9d67e3c48e", Name = "Prop" }
                    );
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasMaxLength(128);

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("ClubTreasurer.Models.Player", b =>
                {
                    b.HasBaseType("ClubTreasurer.Models.Person");

                    b.Property<byte[]>("Image");

                    b.Property<int>("PositionId");

                    b.HasIndex("PositionId");

                    b.ToTable("Player");

                    b.HasDiscriminator().HasValue("Player");

                    b.HasData(
                        new { ID = 1, Created = new DateTime(2019, 2, 5, 11, 7, 56, 652, DateTimeKind.Local), DOB = new DateTime(1989, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), FirstName = "Max", LastModified = new DateTime(2019, 2, 5, 11, 7, 56, 652, DateTimeKind.Local), LastModifiedById = "e2a8bd78-87eb-4e39-aafd-fd9d67e3c48e", LastName = "Büttner", PositionId = 9 },
                        new { ID = 2, Created = new DateTime(2019, 2, 5, 11, 7, 56, 652, DateTimeKind.Local), DOB = new DateTime(1983, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), FirstName = "Jeremie", LastModified = new DateTime(2019, 2, 5, 11, 7, 56, 652, DateTimeKind.Local), LastModifiedById = "e2a8bd78-87eb-4e39-aafd-fd9d67e3c48e", LastName = "DeJean", PositionId = 5 },
                        new { ID = 3, Created = new DateTime(2019, 2, 5, 11, 7, 56, 652, DateTimeKind.Local), DOB = new DateTime(1998, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), FirstName = "Julia", LastModified = new DateTime(2019, 2, 5, 11, 7, 56, 652, DateTimeKind.Local), LastModifiedById = "e2a8bd78-87eb-4e39-aafd-fd9d67e3c48e", LastName = "Hensler", PositionId = 10 },
                        new { ID = 4, Created = new DateTime(2019, 2, 5, 11, 7, 56, 652, DateTimeKind.Local), DOB = new DateTime(1991, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), FirstName = "Kristin", LastModified = new DateTime(2019, 2, 5, 11, 7, 56, 652, DateTimeKind.Local), LastModifiedById = "e2a8bd78-87eb-4e39-aafd-fd9d67e3c48e", LastName = "Hiltpot", PositionId = 2 },
                        new { ID = 5, Created = new DateTime(2019, 2, 5, 11, 7, 56, 652, DateTimeKind.Local), DOB = new DateTime(1990, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), FirstName = "Philip", LastModified = new DateTime(2019, 2, 5, 11, 7, 56, 652, DateTimeKind.Local), LastModifiedById = "e2a8bd78-87eb-4e39-aafd-fd9d67e3c48e", LastName = "Westerlund", PositionId = 10 },
                        new { ID = 6, Created = new DateTime(2019, 2, 5, 11, 7, 56, 652, DateTimeKind.Local), DOB = new DateTime(1998, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), FirstName = "Hannah", LastModified = new DateTime(2019, 2, 5, 11, 7, 56, 652, DateTimeKind.Local), LastModifiedById = "e2a8bd78-87eb-4e39-aafd-fd9d67e3c48e", LastName = "Werkgarner", PositionId = 2 },
                        new { ID = 7, Created = new DateTime(2019, 2, 5, 11, 7, 56, 652, DateTimeKind.Local), DOB = new DateTime(1994, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), FirstName = "Anna", LastModified = new DateTime(2019, 2, 5, 11, 7, 56, 652, DateTimeKind.Local), LastModifiedById = "e2a8bd78-87eb-4e39-aafd-fd9d67e3c48e", LastName = "Wallensteiner", PositionId = 2 },
                        new { ID = 8, Created = new DateTime(2019, 2, 5, 11, 7, 56, 652, DateTimeKind.Local), DOB = new DateTime(1989, 4, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), FirstName = "Nils", LastModified = new DateTime(2019, 2, 5, 11, 7, 56, 652, DateTimeKind.Local), LastModifiedById = "e2a8bd78-87eb-4e39-aafd-fd9d67e3c48e", LastName = "Unthan", PositionId = 2 },
                        new { ID = 9, Created = new DateTime(2019, 2, 5, 11, 7, 56, 652, DateTimeKind.Local), DOB = new DateTime(1994, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), FirstName = "Thomas", LastModified = new DateTime(2019, 2, 5, 11, 7, 56, 652, DateTimeKind.Local), LastModifiedById = "e2a8bd78-87eb-4e39-aafd-fd9d67e3c48e", LastName = "Tripp", PositionId = 8 },
                        new { ID = 10, Created = new DateTime(2019, 2, 5, 11, 7, 56, 652, DateTimeKind.Local), DOB = new DateTime(1998, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), FirstName = "Davide", LastModified = new DateTime(2019, 2, 5, 11, 7, 56, 652, DateTimeKind.Local), LastModifiedById = "e2a8bd78-87eb-4e39-aafd-fd9d67e3c48e", LastName = "Sorvillo", PositionId = 2 },
                        new { ID = 11, Created = new DateTime(2019, 2, 5, 11, 7, 56, 652, DateTimeKind.Local), DOB = new DateTime(1995, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), FirstName = "Florian", LastModified = new DateTime(2019, 2, 5, 11, 7, 56, 652, DateTimeKind.Local), LastModifiedById = "e2a8bd78-87eb-4e39-aafd-fd9d67e3c48e", LastName = "Rudiferia", PositionId = 4 },
                        new { ID = 12, Created = new DateTime(2019, 2, 5, 11, 7, 56, 652, DateTimeKind.Local), DOB = new DateTime(1991, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), FirstName = "Barbara", LastModified = new DateTime(2019, 2, 5, 11, 7, 56, 652, DateTimeKind.Local), LastModifiedById = "e2a8bd78-87eb-4e39-aafd-fd9d67e3c48e", LastName = "Rieger", PositionId = 10 },
                        new { ID = 13, Created = new DateTime(2019, 2, 5, 11, 7, 56, 652, DateTimeKind.Local), DOB = new DateTime(1993, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), FirstName = "Christian", LastModified = new DateTime(2019, 2, 5, 11, 7, 56, 652, DateTimeKind.Local), LastModifiedById = "e2a8bd78-87eb-4e39-aafd-fd9d67e3c48e", LastName = "Pöhl", PositionId = 2 },
                        new { ID = 14, Created = new DateTime(2019, 2, 5, 11, 7, 56, 652, DateTimeKind.Local), DOB = new DateTime(1990, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), FirstName = "Nesar", LastModified = new DateTime(2019, 2, 5, 11, 7, 56, 652, DateTimeKind.Local), LastModifiedById = "e2a8bd78-87eb-4e39-aafd-fd9d67e3c48e", LastName = "Nazari", PositionId = 2 },
                        new { ID = 15, Created = new DateTime(2019, 2, 5, 11, 7, 56, 652, DateTimeKind.Local), DOB = new DateTime(1990, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), FirstName = "Sebastian", LastModified = new DateTime(2019, 2, 5, 11, 7, 56, 652, DateTimeKind.Local), LastModifiedById = "e2a8bd78-87eb-4e39-aafd-fd9d67e3c48e", LastName = "Müller", PositionId = 8 },
                        new { ID = 16, Created = new DateTime(2019, 2, 5, 11, 7, 56, 652, DateTimeKind.Local), DOB = new DateTime(1995, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), FirstName = "Benjamin", LastModified = new DateTime(2019, 2, 5, 11, 7, 56, 652, DateTimeKind.Local), LastModifiedById = "e2a8bd78-87eb-4e39-aafd-fd9d67e3c48e", LastName = "Rabl", PositionId = 3 },
                        new { ID = 17, Created = new DateTime(2019, 2, 5, 11, 7, 56, 652, DateTimeKind.Local), DOB = new DateTime(1996, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), FirstName = "Tom", LastModified = new DateTime(2019, 2, 5, 11, 7, 56, 652, DateTimeKind.Local), LastModifiedById = "e2a8bd78-87eb-4e39-aafd-fd9d67e3c48e", LastName = "Millen", PositionId = 5 },
                        new { ID = 18, Created = new DateTime(2019, 2, 5, 11, 7, 56, 652, DateTimeKind.Local), DOB = new DateTime(1985, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), FirstName = "Mathias", LastModified = new DateTime(2019, 2, 5, 11, 7, 56, 652, DateTimeKind.Local), LastModifiedById = "e2a8bd78-87eb-4e39-aafd-fd9d67e3c48e", LastName = "Märk", PositionId = 4 },
                        new { ID = 19, Created = new DateTime(2019, 2, 5, 11, 7, 56, 652, DateTimeKind.Local), DOB = new DateTime(1995, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), FirstName = "Isabella", LastModified = new DateTime(2019, 2, 5, 11, 7, 56, 652, DateTimeKind.Local), LastModifiedById = "e2a8bd78-87eb-4e39-aafd-fd9d67e3c48e", LastName = "Luke", PositionId = 5 },
                        new { ID = 20, Created = new DateTime(2019, 2, 5, 11, 7, 56, 652, DateTimeKind.Local), DOB = new DateTime(1989, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), FirstName = "Gerald", LastModified = new DateTime(2019, 2, 5, 11, 7, 56, 652, DateTimeKind.Local), LastModifiedById = "e2a8bd78-87eb-4e39-aafd-fd9d67e3c48e", LastName = "Lerchbaumer", PositionId = 2 },
                        new { ID = 21, Created = new DateTime(2019, 2, 5, 11, 7, 56, 652, DateTimeKind.Local), DOB = new DateTime(1991, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), FirstName = "Lukas", LastModified = new DateTime(2019, 2, 5, 11, 7, 56, 652, DateTimeKind.Local), LastModifiedById = "e2a8bd78-87eb-4e39-aafd-fd9d67e3c48e", LastName = "Kolb", PositionId = 7 },
                        new { ID = 22, Created = new DateTime(2019, 2, 5, 11, 7, 56, 652, DateTimeKind.Local), DOB = new DateTime(1993, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), FirstName = "Khvistani", LastModified = new DateTime(2019, 2, 5, 11, 7, 56, 652, DateTimeKind.Local), LastModifiedById = "e2a8bd78-87eb-4e39-aafd-fd9d67e3c48e", LastName = "Giorgi", PositionId = 10 }
                    );
                });

            modelBuilder.Entity("ClubTreasurer.Models.AppRole", b =>
                {
                    b.HasOne("ClubTreasurer.Models.AppUser", "LastModifiedBy")
                        .WithMany()
                        .HasForeignKey("LastModifiedById");
                });

            modelBuilder.Entity("ClubTreasurer.Models.BankAccount", b =>
                {
                    b.HasOne("ClubTreasurer.Models.AppUser", "LastModifiedBy")
                        .WithMany()
                        .HasForeignKey("LastModifiedById");

                    b.HasOne("ClubTreasurer.Models.Person", "Person")
                        .WithMany("BankAccounts")
                        .HasForeignKey("PersonId");
                });

            modelBuilder.Entity("ClubTreasurer.Models.BankTransaction", b =>
                {
                    b.HasOne("ClubTreasurer.Models.BankAccount", "Account")
                        .WithMany("Transactions")
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ClubTreasurer.Models.AppUser", "LastModifiedBy")
                        .WithMany()
                        .HasForeignKey("LastModifiedById");

                    b.HasOne("ClubTreasurer.Models.BankTransactionCategory", "TransactionCategory")
                        .WithMany("Transactions")
                        .HasForeignKey("TransactionCategoryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ClubTreasurer.Models.BankTransactionCategory", b =>
                {
                    b.HasOne("ClubTreasurer.Models.AppUser", "LastModifiedBy")
                        .WithMany()
                        .HasForeignKey("LastModifiedById");
                });

            modelBuilder.Entity("ClubTreasurer.Models.Person", b =>
                {
                    b.HasOne("ClubTreasurer.Models.AppUser", "LastModifiedBy")
                        .WithMany()
                        .HasForeignKey("LastModifiedById");
                });

            modelBuilder.Entity("ClubTreasurer.Models.PlayerPosition", b =>
                {
                    b.HasOne("ClubTreasurer.Models.AppUser", "LastModifiedBy")
                        .WithMany()
                        .HasForeignKey("LastModifiedById");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("ClubTreasurer.Models.AppRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("ClubTreasurer.Models.AppUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("ClubTreasurer.Models.AppUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("ClubTreasurer.Models.AppRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ClubTreasurer.Models.AppUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("ClubTreasurer.Models.AppUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ClubTreasurer.Models.Player", b =>
                {
                    b.HasOne("ClubTreasurer.Models.PlayerPosition", "Position")
                        .WithMany("Players")
                        .HasForeignKey("PositionId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
