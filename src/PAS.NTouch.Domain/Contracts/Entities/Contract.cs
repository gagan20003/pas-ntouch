using PAS.NTouch.SharedKernel;
using PAS.NTouch.Domain.Member.Entities;

namespace PAS.NTouch.Domain.Contracts.Entities;

/// <summary>
/// Insurance contract entity
/// </summary>
public class Contract : BaseEntity
{
    public string ContractNumber { get; set; } = string.Empty;
    public string ContractName { get; set; } = string.Empty;
    public DateTime EffectiveDate { get; set; }
    public DateTime ExpiryDate { get; set; }
    public string Status { get; set; } = string.Empty;
    public int CountryId { get; set; }
    public int CurrencyId { get; set; }
    public int? MasterContractId { get; set; }

    // Navigation properties
    public virtual Contract? MasterContract { get; set; }
    public virtual ICollection<Contract> SubContracts { get; set; } = new List<Contract>();
    public virtual ICollection<ContractCategory> Categories { get; set; } = new List<ContractCategory>();
    public virtual ICollection<ContractMemberEnrollment> MemberEnrollments { get; set; } = new List<ContractMemberEnrollment>();
    public virtual ICollection<Endorsement> Endorsements { get; set; } = new List<Endorsement>();
    public virtual ContractBroker? ContractBroker { get; set; }
}
