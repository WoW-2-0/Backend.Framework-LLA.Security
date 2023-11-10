namespace Identity.Local.Infrastructure.Domain.Common;

public interface ISoftDeletedEntity : IAuditableEntity
{
    bool IsDeleted { get; set; }
    
    DateTimeOffset? DeletedDate { get; set; }
}