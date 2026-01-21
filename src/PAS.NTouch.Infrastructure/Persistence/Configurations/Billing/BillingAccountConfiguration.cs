using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PAS.NTouch.Domain.Billing.Entities;

namespace PAS.NTouch.Infrastructure.Persistence.Configurations.Billing;

public class BillingAccountConfiguration : IEntityTypeConfiguration<BillingAccount>
{
    public void Configure(EntityTypeBuilder<BillingAccount> builder)
    {
        builder.HasKey(ba => ba.Id);

        builder.Property(ba => ba.AccountNumber)
            .IsRequired()
            .HasMaxLength(50);

        builder.Property(ba => ba.BillingAccountType)
            .HasConversion<string>()
            .HasMaxLength(50);

        builder.Property(ba => ba.BillingCycle)
            .HasConversion<string>()
            .HasMaxLength(50);

        builder.Property(ba => ba.OutstandingAmount)
            .HasPrecision(18, 2);

        builder.Property(ba => ba.TotalBilledAmount)
            .HasPrecision(18, 2);

        builder.Property(ba => ba.Status)
            .HasConversion<string>()
            .HasMaxLength(20);

        builder.HasIndex(ba => ba.AccountNumber)
            .IsUnique();

        builder.HasMany(ba => ba.Installments)
            .WithOne(bi => bi.BillingAccount)
            .HasForeignKey(bi => bi.BillingAccountId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasMany(ba => ba.Invoices)
            .WithOne(i => i.BillingAccount)
            .HasForeignKey(i => i.BillingAccountId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasMany(ba => ba.Payments)
            .WithOne(p => p.BillingAccount)
            .HasForeignKey(p => p.BillingAccountId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
