using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PersiciFinancial.CustomerManagement.Domain.Models.Customers;

namespace PersiciFinancial.CustomerManagement.Persistence.Mappings
{
    public class CustomerMapping : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.ToTable("Customer");
            builder.Property(f => f.FirstName).HasMaxLength(50).IsRequired();
            builder.Property(l => l.LastName).HasMaxLength(50).IsRequired();
            builder.Property(d => d.DateOfBirth).HasColumnType("DateTime").IsRequired();
            builder.Property(e => e.Email).HasMaxLength(70);
            builder.Property(p => p.PhoneNumber).HasMaxLength(13).IsRequired();
            builder.Property(a => a.BankAccountNumber).HasMaxLength(25).IsRequired();
        }
    }
}
