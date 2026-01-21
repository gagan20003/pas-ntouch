using PAS.NTouch.SharedKernel;

namespace PAS.NTouch.Domain.Product.Entities;

/// <summary>
/// Broker commission rates for products
/// </summary>
public class ProductBrokerCommission : BaseEntity
{
    public int ProductId { get; set; }
    public int BrokerId { get; set; }
    public decimal CommissionPct { get; set; }
    public bool IsActive { get; set; }

    // Navigation properties
    public virtual Product Product { get; set; } = null!;
}
