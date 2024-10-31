using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NAMO.Application.Interfaces;
using NAMO.Application.Interfaces.Repositories;
using NAMO.Persistence.ConnectedService.PatiVer;
using NAMO.Persistence.Context;
using NAMO.Persistence.Repositories;

namespace NAMO.Persistence.Extensions;

public static class IServiceCollectionExtensions
{
    private const string DataBaseConnectionString = "NAMO";

    public static void AddPersistenceLayer(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext(configuration);
        services.AddRepositories();
    }

    public static void AddDbContext(this IServiceCollection services, IConfiguration configuration)
    {
        var connectionString = configuration.GetConnectionString(DataBaseConnectionString);

        services.AddDbContext<ApplicationDBContext>(options =>
           options.UseSqlServer(connectionString,
           builder =>
           {
               // TimeOut 10 секунд
               builder.CommandTimeout(10);
               builder.MigrationsAssembly(typeof(ApplicationDBContext).Assembly.FullName);
           }));
    }

    private static void AddRepositories(this IServiceCollection services)
    {
        services.
            AddScoped<IMORepository, MORepository>().
            AddScoped<ISeparatePersonsRepository, SeparatePersonsRepository>().
            AddScoped<IWcfService, WcfServiceClient>();
    }
}
