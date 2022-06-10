using Microsoft.EntityFrameworkCore;
using PersiciFinancial.CustomerManagement.Domain.Models.Customers;
using PersiciFinancial.CustomerManagement.Persistence.Mappings;

namespace PersiciFinancial.CustomerManagement.Persistence
{
    public class CustomerManagementContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }

        public CustomerManagementContext()
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(CustomerMapping).Assembly);
            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=.;Initial Catalog=PersiciFinancial;User Id=sa; Password=123");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
