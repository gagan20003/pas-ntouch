using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PAS.NTouch.Domain.MasterSettings.Entities;

namespace PAS.NTouch.Infrastructure.Persistence.Configurations.MasterSettings;

public class OrganizationConfiguration : IEntityTypeConfiguration<Organization>
{
    public void Configure(EntityTypeBuilder<Organization> builder)
    {
        builder.HasKey(o => o.Id);

        builder.Property(o => o.OrganizationCode)
            .IsRequired()
            .HasMaxLength(50);

        builder.Property(o => o.Name)
            .IsRequired()
            .HasMaxLength(200);

        builder.Property(o => o.Type)
            .HasMaxLength(100);

        builder.Property(o => o.IsActive)
            .HasDefaultValue(true);

        builder.HasIndex(o => o.OrganizationCode)
            .IsUnique();

        builder.HasOne(o => o.Country)
            .WithMany(c => c.Organizations)
            .HasForeignKey(o => o.CountryId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasMany(o => o.BillingFees)
            .WithOne(bf => bf.Organization)
            .HasForeignKey(bf => bf.OrganizationId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
