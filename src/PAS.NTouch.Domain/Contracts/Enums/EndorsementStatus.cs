namespace PAS.NTouch.Domain.Contracts.Enums;

/// <summary>
/// Endorsement processing status
/// </summary>
public enum EndorsementStatus
{
    Draft = 1,
    PendingValidation = 2,
    Validated = 3,
    SentForComputation = 4,
    Completed = 5,
    Cancelled = 6
}
