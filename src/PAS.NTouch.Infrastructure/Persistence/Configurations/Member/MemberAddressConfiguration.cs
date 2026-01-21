using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PAS.NTouch.Domain.Member.Entities;

namespace PAS.NTouch.Infrastructure.Persistence.Configurations.Member;

public class MemberAddressConfiguration : IEntityTypeConfiguration<MemberAddress>
{
    public void Configure(EntityTypeBuilder<MemberAddress> builder)
    {
        builder.HasKey(a => a.Id);

        builder.Property(a => a.WorkLocation)
            .HasConversion<int>();

        builder.Property(a => a.StateName)
            .HasConversion<int>();

        builder.Property(a => a.AddressType)
            .HasConversion<int>();

        builder.Property(a => a.AddressLine1)
            .HasMaxLength(500);

        builder.Property(a => a.AddressLine2)
            .HasMaxLength(500);

        builder.Property(a => a.AddressLine3)
            .HasMaxLength(500);

        builder.HasOne(a => a.Member)
            .WithMany(m => m.Addresses)
            .HasForeignKey(a => a.MemberId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
