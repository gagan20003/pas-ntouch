using PAS.NTouch.SharedKernel;
using PAS.NTouch.Domain.Contracts.Enums;

namespace PAS.NTouch.Domain.Contracts.Entities;

/// <summary>
/// Member enrollment in a contract
/// </summary>
public class ContractMemberEnrollment : BaseEntity
{
    public int ContractId { get; set; }
    public int ContractCategoryId { get; set; }
    public int MemberId { get; set; }
    public DateTime EffectiveDate { get; set; }
    public DateTime? CancellationDate { get; set; }
    public int? LastEndorsementId { get; set; }
    public ContractStatus Status { get; set; }

    // Navigation properties
    public virtual Contract Contract { get; set; } = null!;
    public virtual ContractCategory ContractCategory { get; set; } = null!;
    public virtual Member.Entities.Member Member { get; set; } = null!;
    public virtual Endorsement? LastEndorsement { get; set; }
}
