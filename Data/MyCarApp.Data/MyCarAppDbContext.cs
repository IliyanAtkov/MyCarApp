using Duende.IdentityServer.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using MyCarApp.Data.Models;

namespace MyCarApp.Data
{
    public class MyCarAppDbContext : ApiAuthorizationDbContext<User>
    {
        public MyCarAppDbContext(DbContextOptions options, IOptions<OperationalStoreOptions> operationalStoreOptions)
            : base(options, operationalStoreOptions)
        {
        }

        public DbSet<Car> Cars => Set<Car>();

        public DbSet<Consumable> Consumable => Set<Consumable>();

        public DbSet<Expense> Expense => Set<Expense>();

        public DbSet<Refuel> Refuel => Set<Refuel>();

        public DbSet<Reminder> Reminder => Set<Reminder>();

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder
                .Entity<Car>()
                .Property(e => e.FuelType)
                .HasConversion(
                v => v.ToString(),
                v => (FuelType)Enum.Parse(typeof(FuelType), v));
        }
    }
}