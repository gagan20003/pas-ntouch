using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PAS.NTouch.Domain.MasterSettings.Entities;

namespace PAS.NTouch.Infrastructure.Persistence.Configurations.MasterSettings;

public class BillingFeeConfiguration : IEntityTypeConfiguration<BillingFee>
{
    public void Configure(EntityTypeBuilder<BillingFee> builder)
    {
        builder.HasKey(bf => bf.Id);

        builder.Property(bf => bf.FeeName)
            .IsRequired()
            .HasMaxLength(200);

        builder.Property(bf => bf.CalculationType)
            .HasConversion<string>()
            .HasMaxLength(20);

        builder.Property(bf => bf.FeeValue)
            .HasPrecision(18, 2);

        builder.Property(bf => bf.IsActive)
            .HasDefaultValue(true);

        builder.HasOne(bf => bf.Country)
            .WithMany(c => c.BillingFees)
            .HasForeignKey(bf => bf.CountryId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(bf => bf.Organization)
            .WithMany(o => o.BillingFees)
            .HasForeignKey(bf => bf.OrganizationId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(bf => bf.Currency)
            .WithMany(c => c.BillingFees)
            .HasForeignKey(bf => bf.CurrencyId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
