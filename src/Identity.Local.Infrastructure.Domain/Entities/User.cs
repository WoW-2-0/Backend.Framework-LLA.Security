using Identity.Local.Infrastructure.Domain.Common;

namespace Identity.Local.Infrastructure.Domain.Entities;

public class User : AuditableEntity, IDeletionAuditableEntity, IModificationAuditableEntity
{
    public string FirstName { get; set; } = default!;

    public string LastName { get; set; } = default!;

    public int Age { get; set; }

    public string EmailAddress { get; set; } = default!;

    public string PasswordHash { get; set; } = default!;
    
    public bool IsEmailAddressVerified { get; set; }
    
    public Guid? DeletedBy { get; set; }
    
    public Guid? ModifiedBy { get; set; }
    
    // public Guid RoleId { get; set; }

    // public virtual Role Role { get; set; }
}