using inventory_system;
using inventory_system.Configurations;
using inventory_system.Models;
using Microsoft.EntityFrameworkCore;


namespace inventory_system.Contexts
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AccountingEntriesConfiguration());
            modelBuilder.ApplyConfiguration(new ArticlesConfiguration());
            modelBuilder.ApplyConfiguration(new InventoryTypeConfiguration());
            modelBuilder.ApplyConfiguration(new TransactionsConfiguration());
            modelBuilder.ApplyConfiguration(new WarehousesConfiguration());

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<AccountingEntries> AccountingEntries { get; set; }
        public DbSet<Articles> Articles { get; set; }
        public DbSet<InventoryType> InventoryType { get; set; }
        public DbSet<Transactions> Transactions { get; set; }
        public DbSet<Warehouses> Warehouses { get; set; }
    }
}
