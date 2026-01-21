using PAS.NTouch.SharedKernel;

namespace PAS.NTouch.Domain.Contracts.Entities;

/// <summary>
/// Premium calculation results for member endorsements
/// </summary>
public class MemberPremiumEndorsement : BaseEntity
{
    public int EndorsementId { get; set; }
    public int MemberId { get; set; }
    public int ProductId { get; set; }
    public int FobId { get; set; }
    public decimal ProductPremium { get; set; }
    public decimal OverPremiumAmount { get; set; }
    public decimal TotalPremiumAmount { get; set; }

    // Navigation properties
    public virtual Endorsement Endorsement { get; set; } = null!;
    public virtual Member.Entities.Member Member { get; set; } = null!;
    public virtual Product.Entities.Product Product { get; set; } = null!;
    public virtual MembersEndorsement MembersEndorsement { get; set; } = null!;
}
