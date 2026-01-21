using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PAS.NTouch.Domain.Member.Entities;

namespace PAS.NTouch.Infrastructure.Persistence.Configurations.Member;

public class MemberContactConfiguration : IEntityTypeConfiguration<MemberContact>
{
    public void Configure(EntityTypeBuilder<MemberContact> builder)
    {
        builder.HasKey(c => c.Id);

        builder.Property(c => c.CountryCallingCode)
            .HasConversion<int>();

        builder.Property(c => c.PhoneNumber)
            .HasMaxLength(20);

        builder.Property(c => c.Email)
            .HasMaxLength(200);

        builder.HasOne(c => c.Member)
            .WithOne(m => m.Contact)
            .HasForeignKey<MemberContact>(c => c.MemberId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
