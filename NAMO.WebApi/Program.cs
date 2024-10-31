using Microsoft.AspNetCore.HttpOverrides;
using NAMO.Application.Extensions;
using NAMO.Infrastructure.Extensions;
using NAMO.Persistence.Extensions;
using NAMO.WebApi.Common;
using NLog;
using NLog.Web;
using System.Net;

//��������� ��������� ������ ��� Nlog
LogManager.Setup().SetupExtensions(s =>
{
    s.RegisterLayoutRenderer<CustomLayoutRenderer>("custom");
});

var logger = NLog.LogManager.Setup()
        .LoadConfigurationFromAppSettings()
        .GetCurrentClassLogger();
logger.Debug("Приложение запущена");

try
{
    var builder = WebApplication.CreateBuilder(args);

    builder.Services.AddHttpContextAccessor();

    // Внедрение сервисов
    builder.Logging.ClearProviders();
    builder.Logging.SetMinimumLevel
            (Microsoft.Extensions.Logging.LogLevel.Trace);
    builder.Host.UseNLog();

    // Add services to the container.
    builder.Services.AddApplicationLayer();
    builder.Services.AddInfrastructureLayer();
    builder.Services.AddPersistenceLayer(builder.Configuration);

    builder.Services.AddControllers();

    // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
    builder.Services.AddEndpointsApiExplorer();
    builder.Services.AddSwaggerGen();

    var app = builder.Build();

    app.UseForwardedHeaders(new ForwardedHeadersOptions
    {
        ForwardedHeaders = ForwardedHeaders.XForwardedFor | ForwardedHeaders.XForwardedProto
    });

    // Configure the HTTP request pipeline.
    if (app.Environment.IsDevelopment())
    {
        app.UseSwagger();
        app.UseSwaggerUI();
    }

    app.UseForwardedHeaders();
    app.UseRouting();

    app.UseHttpsRedirection();

    app.UseAuthorization();

    app.MapControllers();

    app.MapGet("/", () => "NAMO работает!");

    app.Run();

}
catch(Exception ex)
{
    logger.Error(ex, $"Остановлено из-за исключения: {ex.Message}");
    throw;
}
finally
{
    logger.Debug("Приложение остановлено");
    NLog.LogManager.Shutdown();
}
