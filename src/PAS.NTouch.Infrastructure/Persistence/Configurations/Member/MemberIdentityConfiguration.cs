using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PAS.NTouch.Domain.Member.Entities;

namespace PAS.NTouch.Infrastructure.Persistence.Configurations.Member;

public class MemberIdentityConfiguration : IEntityTypeConfiguration<MemberIdentity>
{
    public void Configure(EntityTypeBuilder<MemberIdentity> builder)
    {
        builder.HasKey(i => i.Id);

        builder.Property(i => i.IdentityType)
            .HasConversion<int>();

        builder.Property(i => i.IdentityValue)
            .IsRequired()
            .HasMaxLength(100);

        builder.HasOne(i => i.Member)
            .WithMany(m => m.Identities)
            .HasForeignKey(i => i.MemberId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
