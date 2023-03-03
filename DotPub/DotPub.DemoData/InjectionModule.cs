using DataTent;
using DotPub.DataContracts.WebFinger;
using DotPub.DemoData.WebFinger;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DotPub.DemoData;

public static class InjectionModule
{
    public static IServiceCollection AddConfig(
        this IServiceCollection services, IConfiguration config)
    {
        return services;
    }

    public static IServiceCollection AddDotPubDependencies(
        this IServiceCollection services)
    {
        services.AddScoped<IDataStore>(_ => new DataStore("data"));
        services.AddScoped<IWebFingerService, DemoWebFingerService>();
        return services;
    }
}