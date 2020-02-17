using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Threading;
using System;
using ClubTreasurer.Interfaces;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System.Data.SqlClient;
using System.Linq;

namespace ClubTreasurer.Models
{
    public class ClubTreasurerContext : IdentityDbContext<AppUser, AppRole, string>
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IOptions<RCIConfig> _rciConfig;

        public ClubTreasurerContext(DbContextOptions<ClubTreasurerContext> options, 
            IHttpContextAccessor httpContextAccessor, IOptions<RCIConfig> rciConfig)
            : base(options)
        {
            _httpContextAccessor = httpContextAccessor;
            _rciConfig = rciConfig;
        }

        public DbSet<BankAccount> BankAccounts { get; set; }
        public DbSet<BankTransaction> BankTransactions { get; set; }
        public DbSet<BankTransactionCategory> BankTransactionCategorys { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<PlayerPosition> PlayerPositions { get; set; }
        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<AppRole> AppRole { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.SetKeys();
            modelBuilder.Seed();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.EnableSensitiveDataLogging();
        }

        public override Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default(CancellationToken))
        {
            OnBeforeSaving();
            return base.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken);
        }

        private void OnBeforeSaving()
        {
            var entries = ChangeTracker.Entries();
            string userId;
            userId = _httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            if (string.IsNullOrWhiteSpace(userId)) {
                userId = AppUsers.Where(u => u.Email == _rciConfig.Value.AdminEmailAddress).FirstOrDefault().Id;
            }

            var now = DateTime.Now;
            foreach (var entry in entries)
            {
                if (entry.Entity is IAuditable auditable)
                {
                    switch (entry.State)
                    {
                        case EntityState.Modified:
                            auditable.LastModified = now;
                            auditable.LastModifiedById = userId;
                            break;

                        case EntityState.Added:
                            auditable.Created = now;
                            auditable.LastModified = now;
                            auditable.LastModifiedById = userId;
                            break;
                    }
                }
            }
        }
    }
}
