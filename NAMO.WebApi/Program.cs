using Microsoft.AspNetCore.HttpOverrides;
using NAMO.Application.Extensions;
using NAMO.Application.Extensions.LayoutRenderers;
using NAMO.Infrastructure.Extensions;
using NAMO.Persistence.Extensions;
using NLog;
using NLog.Web;
using System.Net;

//��������� ��������� ������ ��� Nlog
LogManager.Setup().SetupExtensions(s =>
{
    s.RegisterLayoutRenderer<OperationHashLayoutRenderer>("operationHash");
    s.RegisterLayoutRenderer<ClientIpAddressLayoutRenderer>("clientIpAddress");
    s.RegisterLayoutRenderer<RequestEndpointLayoutRenderer>("requestEndpoint");
    s.RegisterLayoutRenderer<RequestMethodLayoutRenderer>("requestMethod");
});

var logger = NLog.LogManager.Setup()
        .LoadConfigurationFromAppSettings()
        .GetCurrentClassLogger();
logger.Debug("������ ����������");

try
{
    var builder = WebApplication.CreateBuilder(args);

    builder.Services.AddHttpContextAccessor();

    // ��������� ������
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

    builder.Services.Configure<ForwardedHeadersOptions>(options =>
    {
        options.ForwardedHeaders = ForwardedHeaders.XForwardedFor | ForwardedHeaders.XForwardedProto;
        options.KnownProxies.Add(IPAddress.Parse("127.0.0.1"));
    });

    var app = builder.Build();

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

    app.MapGet("/", () => "NAMO ��������!");

    app.Run();

}
catch(Exception ex)
{
    logger.Error(ex, $"����������� ��-�� ����������: {ex.Message}");
    throw;
}
finally
{
    logger.Debug("���������� �����������");
    NLog.LogManager.Shutdown();
}
