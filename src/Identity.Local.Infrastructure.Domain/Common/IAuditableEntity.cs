namespace Identity.Local.Infrastructure.Domain.Common;

public interface IAuditableEntity : IEntity
{
    DateTimeOffset CreatedTime { get; set; }
    
    DateTimeOffset? ModifiedTime { get; set; }
}