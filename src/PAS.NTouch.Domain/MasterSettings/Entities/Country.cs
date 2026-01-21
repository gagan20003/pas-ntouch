using PAS.NTouch.SharedKernel;

namespace PAS.NTouch.Domain.MasterSettings.Entities;

/// <summary>
/// Country master entity
/// </summary>
public class Country : BaseEntity
{
    public string CountryCode { get; set; } = string.Empty;
    public string CountryName { get; set; } = string.Empty;

    // Navigation properties
    public virtual ICollection<Currency> Currencies { get; set; } = new List<Currency>();
    public virtual ICollection<Tax> Taxes { get; set; } = new List<Tax>();
    public virtual ICollection<Organization> Organizations { get; set; } = new List<Organization>();
    public virtual ICollection<BillingFee> BillingFees { get; set; } = new List<BillingFee>();
}
