﻿using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Threading;
using System;
using ClubTreasurer.Interfaces;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using ClubTreasurer.Models;

namespace ClubTreasurer.Models
{
    public class ClubTreasurerContext : IdentityDbContext<AppUser, AppRole, string>
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public ClubTreasurerContext (DbContextOptions<ClubTreasurerContext> options, IHttpContextAccessor httpContextAccessor)
            : base(options)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public DbSet<BankAccount> BankAccounts { get; set; }
        public DbSet<BankTransaction> BankTransactions { get; set; }
        public DbSet<BankTransactionCategory> BankTransactionCategorys { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<PlayerPosition> PlayerPositions { get; set; }
        public DbSet<AppUser> AppUsers { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.SetUniqueColumns();

            modelBuilder.Seed("cc07b6bb-3f27-4123-a6e5-41a610794478");
        }

        public override Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default(CancellationToken))
        {
            //OnBeforeSaving();
            return base.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken);
        }

        private void OnBeforeSaving()
        {
            var entries = ChangeTracker.Entries();
            var authenticatedUserId = _httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;

            var now = DateTime.Now;
            foreach (var entry in entries)
            {
                if (entry.Entity is IAuditable auditable)
                {
                    switch (entry.State)
                    {
                        case EntityState.Modified:
                            auditable.LastModified = now;
                            auditable.LastModifiedById = authenticatedUserId;
                            break;

                        case EntityState.Added:
                            auditable.Created = now;
                            //auditable.CreatedById = authenticatedUserId;
                            auditable.LastModified = now;
                            auditable.LastModifiedById = authenticatedUserId;
                            break;
                    }
                }
            }
        }

        public DbSet<ClubTreasurer.Models.AppRole> AppRole { get; set; }
    }
}