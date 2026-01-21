using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PAS.NTouch.Domain.Billing.Entities;

namespace PAS.NTouch.Infrastructure.Persistence.Configurations.Billing;

public class InvoiceInstallmentConfiguration : IEntityTypeConfiguration<InvoiceInstallment>
{
    public void Configure(EntityTypeBuilder<InvoiceInstallment> builder)
    {
        builder.HasKey(ii => ii.Id);

        builder.HasOne(ii => ii.Invoice)
            .WithMany(i => i.InvoiceInstallments)
            .HasForeignKey(ii => ii.InvoiceId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(ii => ii.BillingInstallment)
            .WithMany(bi => bi.InvoiceInstallments)
            .HasForeignKey(ii => ii.BillingInstallmentId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
