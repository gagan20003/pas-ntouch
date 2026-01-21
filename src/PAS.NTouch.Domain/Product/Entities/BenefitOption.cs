using PAS.NTouch.SharedKernel;

namespace PAS.NTouch.Domain.Product.Entities;

/// <summary>
/// Benefit option with pricing for a product FOB
/// </summary>
public class BenefitOption : BaseEntity
{
    public int ProductFOBId { get; set; }
    public string Code { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public decimal Cost { get; set; }

    // Navigation properties
    public virtual ProductFOB ProductFOB { get; set; } = null!;
}
