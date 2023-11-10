using Identity.Local.Infrastructure.Application.Common.Identity.Services;
using Identity.Local.Infrastructure.Infrastructure.Common.Identity.Services;
using Identity.Local.Infrastructure.Persistence.DataContexts;
using Identity.Local.Infrastructure.Persistence.Repositories;
using Identity.Local.Infrastructure.Persistence.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Identity.Local.Infrastructure.Api.Configurations;

public static partial class HostConfiguration
{
    private static WebApplicationBuilder AddIdentityInfrastructure(this WebApplicationBuilder builder)
    {
        // register db contexts
        builder.Services.AddDbContext<IdentityDbContext>(options =>
            options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));
        
        // register repositories
        builder.Services.AddScoped<IUserRepository, UserRepository>();
        
        // register foundation data access services
        builder.Services.AddScoped<IUserService, UserService>();

        return builder;
    }

    private static WebApplicationBuilder AddExposers(this WebApplicationBuilder builder)
    {
        builder.Services.AddRouting(options => options.LowercaseUrls = true);
        builder.Services.AddControllers();

        return builder;
    }

    private static WebApplication UseExposers(this WebApplication app)
    {
        app.MapControllers();

        return app;
    }
}