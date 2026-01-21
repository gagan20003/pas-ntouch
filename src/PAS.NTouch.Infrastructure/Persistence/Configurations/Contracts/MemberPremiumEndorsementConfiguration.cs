using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PAS.NTouch.Domain.Contracts.Entities;

namespace PAS.NTouch.Infrastructure.Persistence.Configurations.Contracts;

public class MemberPremiumEndorsementConfiguration : IEntityTypeConfiguration<MemberPremiumEndorsement>
{
    public void Configure(EntityTypeBuilder<MemberPremiumEndorsement> builder)
    {
        builder.HasKey(mpe => mpe.Id);

        builder.Property(mpe => mpe.ProductPremium)
            .HasPrecision(18, 2);

        builder.Property(mpe => mpe.OverPremiumAmount)
            .HasPrecision(18, 2);

        builder.Property(mpe => mpe.TotalPremiumAmount)
            .HasPrecision(18, 2);

        builder.HasOne(mpe => mpe.Endorsement)
            .WithMany()
            .HasForeignKey(mpe => mpe.EndorsementId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(mpe => mpe.Member)
            .WithMany()
            .HasForeignKey(mpe => mpe.MemberId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(mpe => mpe.Product)
            .WithMany()
            .HasForeignKey(mpe => mpe.ProductId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(mpe => mpe.MembersEndorsement)
            .WithOne(me => me.PremiumEndorsement)
            .HasForeignKey<MemberPremiumEndorsement>("MembersEndorsementId")
            .OnDelete(DeleteBehavior.Cascade);
    }
}
