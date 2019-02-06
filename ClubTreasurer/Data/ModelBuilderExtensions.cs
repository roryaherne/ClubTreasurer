using Microsoft.EntityFrameworkCore;
using System;

namespace ClubTreasurer.Models
{
    public static class ModelBuilderExtensions
    {
        public static void SetTables(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BankAccount>().ToTable("BankAccount");
            modelBuilder.Entity<BankTransaction>().ToTable("BankTransaction");
            modelBuilder.Entity<BankTransactionCategory>().ToTable("BankTransactionCategory");
            modelBuilder.Entity<Person>().ToTable("Person");
            modelBuilder.Entity<Player>().ToTable("Player");
            modelBuilder.Entity<PlayerPosition>().ToTable("PlayerPosition");
        }

        public static void RemoveInheritence(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BankAccount>().HasBaseType((Type)null);
            modelBuilder.Entity<BankTransaction>().HasBaseType((Type)null);
            modelBuilder.Entity<BankTransactionCategory>().HasBaseType((Type)null);
            modelBuilder.Entity<Person>().HasBaseType((Type)null);
            modelBuilder.Entity<Player>().HasBaseType((Type)null);
            modelBuilder.Entity<PlayerPosition>().HasBaseType((Type)null);
            
        }

        public static void SetUniqueColumns(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BankAccount>()
                .HasIndex(b => b.IBAN)
                .IsUnique();

            modelBuilder.Entity<BankTransaction>()
                .HasAlternateKey(t => t.ReferenceNumber);
        }

        public static void Seed(this ModelBuilder modelBuilder)
        {
            var now = DateTime.Now;
            var userId = "e2a8bd78-87eb-4e39-aafd-fd9d67e3c48e"; //Guid.NewGuid().ToString();

            modelBuilder.Entity<AppUser>().HasData(
                new AppUser { Email = "fake@fake.com", Id = userId, UserName = "seeder", EmailConfirmed = true }
            );

            modelBuilder.Entity<AppRole>().HasData(
                new AppRole { Name = "FinaceEditor", Description = "CRUD operations on finances", LastModified = now, LastModifiedById = userId },
                new AppRole { Name = "FinanceReader", Description = "Read operations on finances", LastModified = now, LastModifiedById = userId }
            );

            modelBuilder.Entity<BankTransactionCategory>().HasData(
                new BankTransactionCategory { Name = "Coaching Fees", ID = 1 , Created = now, LastModified = now, LastModifiedById = userId, KeyWords="coaching"},
                new BankTransactionCategory { Name = "Gym Fees", ID = 2 , Created = now, LastModified = now, LastModifiedById = userId, KeyWords="gym,fitness"},
                new BankTransactionCategory { Name = "Membership Fees", ID = 3 , Created = now, LastModified = now, LastModifiedById = userId, KeyWords = "mitglied,membership"},
                new BankTransactionCategory { Name = "Old Boys Supporters", ID = 4 , Created = now, LastModified = now, LastModifiedById = userId, KeyWords = "old boys,oldboys"},
                new BankTransactionCategory { Name = "Sponsorship", ID = 5 , Created = now, LastModified = now, LastModifiedById = userId, KeyWords = "sponsor"},
                new BankTransactionCategory { Name = "Travel Expenses", ID = 6 , Created = now, LastModified = now, LastModifiedById = userId, KeyWords = "travel,fuel,train,zug" },
                new BankTransactionCategory { Name = "Coaches Wages", ID = 7 , Created = now, LastModified = now, LastModifiedById = userId}
            );

            modelBuilder.Entity<PlayerPosition>().HasData(
                new PlayerPosition { Name = "Full Back", ID = 1, Created = now, LastModified = now, LastModifiedById = userId },
                new PlayerPosition { Name = "Winger", ID = 2, Created = now, LastModified = now, LastModifiedById = userId },
                new PlayerPosition { Name = "Center", ID = 3, Created = now, LastModified = now, LastModifiedById = userId },
                new PlayerPosition { Name = "Out Half", ID = 4, Created = now, LastModified = now, LastModifiedById = userId },
                new PlayerPosition { Name = "Scrum Half", ID = 5, Created = now, LastModified = now, LastModifiedById = userId },
                new PlayerPosition { Name = "Number 8", ID = 6, Created = now, LastModified = now, LastModifiedById = userId },
                new PlayerPosition { Name = "Flanker", ID = 7, Created = now, LastModified = now, LastModifiedById = userId },
                new PlayerPosition { Name = "Second Row", ID = 8, Created = now, LastModified = now, LastModifiedById = userId },
                new PlayerPosition { Name = "Hooker", ID = 9, Created = now, LastModified = now, LastModifiedById = userId },
                new PlayerPosition { Name = "Prop", ID = 10, Created = now, LastModified = now, LastModifiedById = userId }
            );

            modelBuilder.Entity<Player>().HasData(
                new Player { FirstName = "Max", LastName = "Büttner", DOB = new DateTime (1989,12,10), PositionId = 9, Created = now, LastModified = now, LastModifiedById = userId, ID = 1 },
                new Player { FirstName = "Jeremie", LastName = "DeJean", DOB = new DateTime(1983, 8, 1), PositionId = 5 , Created = now, LastModified = now, LastModifiedById = userId, ID = 2 },
                new Player { FirstName = "Julia", LastName = "Hensler", DOB = new DateTime(1998,7,9), PositionId = 10 , Created = now, LastModified = now, LastModifiedById = userId, ID = 3 },
                new Player { FirstName = "Kristin", LastName = "Hiltpot", DOB = new DateTime(1991,2,26), PositionId = 2 , Created = now, LastModified = now, LastModifiedById = userId, ID = 4 },
                new Player { FirstName = "Philip", LastName = "Westerlund", DOB = new DateTime(1990,5,16), PositionId = 10, Created = now, LastModified = now, LastModifiedById = userId, ID = 5 },
                new Player { FirstName = "Hannah", LastName = "Werkgarner", DOB = new DateTime(1998,2,28), PositionId = 2 , Created = now, LastModified = now, LastModifiedById = userId, ID = 6 },
                new Player { FirstName = "Anna", LastName = "Wallensteiner", DOB = new DateTime(1994,8,7), PositionId = 2 , Created = now, LastModified = now, LastModifiedById = userId, ID = 7 },
                new Player { FirstName = "Nils", LastName = "Unthan", DOB = new DateTime(1989,4,29), PositionId = 2 , Created = now, LastModified = now, LastModifiedById = userId, ID = 8 },
                new Player { FirstName = "Thomas", LastName = "Tripp", DOB = new DateTime(1994,3,4), PositionId = 8 , Created = now, LastModified = now, LastModifiedById = userId, ID = 9 },
                new Player { FirstName = "Davide", LastName = "Sorvillo", DOB = new DateTime(1998,7,24), PositionId = 2 , Created = now, LastModified = now, LastModifiedById = userId, ID = 10 },
                new Player { FirstName = "Florian", LastName = "Rudiferia", DOB = new DateTime(1995,11,11), PositionId = 4 , Created = now, LastModified = now, LastModifiedById = userId, ID = 11 },
                new Player { FirstName = "Barbara", LastName = "Rieger", DOB = new DateTime(1991,7,27), PositionId = 10 , Created = now, LastModified = now, LastModifiedById = userId, ID = 12 },
                new Player { FirstName = "Christian", LastName = "Pöhl", DOB = new DateTime(1993,12,1), PositionId = 2 , Created = now, LastModified = now, LastModifiedById = userId, ID = 13 },
                new Player { FirstName = "Nesar", LastName = "Nazari", DOB = new DateTime(1990,2,6), PositionId = 2 , Created = now, LastModified = now, LastModifiedById = userId, ID = 14 },
                new Player { FirstName = "Sebastian", LastName = "Müller", DOB = new DateTime(1990,8,7), PositionId = 8 , Created = now, LastModified = now, LastModifiedById = userId, ID = 15 },
                new Player { FirstName = "Benjamin", LastName = "Rabl", DOB = new DateTime(1995,4,25), PositionId = 3 , Created = now, LastModified = now, LastModifiedById = userId, ID = 16 },
                new Player { FirstName = "Tom", LastName = "Millen", DOB = new DateTime(1996,8,1), PositionId = 5 , Created = now, LastModified = now, LastModifiedById = userId, ID = 17 },
                new Player { FirstName = "Mathias", LastName = "Märk", DOB = new DateTime(1985,6,10), PositionId = 4 , Created = now, LastModified = now, LastModifiedById = userId, ID = 18 },
                new Player { FirstName = "Isabella", LastName = "Luke", DOB = new DateTime(1995,11,4), PositionId = 5 , Created = now, LastModified = now, LastModifiedById = userId, ID = 19 },
                new Player { FirstName = "Gerald", LastName = "Lerchbaumer", DOB = new DateTime(1989,10,10), PositionId = 2 , Created = now, LastModified = now, LastModifiedById = userId, ID = 20 },
                new Player { FirstName = "Lukas", LastName = "Kolb", DOB = new DateTime(1991,6,6), PositionId = 7 , Created = now, LastModified = now, LastModifiedById = userId, ID = 21 },
                new Player { FirstName = "Khvistani", LastName = "Giorgi", DOB = new DateTime(1993,3,8), PositionId = 10 , Created = now, LastModified = now, LastModifiedById = userId, ID = 22 }
            );
        }
    }
}
