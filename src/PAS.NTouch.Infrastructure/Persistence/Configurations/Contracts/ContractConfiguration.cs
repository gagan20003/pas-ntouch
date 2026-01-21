using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PAS.NTouch.Domain.Contracts.Entities;

namespace PAS.NTouch.Infrastructure.Persistence.Configurations.Contracts;

public class ContractConfiguration : IEntityTypeConfiguration<Contract>
{
    public void Configure(EntityTypeBuilder<Contract> builder)
    {
        builder.HasKey(c => c.Id);

        builder.Property(c => c.ContractNumber)
            .IsRequired()
            .HasMaxLength(50);

        builder.Property(c => c.ContractName)
            .IsRequired()
            .HasMaxLength(200);

        builder.Property(c => c.Status)
            .HasMaxLength(50);

        builder.HasIndex(c => c.ContractNumber)
            .IsUnique();

        // Self-referencing for Master/Sub contracts
        builder.HasOne(c => c.MasterContract)
            .WithMany(c => c.SubContracts)
            .HasForeignKey(c => c.MasterContractId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasMany(c => c.Categories)
            .WithOne(cc => cc.MasterContract)
            .HasForeignKey(cc => cc.MasterContractId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasMany(c => c.MemberEnrollments)
            .WithOne(me => me.Contract)
            .HasForeignKey(me => me.ContractId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasMany(c => c.Endorsements)
            .WithOne(e => e.Contract)
            .HasForeignKey(e => e.ContractId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(c => c.ContractBroker)
            .WithMany()
            .HasForeignKey("ContractBrokerId")
            .IsRequired(false)
            .OnDelete(DeleteBehavior.SetNull);
    }
}
