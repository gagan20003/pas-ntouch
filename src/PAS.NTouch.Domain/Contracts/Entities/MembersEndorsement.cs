using PAS.NTouch.SharedKernel;

namespace PAS.NTouch.Domain.Contracts.Entities;

/// <summary>
/// Members included in an endorsement
/// </summary>
public class MembersEndorsement : BaseEntity
{
    public int EndorsementId { get; set; }
    public int MemberId { get; set; }
    public int ContractId { get; set; }
    public int ContractCategoryId { get; set; }

    // Navigation properties
    public virtual Endorsement Endorsement { get; set; } = null!;
    public virtual Member.Entities.Member Member { get; set; } = null!;
    public virtual Contract Contract { get; set; } = null!;
    public virtual ContractCategory ContractCategory { get; set; } = null!;
    public virtual MemberPremiumEndorsement? PremiumEndorsement { get; set; }
}
