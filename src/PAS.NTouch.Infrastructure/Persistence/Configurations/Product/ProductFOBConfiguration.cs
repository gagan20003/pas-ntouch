using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PAS.NTouch.Domain.Product.Entities;

namespace PAS.NTouch.Infrastructure.Persistence.Configurations.Product;

public class ProductFOBConfiguration : IEntityTypeConfiguration<ProductFOB>
{
    public void Configure(EntityTypeBuilder<ProductFOB> builder)
    {
        builder.HasKey(pf => pf.Id);

        builder.HasOne(pf => pf.Product)
            .WithMany(p => p.ProductFOBs)
            .HasForeignKey(pf => pf.ProductId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasMany(pf => pf.BenefitOptions)
            .WithOne(bo => bo.ProductFOB)
            .HasForeignKey(bo => bo.ProductFOBId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasMany(pf => pf.Eligibilities)
            .WithOne(e => e.ProductFOB)
            .HasForeignKey(e => e.ProductFOBId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasMany(pf => pf.Rates)
            .WithOne(r => r.ProductFOB)
            .HasForeignKey(r => r.ProductFOBId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
