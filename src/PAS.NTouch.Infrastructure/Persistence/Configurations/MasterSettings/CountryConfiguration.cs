using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PAS.NTouch.Domain.MasterSettings.Entities;

namespace PAS.NTouch.Infrastructure.Persistence.Configurations.MasterSettings;

public class CountryConfiguration : IEntityTypeConfiguration<Country>
{
    public void Configure(EntityTypeBuilder<Country> builder)
    {
        builder.HasKey(c => c.Id);

        builder.Property(c => c.CountryCode)
            .IsRequired()
            .HasMaxLength(10);

        builder.Property(c => c.CountryName)
            .IsRequired()
            .HasMaxLength(100);

        builder.HasIndex(c => c.CountryCode)
            .IsUnique();

        builder.HasMany(c => c.Currencies)
            .WithOne(cur => cur.Country)
            .HasForeignKey(cur => cur.CountryId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasMany(c => c.Taxes)
            .WithOne(t => t.Country)
            .HasForeignKey(t => t.CountryId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasMany(c => c.Organizations)
            .WithOne(o => o.Country)
            .HasForeignKey(o => o.CountryId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasMany(c => c.BillingFees)
            .WithOne(bf => bf.Country)
            .HasForeignKey(bf => bf.CountryId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
