using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PAS.NTouch.Domain.Member.Entities;

namespace PAS.NTouch.Infrastructure.Persistence.Configurations.Member;

public class MemberOverPremiumConfiguration : IEntityTypeConfiguration<MemberOverPremium>
{
    public void Configure(EntityTypeBuilder<MemberOverPremium> builder)
    {
        builder.HasKey(op => op.Id);

        builder.Property(op => op.Reason)
            .HasMaxLength(500);

        builder.Property(op => op.ValueInPercent)
            .HasPrecision(5, 2);

        builder.Property(op => op.IsActive)
            .HasDefaultValue(true);

        builder.HasOne(op => op.Member)
            .WithMany(m => m.OverPremiums)
            .HasForeignKey(op => op.MemberId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(op => op.ProductFOB)
            .WithMany()
            .HasForeignKey(op => op.FobId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
