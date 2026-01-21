using PAS.NTouch.SharedKernel;

namespace PAS.NTouch.Domain.Product.Entities;

/// <summary>
/// Product limits for claims, annual amounts, and room rent
/// </summary>
public class ProductLimit : BaseEntity
{
    public int ProductId { get; set; }
    public int ClaimsLimit { get; set; }
    public decimal AnnualLimit { get; set; }
    public decimal RoomRentLimit { get; set; }

    // Navigation properties
    public virtual Product Product { get; set; } = null!;
}
