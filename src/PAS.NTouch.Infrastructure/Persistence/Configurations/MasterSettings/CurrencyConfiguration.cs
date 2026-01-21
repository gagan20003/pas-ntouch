using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PAS.NTouch.Domain.MasterSettings.Entities;

namespace PAS.NTouch.Infrastructure.Persistence.Configurations.MasterSettings;

public class CurrencyConfiguration : IEntityTypeConfiguration<Currency>
{
    public void Configure(EntityTypeBuilder<Currency> builder)
    {
        builder.HasKey(c => c.Id);

        builder.Property(c => c.CurrencyCode)
            .IsRequired()
            .HasMaxLength(10);

        builder.Property(c => c.CurrencyName)
            .IsRequired()
            .HasMaxLength(100);

        builder.HasIndex(c => c.CurrencyCode)
            .IsUnique();

        builder.HasOne(c => c.Country)
            .WithMany(co => co.Currencies)
            .HasForeignKey(c => c.CountryId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasMany(c => c.BillingFees)
            .WithOne(bf => bf.Currency)
            .HasForeignKey(bf => bf.CurrencyId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
