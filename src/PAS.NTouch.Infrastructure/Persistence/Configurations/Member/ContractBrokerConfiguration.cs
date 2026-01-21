using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PAS.NTouch.Domain.Member.Entities;

namespace PAS.NTouch.Infrastructure.Persistence.Configurations.Member;

public class ContractBrokerConfiguration : IEntityTypeConfiguration<ContractBroker>
{
    public void Configure(EntityTypeBuilder<ContractBroker> builder)
    {
        builder.HasKey(cb => cb.Id);

        builder.Property(cb => cb.CommissionRate)
            .HasPrecision(5, 2);

        builder.Property(cb => cb.IsActive)
            .HasDefaultValue(true);

        builder.HasOne(cb => cb.BrokerInfo)
            .WithMany(b => b.ContractBrokers)
            .HasForeignKey(cb => cb.BrokerId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
