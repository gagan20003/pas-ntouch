using PAS.NTouch.SharedKernel;
using PAS.NTouch.Domain.Product.Enums;

namespace PAS.NTouch.Domain.Product.Entities;

/// <summary>
/// Eligibility rules for product FOB based on gender and parity
/// </summary>
public class ProductFOBEligibility : BaseEntity
{
    public int ProductFOBId { get; set; }
    public Gender Gender { get; set; }
    public Parity Parity { get; set; }
    public bool IsEligible { get; set; }

    // Navigation properties
    public virtual ProductFOB ProductFOB { get; set; } = null!;
}
