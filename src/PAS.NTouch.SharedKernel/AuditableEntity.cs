using PAS.NTouch.SharedKernel.Interfaces;

namespace PAS.NTouch.SharedKernel;

/// <summary>
/// Base entity with audit fields for tracking creation and modification
/// </summary>
public abstract class AuditableEntity : BaseEntity, IAuditableEntity
{
    public DateTime CreatedAt { get; set; }
    public string CreatedBy { get; set; } = string.Empty;
    public DateTime? UpdatedAt { get; set; }
    public string? UpdatedBy { get; set; }
}
