using PAS.NTouch.SharedKernel;
using PAS.NTouch.Domain.Billing.Enums;

namespace PAS.NTouch.Domain.Billing.Entities;

/// <summary>
/// Billing installment entity for premium collection
/// </summary>
public class BillingInstallment : AuditableEntity
{
    public int BillingAccountId { get; set; }
    public int EndorsementId { get; set; }
    public int InstallmentType { get; set; }
    public int ContractId { get; set; }
    public int MemberId { get; set; }
    public int ProductId { get; set; }
    public decimal Amount { get; set; }
    public DateTime DueDate { get; set; }
    public AccountStatus Status { get; set; }
    public TransactionType Type { get; set; }
    public decimal Tax { get; set; }

    // Navigation properties
    public virtual BillingAccount BillingAccount { get; set; } = null!;
    public virtual ICollection<InvoiceInstallment> InvoiceInstallments { get; set; } = new List<InvoiceInstallment>();
}
