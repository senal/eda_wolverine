using Microsoft.EntityFrameworkCore;
using Order.Domain;
using Order.Infrastructure.Persistance.Configurations;

namespace Order.Infrastructure.Persistance
{
    public class OrderDbContext : DbContext
    {
        public DbSet<Domain.Order> orders { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new OrderConfiguration());
        }
    }
}
