using PAS.NTouch.SharedKernel;
using PAS.NTouch.Domain.MasterSettings.Enums;

namespace PAS.NTouch.Domain.MasterSettings.Entities;

/// <summary>
/// Billing fee configuration by country, organization, and currency
/// </summary>
public class BillingFee : BaseEntity
{
    public string FeeName { get; set; } = string.Empty;
    public CalculationType CalculationType { get; set; }
    public decimal FeeValue { get; set; }
    public int CountryId { get; set; }
    public int OrganizationId { get; set; }
    public int CurrencyId { get; set; }
    public DateTime EffectiveFrom { get; set; }
    public DateTime EffectiveTo { get; set; }
    public bool IsActive { get; set; }

    // Navigation properties
    public virtual Country Country { get; set; } = null!;
    public virtual Organization Organization { get; set; } = null!;
    public virtual Currency Currency { get; set; } = null!;
}
