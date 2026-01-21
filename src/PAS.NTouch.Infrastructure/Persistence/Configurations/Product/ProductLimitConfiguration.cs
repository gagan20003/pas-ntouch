using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PAS.NTouch.Domain.Product.Entities;

namespace PAS.NTouch.Infrastructure.Persistence.Configurations.Product;

public class ProductLimitConfiguration : IEntityTypeConfiguration<ProductLimit>
{
    public void Configure(EntityTypeBuilder<ProductLimit> builder)
    {
        builder.HasKey(pl => pl.Id);

        builder.Property(pl => pl.AnnualLimit)
            .HasPrecision(18, 2);

        builder.Property(pl => pl.RoomRentLimit)
            .HasPrecision(18, 2);

        builder.HasOne(pl => pl.Product)
            .WithMany(p => p.ProductLimits)
            .HasForeignKey(pl => pl.ProductId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
