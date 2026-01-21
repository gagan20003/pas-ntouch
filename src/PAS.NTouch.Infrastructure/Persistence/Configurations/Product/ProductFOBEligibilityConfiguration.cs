using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PAS.NTouch.Domain.Product.Entities;

namespace PAS.NTouch.Infrastructure.Persistence.Configurations.Product;

public class ProductFOBEligibilityConfiguration : IEntityTypeConfiguration<ProductFOBEligibility>
{
    public void Configure(EntityTypeBuilder<ProductFOBEligibility> builder)
    {
        builder.HasKey(e => e.Id);

        builder.Property(e => e.Gender)
            .HasConversion<string>()
            .HasMaxLength(50);

        builder.Property(e => e.Parity)
            .HasConversion<string>()
            .HasMaxLength(50);

        builder.HasOne(e => e.ProductFOB)
            .WithMany(pf => pf.Eligibilities)
            .HasForeignKey(e => e.ProductFOBId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
