using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using StaffPortalAPI.Domain.Models.Customers;
using StaffPortalAPI.SharedKernel;

namespace StaffPortalAPI.Persistence.Configurations;

internal class CustomerConfiguration : IEntityTypeConfiguration<TestCustomer>
{
    public void Configure(EntityTypeBuilder<TestCustomer> builder)
    {
        builder.HasKey(c => c.Id);

        builder.Property(c => c.Id).HasConversion(
            customerId => customerId.Value,
            value => new TestCustomerId(value));

        builder.OwnsOne(c => c.FirstName, firstName => {
            firstName.Property(fn => fn.Value)
            .HasMaxLength(50)
            .HasColumnName("FirstName").IsRequired();
        });
        
        builder.OwnsOne(c => c.LastName, lastName => {
            lastName.Property(ln => ln.Value)
            .HasMaxLength(50)
            .HasColumnName("LastName").IsRequired();
        });
        

        builder.Property(c => c.Email)
            .HasMaxLength(255)
            .HasConversion(
                email => email.ToString(),
                value => Email.Parse(value));

        builder.HasIndex(c => c.Email).IsUnique();
    }
}
