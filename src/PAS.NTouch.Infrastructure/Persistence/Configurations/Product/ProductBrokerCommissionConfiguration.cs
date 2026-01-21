using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PAS.NTouch.Domain.Product.Entities;

namespace PAS.NTouch.Infrastructure.Persistence.Configurations.Product;

public class ProductBrokerCommissionConfiguration : IEntityTypeConfiguration<ProductBrokerCommission>
{
    public void Configure(EntityTypeBuilder<ProductBrokerCommission> builder)
    {
        builder.HasKey(pbc => pbc.Id);

        builder.Property(pbc => pbc.CommissionPct)
            .HasPrecision(5, 2);

        builder.Property(pbc => pbc.IsActive)
            .HasDefaultValue(true);

        builder.HasOne(pbc => pbc.Product)
            .WithMany(p => p.ProductBrokerCommissions)
            .HasForeignKey(pbc => pbc.ProductId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
