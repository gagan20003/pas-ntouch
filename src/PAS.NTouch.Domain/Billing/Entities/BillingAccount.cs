using PAS.NTouch.SharedKernel;
using PAS.NTouch.Domain.Billing.Enums;

namespace PAS.NTouch.Domain.Billing.Entities;

/// <summary>
/// Billing account entity for contract billing
/// </summary>
public class BillingAccount : AuditableEntity
{
    public int MasterContractId { get; set; }
    public int ContractId { get; set; }
    public int CurrencyId { get; set; }
    public string AccountNumber { get; set; } = string.Empty;
    public BillingAccountType BillingAccountType { get; set; }
    public BillingCycle BillingCycle { get; set; }
    public decimal OutstandingAmount { get; set; }
    public decimal TotalBilledAmount { get; set; }
    public AccountStatus Status { get; set; }

    // Navigation properties
    public virtual ICollection<BillingInstallment> Installments { get; set; } = new List<BillingInstallment>();
    public virtual ICollection<Invoice> Invoices { get; set; } = new List<Invoice>();
    public virtual ICollection<Payment> Payments { get; set; } = new List<Payment>();
}
