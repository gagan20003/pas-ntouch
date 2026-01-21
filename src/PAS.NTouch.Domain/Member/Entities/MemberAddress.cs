using PAS.NTouch.SharedKernel;
using PAS.NTouch.Domain.Member.Enums;

namespace PAS.NTouch.Domain.Member.Entities;

/// <summary>
/// Member address entity
/// </summary>
public class MemberAddress : AuditableEntity
{
    public int MemberId { get; set; }
    public WorkLocation WorkLocation { get; set; }
    public StateName StateName { get; set; }
    public int PostalCode { get; set; }
    public AddressType AddressType { get; set; }
    public string AddressLine1 { get; set; } = string.Empty;
    public string AddressLine2 { get; set; } = string.Empty;
    public string AddressLine3 { get; set; } = string.Empty;

    // Navigation properties
    public virtual Member Member { get; set; } = null!;
}
