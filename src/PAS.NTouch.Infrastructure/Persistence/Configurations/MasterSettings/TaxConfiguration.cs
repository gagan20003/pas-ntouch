using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PAS.NTouch.Domain.MasterSettings.Entities;

namespace PAS.NTouch.Infrastructure.Persistence.Configurations.MasterSettings;

public class TaxConfiguration : IEntityTypeConfiguration<Tax>
{
    public void Configure(EntityTypeBuilder<Tax> builder)
    {
        builder.HasKey(t => t.Id);

        builder.Property(t => t.TaxType)
            .HasConversion<string>()
            .HasMaxLength(20);

        builder.Property(t => t.TaxValue)
            .HasPrecision(5, 2);

        builder.HasOne(t => t.Country)
            .WithMany(c => c.Taxes)
            .HasForeignKey(t => t.CountryId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
