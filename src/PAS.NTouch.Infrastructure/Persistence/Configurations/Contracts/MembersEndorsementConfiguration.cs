using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PAS.NTouch.Domain.Contracts.Entities;

namespace PAS.NTouch.Infrastructure.Persistence.Configurations.Contracts;

public class MembersEndorsementConfiguration : IEntityTypeConfiguration<MembersEndorsement>
{
    public void Configure(EntityTypeBuilder<MembersEndorsement> builder)
    {
        builder.HasKey(me => me.Id);

        builder.HasOne(me => me.Endorsement)
            .WithMany(e => e.MembersEndorsements)
            .HasForeignKey(me => me.EndorsementId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(me => me.Member)
            .WithMany()
            .HasForeignKey(me => me.MemberId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(me => me.Contract)
            .WithMany()
            .HasForeignKey(me => me.ContractId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(me => me.ContractCategory)
            .WithMany()
            .HasForeignKey(me => me.ContractCategoryId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(me => me.PremiumEndorsement)
            .WithOne(pe => pe.MembersEndorsement)
            .HasForeignKey<MemberPremiumEndorsement>("MembersEndorsementId")
            .OnDelete(DeleteBehavior.Cascade);
    }
}
