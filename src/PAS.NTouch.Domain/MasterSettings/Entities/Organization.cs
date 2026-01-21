using PAS.NTouch.SharedKernel;

namespace PAS.NTouch.Domain.MasterSettings.Entities;

/// <summary>
/// Organization master entity
/// </summary>
public class Organization : BaseEntity
{
    public string OrganizationCode { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public string Type { get; set; } = string.Empty;
    public int CountryId { get; set; }
    public bool IsActive { get; set; }

    // Navigation properties
    public virtual Country Country { get; set; } = null!;
    public virtual ICollection<BillingFee> BillingFees { get; set; } = new List<BillingFee>();
}
