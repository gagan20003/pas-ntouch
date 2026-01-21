using PAS.NTouch.SharedKernel;
using PAS.NTouch.Domain.Product.Entities;

namespace PAS.NTouch.Domain.Contracts.Entities;

/// <summary>
/// Contract category linking contracts to products
/// </summary>
public class ContractCategory : BaseEntity
{
    public int MasterContractId { get; set; }
    public string CategoryCode { get; set; } = string.Empty;
    public int ProductId { get; set; }
    public string CategoryName { get; set; } = string.Empty;
    public bool IsActive { get; set; }

    // Navigation properties
    public virtual Contract MasterContract { get; set; } = null!;
    public virtual Product.Entities.Product Product { get; set; } = null!;
    public virtual ICollection<ContractMemberEnrollment> MemberEnrollments { get; set; } = new List<ContractMemberEnrollment>();
}
