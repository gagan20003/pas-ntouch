using PAS.NTouch.SharedKernel;

namespace PAS.NTouch.Domain.Billing.Entities;

/// <summary>
/// Invoice installment linking entity
/// </summary>
public class InvoiceInstallment : AuditableEntity
{
    public int InvoiceId { get; set; }
    public int BillingInstallmentId { get; set; }

    // Navigation properties
    public virtual Invoice Invoice { get; set; } = null!;
    public virtual BillingInstallment BillingInstallment { get; set; } = null!;
}
