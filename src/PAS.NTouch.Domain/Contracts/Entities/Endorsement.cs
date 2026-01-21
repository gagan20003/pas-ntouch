using PAS.NTouch.SharedKernel;
using PAS.NTouch.Domain.Contracts.Enums;

namespace PAS.NTouch.Domain.Contracts.Entities;

/// <summary>
/// Endorsement entity for contract changes
/// </summary>
public class Endorsement : BaseEntity
{
    public int ContractId { get; set; }
    public EndorsementType EndorsementType { get; set; }
    public DateTime EffectiveDate { get; set; }
    public EndorsementStatus Status { get; set; }
    public bool IsActive { get; set; }

    // Navigation properties
    public virtual Contract Contract { get; set; } = null!;
    public virtual ICollection<MembersEndorsement> MembersEndorsements { get; set; } = new List<MembersEndorsement>();
    public virtual ICollection<ContractMemberEnrollment> AffectedEnrollments { get; set; } = new List<ContractMemberEnrollment>();
}
