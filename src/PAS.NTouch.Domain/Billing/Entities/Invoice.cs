using PAS.NTouch.SharedKernel;
using PAS.NTouch.Domain.Billing.Enums;

namespace PAS.NTouch.Domain.Billing.Entities;

/// <summary>
/// Invoice entity
/// </summary>
public class Invoice : AuditableEntity
{
    public int BillingAccountId { get; set; }
    public int InvoiceNumber { get; set; }
    public decimal Amount { get; set; }
    public decimal Tax { get; set; }
    public AccountStatus Status { get; set; }
    public DateTime? CancelledOn { get; set; }
    public string? CancelledReason { get; set; }

    // Navigation properties
    public virtual BillingAccount BillingAccount { get; set; } = null!;
    public virtual ICollection<Payment> Payments { get; set; } = new List<Payment>();
    public virtual ICollection<InvoiceInstallment> InvoiceInstallments { get; set; } = new List<InvoiceInstallment>();
}
