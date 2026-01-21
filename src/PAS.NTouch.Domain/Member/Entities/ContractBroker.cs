using PAS.NTouch.SharedKernel;

namespace PAS.NTouch.Domain.Member.Entities;

/// <summary>
/// Contract-Broker association entity
/// </summary>
public class ContractBroker : BaseEntity
{
    public int BrokerId { get; set; }
    public int ContractId { get; set; }
    public decimal CommissionRate { get; set; }
    public bool IsActive { get; set; }

    // Navigation properties
    public virtual BrokerInfo BrokerInfo { get; set; } = null!;
}
