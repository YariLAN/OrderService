using Microsoft.EntityFrameworkCore;
using OrderService.Models.Db;

namespace OrderService.Provider
{
    public class OrdersDbContext : DbContext
    {
        public DbSet<Order> Orders { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseNpgsql("Host=postgres_db;Port=5432;Database=OrdersDb;User Id=admin;Password=Post");
            }
        }

        public OrdersDbContext(DbContextOptions<OrdersDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Order>(ent =>
            {
                ent.ToTable("Order");

                ent.HasKey(x => x.Id);

                ent.Property(x => x.Id).ValueGeneratedOnAdd();

                ent.Property(x => x.CitySender).HasMaxLength(70).IsRequired();

                ent.Property(x => x.CityRecipient).HasMaxLength(70).IsRequired();

                ent.Property(x => x.WeightCargo).IsRequired();

                ent.Property(x => x.AddressSender).IsRequired();

                ent.Property(x => x.AddressRecipient).IsRequired();

                ent.Property(x => x.DateDispatch).IsRequired();
            });
        }
    }
}
