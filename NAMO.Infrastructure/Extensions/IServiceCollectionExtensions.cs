using MediatR;
using Microsoft.Extensions.DependencyInjection;
using NAMO.Application.Interfaces;
using NAMO.Infrastructure.Services;

namespace NAMO.Infrastructure.Extensions;

public static class IServiceCollectionExtensions
{
    public static void AddInfrastructureLayer(this IServiceCollection services)
    {
        services.AddServices();
    }

    private static void AddServices(this IServiceCollection services)
    {
        services.
            AddTransient<IMediator, Mediator>().
            AddScoped<IPatiVerService, PatiVerService>().
            AddTransient<ISeparatePersonsService, SeparatePersonsService>().
            AddTransient<IAvailableMOService, AvailableMOService>();
    }
}
