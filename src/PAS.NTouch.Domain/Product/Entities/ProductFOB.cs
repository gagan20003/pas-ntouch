using PAS.NTouch.SharedKernel;

namespace PAS.NTouch.Domain.Product.Entities;

/// <summary>
/// Product Feature/Option/Benefit (FOB) entity
/// </summary>
public class ProductFOB : BaseEntity
{
    public int ProductId { get; set; }
    public int FobId { get; set; }

    // Navigation properties
    public virtual Product Product { get; set; } = null!;
    public virtual ICollection<BenefitOption> BenefitOptions { get; set; } = new List<BenefitOption>();
    public virtual ICollection<ProductFOBEligibility> Eligibilities { get; set; } = new List<ProductFOBEligibility>();
    public virtual ICollection<ProductFOBRate> Rates { get; set; } = new List<ProductFOBRate>();
}
