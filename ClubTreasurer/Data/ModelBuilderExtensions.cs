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

        public static void SetKeys(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BankTransaction>()
               .Property(t => t.ID)
               .ValueGeneratedNever();

            modelBuilder.Entity<BankAccount>()
               .Property(t => t.ID)
               .ValueGeneratedNever();
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
                new Player { FirstName = "Joe", LastName = "Bloggs", DOB = new DateTime (1990,1,1), PositionId = 9, Created = now, LastModified = now, LastModifiedById = userId, ID = 1 }
            );
        }
    }
}
