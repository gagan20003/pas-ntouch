using PAS.NTouch.SharedKernel;
using PAS.NTouch.Domain.MasterSettings.Enums;

namespace PAS.NTouch.Domain.MasterSettings.Entities;

/// <summary>
/// Tax configuration by country
/// </summary>
public class Tax : BaseEntity
{
    public int CountryId { get; set; }
    public TaxType TaxType { get; set; }
    public decimal TaxValue { get; set; }

    // Navigation properties
    public virtual Country Country { get; set; } = null!;
}
