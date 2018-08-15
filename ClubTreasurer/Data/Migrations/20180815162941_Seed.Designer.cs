﻿// <auto-generated />
using System;
using ClubTreasurer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ClubTreasurer.Data.Migrations
{
    [DbContext(typeof(ClubTreasurerContext))]
    [Migration("20180815162941_Seed")]
    partial class Seed
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

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

                    b.Property<int>("PersonId");

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

                    b.Property<decimal>("Amount");

                    b.Property<DateTime>("Created");

                    b.Property<DateTime>("LastModified");

                    b.Property<string>("LastModifiedById");

                    b.Property<string>("Reference");

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

                    b.Property<DateTime>("LastModified");

                    b.Property<string>("LastModifiedById");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("ID");

                    b.HasIndex("LastModifiedById");

                    b.ToTable("BankTransactionCategorys");

                    b.HasData(
                        new { ID = 1, Created = new DateTime(2018, 8, 15, 18, 29, 41, 364, DateTimeKind.Local), LastModified = new DateTime(2018, 8, 15, 18, 29, 41, 364, DateTimeKind.Local), LastModifiedById = "c98c8716-76a3-4c21-a155-e696959ec715", Name = "Coaching Fees" },
                        new { ID = 2, Created = new DateTime(2018, 8, 15, 18, 29, 41, 364, DateTimeKind.Local), LastModified = new DateTime(2018, 8, 15, 18, 29, 41, 364, DateTimeKind.Local), LastModifiedById = "c98c8716-76a3-4c21-a155-e696959ec715", Name = "Gym Fees" },
                        new { ID = 3, Created = new DateTime(2018, 8, 15, 18, 29, 41, 364, DateTimeKind.Local), LastModified = new DateTime(2018, 8, 15, 18, 29, 41, 364, DateTimeKind.Local), LastModifiedById = "c98c8716-76a3-4c21-a155-e696959ec715", Name = "Membership Fees" },
                        new { ID = 4, Created = new DateTime(2018, 8, 15, 18, 29, 41, 364, DateTimeKind.Local), LastModified = new DateTime(2018, 8, 15, 18, 29, 41, 364, DateTimeKind.Local), LastModifiedById = "c98c8716-76a3-4c21-a155-e696959ec715", Name = "Old Boys Supporters" },
                        new { ID = 5, Created = new DateTime(2018, 8, 15, 18, 29, 41, 364, DateTimeKind.Local), LastModified = new DateTime(2018, 8, 15, 18, 29, 41, 364, DateTimeKind.Local), LastModifiedById = "c98c8716-76a3-4c21-a155-e696959ec715", Name = "Sponsorship" },
                        new { ID = 6, Created = new DateTime(2018, 8, 15, 18, 29, 41, 364, DateTimeKind.Local), LastModified = new DateTime(2018, 8, 15, 18, 29, 41, 364, DateTimeKind.Local), LastModifiedById = "c98c8716-76a3-4c21-a155-e696959ec715", Name = "Travel Expenses" },
                        new { ID = 7, Created = new DateTime(2018, 8, 15, 18, 29, 41, 364, DateTimeKind.Local), LastModified = new DateTime(2018, 8, 15, 18, 29, 41, 364, DateTimeKind.Local), LastModifiedById = "c98c8716-76a3-4c21-a155-e696959ec715", Name = "Coaches Wages" }
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
                        new { ID = 1, Created = new DateTime(2018, 8, 15, 18, 29, 41, 364, DateTimeKind.Local), LastModified = new DateTime(2018, 8, 15, 18, 29, 41, 364, DateTimeKind.Local), LastModifiedById = "c98c8716-76a3-4c21-a155-e696959ec715", Name = "Full Back" },
                        new { ID = 2, Created = new DateTime(2018, 8, 15, 18, 29, 41, 364, DateTimeKind.Local), LastModified = new DateTime(2018, 8, 15, 18, 29, 41, 364, DateTimeKind.Local), LastModifiedById = "c98c8716-76a3-4c21-a155-e696959ec715", Name = "Winger" },
                        new { ID = 3, Created = new DateTime(2018, 8, 15, 18, 29, 41, 364, DateTimeKind.Local), LastModified = new DateTime(2018, 8, 15, 18, 29, 41, 364, DateTimeKind.Local), LastModifiedById = "c98c8716-76a3-4c21-a155-e696959ec715", Name = "Center" },
                        new { ID = 4, Created = new DateTime(2018, 8, 15, 18, 29, 41, 364, DateTimeKind.Local), LastModified = new DateTime(2018, 8, 15, 18, 29, 41, 364, DateTimeKind.Local), LastModifiedById = "c98c8716-76a3-4c21-a155-e696959ec715", Name = "Out Half" },
                        new { ID = 5, Created = new DateTime(2018, 8, 15, 18, 29, 41, 364, DateTimeKind.Local), LastModified = new DateTime(2018, 8, 15, 18, 29, 41, 364, DateTimeKind.Local), LastModifiedById = "c98c8716-76a3-4c21-a155-e696959ec715", Name = "Scrum Half" },
                        new { ID = 6, Created = new DateTime(2018, 8, 15, 18, 29, 41, 364, DateTimeKind.Local), LastModified = new DateTime(2018, 8, 15, 18, 29, 41, 364, DateTimeKind.Local), LastModifiedById = "c98c8716-76a3-4c21-a155-e696959ec715", Name = "Number 8" },
                        new { ID = 7, Created = new DateTime(2018, 8, 15, 18, 29, 41, 364, DateTimeKind.Local), LastModified = new DateTime(2018, 8, 15, 18, 29, 41, 364, DateTimeKind.Local), LastModifiedById = "c98c8716-76a3-4c21-a155-e696959ec715", Name = "Flanker" },
                        new { ID = 8, Created = new DateTime(2018, 8, 15, 18, 29, 41, 364, DateTimeKind.Local), LastModified = new DateTime(2018, 8, 15, 18, 29, 41, 364, DateTimeKind.Local), LastModifiedById = "c98c8716-76a3-4c21-a155-e696959ec715", Name = "Second Row" },
                        new { ID = 9, Created = new DateTime(2018, 8, 15, 18, 29, 41, 364, DateTimeKind.Local), LastModified = new DateTime(2018, 8, 15, 18, 29, 41, 364, DateTimeKind.Local), LastModifiedById = "c98c8716-76a3-4c21-a155-e696959ec715", Name = "Hooker" },
                        new { ID = 10, Created = new DateTime(2018, 8, 15, 18, 29, 41, 364, DateTimeKind.Local), LastModified = new DateTime(2018, 8, 15, 18, 29, 41, 364, DateTimeKind.Local), LastModifiedById = "c98c8716-76a3-4c21-a155-e696959ec715", Name = "Prop" }
                    );
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
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

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

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

                    b.HasDiscriminator<string>("Discriminator").HasValue("IdentityUser");
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
                });

            modelBuilder.Entity("ClubTreasurer.Models.AppUser", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityUser");


                    b.ToTable("AppUser");

                    b.HasDiscriminator().HasValue("AppUser");
                });

            modelBuilder.Entity("ClubTreasurer.Models.BankAccount", b =>
                {
                    b.HasOne("ClubTreasurer.Models.AppUser", "LastModifiedBy")
                        .WithMany()
                        .HasForeignKey("LastModifiedById");

                    b.HasOne("ClubTreasurer.Models.Person", "Person")
                        .WithMany("BankAccounts")
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade);
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
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
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
