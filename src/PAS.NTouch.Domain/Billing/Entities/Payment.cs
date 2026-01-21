using PAS.NTouch.SharedKernel;
using PAS.NTouch.Domain.Billing.Enums;

namespace PAS.NTouch.Domain.Billing.Entities;

/// <summary>
/// Payment entity for premium collection
/// </summary>
public class Payment : AuditableEntity
{
    public int BillingAccountId { get; set; }
    public int InvoiceId { get; set; }
    public decimal Amount { get; set; }
    public DateTime PaymentDate { get; set; }
    public PaymentMode Mode { get; set; }
    public int ReferenceNumber { get; set; }
    public PaymentStatus Status { get; set; }
    public TransactionType Type { get; set; }

    // Navigation properties
    public virtual BillingAccount BillingAccount { get; set; } = null!;
    public virtual Invoice Invoice { get; set; } = null!;
}
