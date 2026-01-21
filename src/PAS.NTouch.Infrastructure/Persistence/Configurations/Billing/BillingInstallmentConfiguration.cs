using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PAS.NTouch.Domain.Billing.Entities;

namespace PAS.NTouch.Infrastructure.Persistence.Configurations.Billing;

public class BillingInstallmentConfiguration : IEntityTypeConfiguration<BillingInstallment>
{
    public void Configure(EntityTypeBuilder<BillingInstallment> builder)
    {
        builder.HasKey(bi => bi.Id);

        builder.Property(bi => bi.Amount)
            .HasPrecision(18, 2);

        builder.Property(bi => bi.Tax)
            .HasPrecision(18, 2);

        builder.Property(bi => bi.Status)
            .HasConversion<string>()
            .HasMaxLength(20);

        builder.Property(bi => bi.Type)
            .HasConversion<string>()
            .HasMaxLength(20);

        builder.HasOne(bi => bi.BillingAccount)
            .WithMany(ba => ba.Installments)
            .HasForeignKey(bi => bi.BillingAccountId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasMany(bi => bi.InvoiceInstallments)
            .WithOne(ii => ii.BillingInstallment)
            .HasForeignKey(ii => ii.BillingInstallmentId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
