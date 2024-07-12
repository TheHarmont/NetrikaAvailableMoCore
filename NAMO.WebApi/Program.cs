using NAMO.Application.Extensions;
using NAMO.Infrastructure.Extensions;
using NAMO.Persistence.Extensions;
using NLog;
using NLog.Web;

//��������� ��������� ������ ��� Nlog
LogManager.Setup().SetupExtensions(s =>
{
    s.RegisterLayoutRenderer<OperationHashLayoutRenderer>("operationHash");
});

var logger = NLog.LogManager.Setup()
        .LoadConfigurationFromAppSettings()
        .GetCurrentClassLogger();
logger.Debug("������ ����������");

try
{
    var builder = WebApplication.CreateBuilder(args);

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

    var app = builder.Build();

    // Configure the HTTP request pipeline.
    if (app.Environment.IsDevelopment())
    {
        app.UseSwagger();
        app.UseSwaggerUI();
    }

    app.UseHttpsRedirection();

    app.UseAuthorization();

    app.MapControllers();

    app.Run();

}
catch(Exception ex)
{
    logger.Error(ex, $"����������� ��-�� ����������: {ex.Message}");
    throw;
}
finally
{
    NLog.LogManager.Shutdown();
}
