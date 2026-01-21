using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PAS.NTouch.Domain.Product.Entities;

namespace PAS.NTouch.Infrastructure.Persistence.Configurations.Product;

public class BenefitOptionConfiguration : IEntityTypeConfiguration<BenefitOption>
{
    public void Configure(EntityTypeBuilder<BenefitOption> builder)
    {
        builder.HasKey(bo => bo.Id);

        builder.Property(bo => bo.Code)
            .IsRequired()
            .HasMaxLength(50);

        builder.Property(bo => bo.Name)
            .IsRequired()
            .HasMaxLength(200);

        builder.Property(bo => bo.Cost)
            .HasPrecision(18, 2);

        builder.HasOne(bo => bo.ProductFOB)
            .WithMany(pf => pf.BenefitOptions)
            .HasForeignKey(bo => bo.ProductFOBId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
