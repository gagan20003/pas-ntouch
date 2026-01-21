using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PAS.NTouch.Domain.Member.Entities;

namespace PAS.NTouch.Infrastructure.Persistence.Configurations.Member;

public class BrokerInfoConfiguration : IEntityTypeConfiguration<BrokerInfo>
{
    public void Configure(EntityTypeBuilder<BrokerInfo> builder)
    {
        builder.HasKey(b => b.Id);

        builder.Property(b => b.BrokerName)
            .IsRequired()
            .HasMaxLength(200);

        builder.Property(b => b.OrganisationName)
            .HasMaxLength(200);

        builder.Property(b => b.Email)
            .HasMaxLength(200);

        builder.Property(b => b.ContactNumber)
            .HasMaxLength(20);

        builder.Property(b => b.Address)
            .HasMaxLength(500);

        builder.Property(b => b.OrganisationContactNumber)
            .HasMaxLength(20);

        builder.Property(b => b.OrganisationEmail)
            .HasMaxLength(200);

        builder.Property(b => b.LicenseNumber)
            .HasMaxLength(100);

        builder.Property(b => b.IssuedBy)
            .HasMaxLength(200);

        builder.Property(b => b.IsActive)
            .HasDefaultValue(true);

        builder.HasMany(b => b.ContractBrokers)
            .WithOne(cb => cb.BrokerInfo)
            .HasForeignKey(cb => cb.BrokerId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
