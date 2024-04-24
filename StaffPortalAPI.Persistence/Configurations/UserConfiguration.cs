using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StaffPortalAPI.Domain.Models.Customers;
using StaffPortalAPI.Domain.Models.Users;
using StaffPortalAPI.SharedKernel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaffPortalAPI.Persistence.Configurations;

internal class UserConfiguration : IEntityTypeConfiguration<TestUser>
{
    public void Configure(EntityTypeBuilder<TestUser> builder)
    {
        builder.HasKey(c => c.Id);

        builder.Property(c => c.Id).HasConversion(
            customerId => customerId.Value,
            value => new TestUserId(value));

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

