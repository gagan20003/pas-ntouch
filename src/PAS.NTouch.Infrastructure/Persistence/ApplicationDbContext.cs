using Microsoft.EntityFrameworkCore;
using PAS.NTouch.Domain.Product.Entities;
using PAS.NTouch.Domain.MasterSettings.Entities;
using PAS.NTouch.Domain.Member.Entities;
using PAS.NTouch.Domain.Contracts.Entities;
using PAS.NTouch.Domain.Billing.Entities;
using PAS.NTouch.SharedKernel.Interfaces;
using System.Reflection;

namespace PAS.NTouch.Infrastructure.Persistence;

/// <summary>
/// Application database context for NeonDB (PostgreSQL)
/// </summary>
public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    #region Product Module
    public DbSet<Product> Products => Set<Product>();
    public DbSet<ProductLimit> ProductLimits => Set<ProductLimit>();
    public DbSet<ProductFOB> ProductFOBs => Set<ProductFOB>();
    public DbSet<BenefitOption> BenefitOptions => Set<BenefitOption>();
    public DbSet<ProductFOBEligibility> ProductFOBEligibilities => Set<ProductFOBEligibility>();
    public DbSet<ProductFOBRate> ProductFOBRates => Set<ProductFOBRate>();
    public DbSet<ProductBrokerCommission> ProductBrokerCommissions => Set<ProductBrokerCommission>();
    #endregion

    #region MasterSettings Module
    public DbSet<Country> Countries => Set<Country>();
    public DbSet<Currency> Currencies => Set<Currency>();
    public DbSet<Tax> Taxes => Set<Tax>();
    public DbSet<Organization> Organizations => Set<Organization>();
    public DbSet<BillingFee> BillingFees => Set<BillingFee>();
    #endregion

    #region Member Module
    public DbSet<Member> Members => Set<Member>();
    public DbSet<MemberAddress> MemberAddresses => Set<MemberAddress>();
    public DbSet<MemberContact> MemberContacts => Set<MemberContact>();
    public DbSet<MemberIdentity> MemberIdentities => Set<MemberIdentity>();
    public DbSet<MemberOverPremium> MemberOverPremiums => Set<MemberOverPremium>();
    public DbSet<BrokerInfo> BrokerInfos => Set<BrokerInfo>();
    public DbSet<ContractBroker> ContractBrokers => Set<ContractBroker>();
    #endregion

    #region Contracts Module
    public DbSet<Contract> Contracts => Set<Contract>();
    public DbSet<ContractCategory> ContractCategories => Set<ContractCategory>();
    public DbSet<ContractMemberEnrollment> ContractMemberEnrollments => Set<ContractMemberEnrollment>();
    public DbSet<Endorsement> Endorsements => Set<Endorsement>();
    public DbSet<MembersEndorsement> MembersEndorsements => Set<MembersEndorsement>();
    public DbSet<MemberPremiumEndorsement> MemberPremiumEndorsements => Set<MemberPremiumEndorsement>();
    #endregion

    #region Billing Module
    public DbSet<BillingAccount> BillingAccounts => Set<BillingAccount>();
    public DbSet<BillingInstallment> BillingInstallments => Set<BillingInstallment>();
    public DbSet<Invoice> Invoices => Set<Invoice>();
    public DbSet<Payment> Payments => Set<Payment>();
    public DbSet<InvoiceInstallment> InvoiceInstallments => Set<InvoiceInstallment>();
    #endregion

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Apply all entity configurations from this assembly
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

        // Configure PostgreSQL-specific naming convention (snake_case)
        foreach (var entity in modelBuilder.Model.GetEntityTypes())
        {
            // Convert table names to snake_case
            entity.SetTableName(ToSnakeCase(entity.GetTableName()!));

            // Convert column names to snake_case
            foreach (var property in entity.GetProperties())
            {
                property.SetColumnName(ToSnakeCase(property.Name));
            }

            // Convert foreign key names to snake_case
            foreach (var key in entity.GetForeignKeys())
            {
                key.SetConstraintName(ToSnakeCase(key.GetConstraintName()!));
            }

            // Convert index names to snake_case
            foreach (var index in entity.GetIndexes())
            {
                index.SetDatabaseName(ToSnakeCase(index.GetDatabaseName()!));
            }
        }
    }

    public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        UpdateAuditableEntities();
        return base.SaveChangesAsync(cancellationToken);
    }

    public override int SaveChanges()
    {
        UpdateAuditableEntities();
        return base.SaveChanges();
    }

    private void UpdateAuditableEntities()
    {
        var entries = ChangeTracker.Entries<IAuditableEntity>();

        foreach (var entry in entries)
        {
            if (entry.State == EntityState.Added)
            {
                entry.Entity.CreatedAt = DateTime.UtcNow;
                entry.Entity.CreatedBy = "system"; // TODO: Replace with actual user context
            }
            else if (entry.State == EntityState.Modified)
            {
                entry.Entity.UpdatedAt = DateTime.UtcNow;
                entry.Entity.UpdatedBy = "system"; // TODO: Replace with actual user context
            }
        }
    }

    private static string ToSnakeCase(string input)
    {
        if (string.IsNullOrEmpty(input))
            return input;

        var result = new System.Text.StringBuilder();
        for (int i = 0; i < input.Length; i++)
        {
            char c = input[i];
            if (char.IsUpper(c))
            {
                if (i > 0)
                    result.Append('_');
                result.Append(char.ToLowerInvariant(c));
            }
            else
            {
                result.Append(c);
            }
        }
        return result.ToString();
    }
}
