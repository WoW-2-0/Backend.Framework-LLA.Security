namespace Identity.Local.Infrastructure.Domain.Common;

public interface IModificationAuditableEntity
{
    Guid? ModifiedBy { get; set; }
}