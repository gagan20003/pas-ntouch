using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PAS.NTouch.Domain.Member.Entities;

namespace PAS.NTouch.Infrastructure.Persistence.Configurations.Member;

public class MemberConfiguration : IEntityTypeConfiguration<Domain.Member.Entities.Member>
{
    public void Configure(EntityTypeBuilder<Domain.Member.Entities.Member> builder)
    {
        builder.HasKey(m => m.Id);

        builder.Property(m => m.EmployeeId)
            .HasMaxLength(50);

        builder.Property(m => m.FirstName)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(m => m.LastName)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(m => m.Nationality)
            .HasConversion<int>();

        builder.Property(m => m.Gender)
            .HasConversion<int>();

        builder.Property(m => m.MaritalStatus)
            .HasConversion<int>();

        builder.Property(m => m.DependentRelationshipType)
            .HasConversion<int>();

        builder.Property(m => m.Designation)
            .HasConversion<int>();

        builder.Property(m => m.IsActive)
            .HasDefaultValue(true);

        // Self-referencing relationship for dependants
        builder.HasOne(m => m.PrimaryMember)
            .WithMany(m => m.Dependants)
            .HasForeignKey(m => m.PrimaryMemberId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasMany(m => m.Addresses)
            .WithOne(a => a.Member)
            .HasForeignKey(a => a.MemberId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(m => m.Contact)
            .WithOne(c => c.Member)
            .HasForeignKey<MemberContact>(c => c.MemberId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasMany(m => m.Identities)
            .WithOne(i => i.Member)
            .HasForeignKey(i => i.MemberId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasMany(m => m.OverPremiums)
            .WithOne(op => op.Member)
            .HasForeignKey(op => op.MemberId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
