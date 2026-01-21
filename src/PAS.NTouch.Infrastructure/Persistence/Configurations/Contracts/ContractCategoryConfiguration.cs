using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PAS.NTouch.Domain.Contracts.Entities;

namespace PAS.NTouch.Infrastructure.Persistence.Configurations.Contracts;

public class ContractCategoryConfiguration : IEntityTypeConfiguration<ContractCategory>
{
    public void Configure(EntityTypeBuilder<ContractCategory> builder)
    {
        builder.HasKey(cc => cc.Id);

        builder.Property(cc => cc.CategoryCode)
            .IsRequired()
            .HasMaxLength(50);

        builder.Property(cc => cc.CategoryName)
            .IsRequired()
            .HasMaxLength(200);

        builder.Property(cc => cc.IsActive)
            .HasDefaultValue(true);

        builder.HasOne(cc => cc.MasterContract)
            .WithMany(c => c.Categories)
            .HasForeignKey(cc => cc.MasterContractId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(cc => cc.Product)
            .WithMany()
            .HasForeignKey(cc => cc.ProductId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasMany(cc => cc.MemberEnrollments)
            .WithOne(me => me.ContractCategory)
            .HasForeignKey(me => me.ContractCategoryId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
