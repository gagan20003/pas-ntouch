using PAS.NTouch.SharedKernel;

namespace PAS.NTouch.Domain.Product.Entities;

/// <summary>
/// Insurance product entity
/// </summary>
public class Product : BaseEntity
{
    public string Name { get; set; } = string.Empty;
    public int CountryId { get; set; }
    public int CurrencyId { get; set; }
    public bool IsActive { get; set; }

    // Navigation properties
    public virtual ICollection<ProductLimit> ProductLimits { get; set; } = new List<ProductLimit>();
    public virtual ICollection<ProductFOB> ProductFOBs { get; set; } = new List<ProductFOB>();
    public virtual ICollection<ProductBrokerCommission> ProductBrokerCommissions { get; set; } = new List<ProductBrokerCommission>();
}
