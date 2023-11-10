namespace Identity.Local.Infrastructure.Domain.Common;

public interface IDeletionAuditableEntity
{
    Guid? DeletedBy { get; set; }
}