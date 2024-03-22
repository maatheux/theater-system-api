using Microsoft.Extensions.DependencyInjection;
using TheaterSystem.Application.Common.Interfaces.Authentication;
using TheaterSystem.Application.Common.Interfaces.Services;
using TheaterSystem.Infrastructure.Authentication;
using TheaterSystem.Infrastructure.Services;
using Microsoft.Extensions.Configuration;

namespace TheaterSystem.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(
        this IServiceCollection services,
        ConfigurationManager configuration)
    {
        services.Configure<JwtSettings>(configuration.GetSection(JwtSettings.SectionName));
        services.AddSingleton<IJwtTokenGenerator, JwtTokenGenerator>();
        services.AddSingleton<IDateTimeProvider, DateTimeProvider>();
        return services;
    }
}
