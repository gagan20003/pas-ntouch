using PAS.NTouch.SharedKernel;

namespace PAS.NTouch.Domain.MasterSettings.Entities;

/// <summary>
/// Currency master entity linked to a country
/// </summary>
public class Currency : BaseEntity
{
    public int CountryId { get; set; }
    public string CurrencyCode { get; set; } = string.Empty;
    public string CurrencyName { get; set; } = string.Empty;

    // Navigation properties
    public virtual Country Country { get; set; } = null!;
    public virtual ICollection<BillingFee> BillingFees { get; set; } = new List<BillingFee>();
}
