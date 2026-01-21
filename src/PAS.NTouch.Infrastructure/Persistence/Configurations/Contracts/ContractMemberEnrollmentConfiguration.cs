using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PAS.NTouch.Domain.Contracts.Entities;

namespace PAS.NTouch.Infrastructure.Persistence.Configurations.Contracts;

public class ContractMemberEnrollmentConfiguration : IEntityTypeConfiguration<ContractMemberEnrollment>
{
    public void Configure(EntityTypeBuilder<ContractMemberEnrollment> builder)
    {
        builder.HasKey(cme => cme.Id);

        builder.Property(cme => cme.Status)
            .HasConversion<string>()
            .HasMaxLength(50);

        builder.HasOne(cme => cme.Contract)
            .WithMany(c => c.MemberEnrollments)
            .HasForeignKey(cme => cme.ContractId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(cme => cme.ContractCategory)
            .WithMany(cc => cc.MemberEnrollments)
            .HasForeignKey(cme => cme.ContractCategoryId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(cme => cme.Member)
            .WithMany()
            .HasForeignKey(cme => cme.MemberId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(cme => cme.LastEndorsement)
            .WithMany(e => e.AffectedEnrollments)
            .HasForeignKey(cme => cme.LastEndorsementId)
            .IsRequired(false)
            .OnDelete(DeleteBehavior.SetNull);
    }
}
