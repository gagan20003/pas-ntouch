using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PAS.NTouch.Domain.Contracts.Entities;

namespace PAS.NTouch.Infrastructure.Persistence.Configurations.Contracts;

public class EndorsementConfiguration : IEntityTypeConfiguration<Endorsement>
{
    public void Configure(EntityTypeBuilder<Endorsement> builder)
    {
        builder.HasKey(e => e.Id);

        builder.Property(e => e.EndorsementType)
            .HasConversion<string>()
            .HasMaxLength(50);

        builder.Property(e => e.Status)
            .HasConversion<string>()
            .HasMaxLength(50);

        builder.Property(e => e.IsActive)
            .HasDefaultValue(true);

        builder.HasOne(e => e.Contract)
            .WithMany(c => c.Endorsements)
            .HasForeignKey(e => e.ContractId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasMany(e => e.MembersEndorsements)
            .WithOne(me => me.Endorsement)
            .HasForeignKey(me => me.EndorsementId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasMany(e => e.AffectedEnrollments)
            .WithOne(cme => cme.LastEndorsement)
            .HasForeignKey(cme => cme.LastEndorsementId)
            .OnDelete(DeleteBehavior.SetNull);
    }
}
