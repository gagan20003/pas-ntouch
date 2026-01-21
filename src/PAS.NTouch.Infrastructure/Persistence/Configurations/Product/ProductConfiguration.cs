using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PAS.NTouch.Domain.Product.Entities;

namespace PAS.NTouch.Infrastructure.Persistence.Configurations.Product;

public class ProductConfiguration : IEntityTypeConfiguration<Domain.Product.Entities.Product>
{
    public void Configure(EntityTypeBuilder<Domain.Product.Entities.Product> builder)
    {
        builder.HasKey(p => p.Id);

        builder.Property(p => p.Name)
            .IsRequired()
            .HasMaxLength(200);

        builder.Property(p => p.IsActive)
            .HasDefaultValue(true);

        builder.HasMany(p => p.ProductLimits)
            .WithOne(pl => pl.Product)
            .HasForeignKey(pl => pl.ProductId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasMany(p => p.ProductFOBs)
            .WithOne(pf => pf.Product)
            .HasForeignKey(pf => pf.ProductId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasMany(p => p.ProductBrokerCommissions)
            .WithOne(pbc => pbc.Product)
            .HasForeignKey(pbc => pbc.ProductId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
