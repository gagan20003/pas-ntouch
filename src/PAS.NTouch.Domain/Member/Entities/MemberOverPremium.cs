using PAS.NTouch.SharedKernel;
using PAS.NTouch.Domain.Product.Entities;

namespace PAS.NTouch.Domain.Member.Entities;

/// <summary>
/// Member over-premium adjustments
/// </summary>
public class MemberOverPremium : AuditableEntity
{
    public int MemberId { get; set; }
    public int FobId { get; set; }
    public string Reason { get; set; } = string.Empty;
    public decimal ValueInPercent { get; set; }
    public bool IsActive { get; set; }

    // Navigation properties
    public virtual Member Member { get; set; } = null!;
    public virtual ProductFOB ProductFOB { get; set; } = null!;
}
