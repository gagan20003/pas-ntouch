using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PAS.NTouch.Domain.Product.Entities;

namespace PAS.NTouch.Infrastructure.Persistence.Configurations.Product;

public class ProductFOBRateConfiguration : IEntityTypeConfiguration<ProductFOBRate>
{
    public void Configure(EntityTypeBuilder<ProductFOBRate> builder)
    {
        builder.HasKey(r => r.Id);

        builder.Property(r => r.Gender)
            .HasConversion<string>()
            .HasMaxLength(50);

        builder.Property(r => r.Parity)
            .HasConversion<string>()
            .HasMaxLength(50);

        builder.Property(r => r.Amount)
            .HasPrecision(18, 2);

        builder.HasOne(r => r.ProductFOB)
            .WithMany(pf => pf.Rates)
            .HasForeignKey(r => r.ProductFOBId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
