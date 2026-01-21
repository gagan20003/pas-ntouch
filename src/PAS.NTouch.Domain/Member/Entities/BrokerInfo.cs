using PAS.NTouch.SharedKernel;

namespace PAS.NTouch.Domain.Member.Entities;

/// <summary>
/// Broker information entity
/// </summary>
public class BrokerInfo : BaseEntity
{
    public string BrokerName { get; set; } = string.Empty;
    public string OrganisationName { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string ContactNumber { get; set; } = string.Empty;
    public string Address { get; set; } = string.Empty;
    public string OrganisationContactNumber { get; set; } = string.Empty;
    public string OrganisationEmail { get; set; } = string.Empty;
    public string LicenseNumber { get; set; } = string.Empty;
    public string IssuedBy { get; set; } = string.Empty;
    public DateTime LicenseExpiryDate { get; set; }
    public bool IsActive { get; set; }

    // Navigation properties
    public virtual ICollection<ContractBroker> ContractBrokers { get; set; } = new List<ContractBroker>();
}
