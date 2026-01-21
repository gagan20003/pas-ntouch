using PAS.NTouch.SharedKernel;
using PAS.NTouch.Domain.Member.Enums;

namespace PAS.NTouch.Domain.Member.Entities;

/// <summary>
/// Member contact information entity
/// </summary>
public class MemberContact : AuditableEntity
{
    public int MemberId { get; set; }
    public CountryCallingCode CountryCallingCode { get; set; }
    public string PhoneNumber { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public long EmergencyContact { get; set; }

    // Navigation properties
    public virtual Member Member { get; set; } = null!;
}
