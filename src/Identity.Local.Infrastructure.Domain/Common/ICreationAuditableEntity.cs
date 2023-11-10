namespace Identity.Local.Infrastructure.Domain.Common;

public interface ICreationAuditableEntity
{
    Guid CreatedBy { get; set; }
}