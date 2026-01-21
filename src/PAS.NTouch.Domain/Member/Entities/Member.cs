using PAS.NTouch.SharedKernel;
using PAS.NTouch.Domain.Member.Enums;

namespace PAS.NTouch.Domain.Member.Entities;

/// <summary>
/// Member entity representing an insured person (employee or dependent)
/// </summary>
public class Member : AuditableEntity
{
    public string EmployeeId { get; set; } = string.Empty;
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public DateTime DateOfBirth { get; set; }
    public Nationality Nationality { get; set; }
    public GenderType Gender { get; set; }
    public MaritalStatus MaritalStatus { get; set; }
    public bool IsActive { get; set; }
    public DependentRelationship DependentRelationshipType { get; set; }
    public int? PrimaryMemberId { get; set; }
    public Designation Designation { get; set; }

    // Navigation properties
    public virtual Member? PrimaryMember { get; set; }
    public virtual ICollection<Member> Dependants { get; set; } = new List<Member>();
    public virtual ICollection<MemberAddress> Addresses { get; set; } = new List<MemberAddress>();
    public virtual MemberContact? Contact { get; set; }
    public virtual ICollection<MemberIdentity> Identities { get; set; } = new List<MemberIdentity>();
    public virtual ICollection<MemberOverPremium> OverPremiums { get; set; } = new List<MemberOverPremium>();
}
