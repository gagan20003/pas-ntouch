using PAS.NTouch.SharedKernel;
using PAS.NTouch.Domain.Product.Enums;

namespace PAS.NTouch.Domain.Product.Entities;

/// <summary>
/// Rate table for product FOB based on age, gender, and parity
/// </summary>
public class ProductFOBRate : BaseEntity
{
    public int ProductFOBId { get; set; }
    public int AgeMin { get; set; }
    public int AgeMax { get; set; }
    public Gender Gender { get; set; }
    public Parity Parity { get; set; }
    public decimal Amount { get; set; }

    // Navigation properties
    public virtual ProductFOB ProductFOB { get; set; } = null!;
}
