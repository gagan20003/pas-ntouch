using PAS.NTouch.SharedKernel;
using PAS.NTouch.Domain.Member.Enums;

namespace PAS.NTouch.Domain.Member.Entities;

/// <summary>
/// Member identity document entity
/// </summary>
public class MemberIdentity : AuditableEntity
{
    public int MemberId { get; set; }
    public IdentityType IdentityType { get; set; }
    public string IdentityValue { get; set; } = string.Empty;
    public DateTime IssueDate { get; set; }
    public DateTime ExpiryDate { get; set; }
    public bool IsVerified { get; set; }

    // Navigation properties
    public virtual Member Member { get; set; } = null!;
}
