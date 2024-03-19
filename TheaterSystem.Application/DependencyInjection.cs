using Microsoft.Extensions.DependencyInjection;
using TheaterSystem.Application.Services.Authentication;

namespace TheaterSystem.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddAppliction(this IServiceCollection services)
    {
        services.AddScoped<IAuthenticationService, AuthenticationService>();
        return services;
    }
}