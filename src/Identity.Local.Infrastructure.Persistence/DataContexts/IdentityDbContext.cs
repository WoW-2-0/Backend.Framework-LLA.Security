using Identity.Local.Infrastructure.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Identity.Local.Infrastructure.Persistence.DataContexts;

public class IdentityDbContext : DbContext
{
    public IdentityDbContext(DbContextOptions<IdentityDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(IdentityDbContext).Assembly);
    }
}