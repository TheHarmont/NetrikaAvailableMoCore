using NLog;
using NLog.Config;
using NLog.LayoutRenderers;
using System.Text;

namespace NAMO.WebApi.Common;

[LayoutRenderer("custom")]
internal class CustomLayoutRenderer : LayoutRenderer
{
    [DefaultParameter]
    public string? Property {  get; set; }

    protected override void Append(StringBuilder builder, LogEventInfo logEvent)
    {
        switch (Property?.ToLower())
        {
            case "request-ip":
                AppendRequestIp(builder, logEvent);
                break;
            case "trace-identifier":
                AppendTraceIdentifier(builder, logEvent);
                break;
            case "request-endpoint":
                AppendTraceIdentifier(builder, logEvent);
                break;
            default:
                break;
        }
    }

    private void AppendRequestIp(StringBuilder builder, LogEventInfo logEvent) =>
        builder.Append(ScopeContext.TryGetProperty("RequestIp", out var value) ? value?.ToString() : null);

    private void AppendTraceIdentifier(StringBuilder builder, LogEventInfo logEvent) =>
        builder.Append(ScopeContext.TryGetProperty("TraceIdentifier", out var value) ? value?.ToString() : null);

    private void AppendRequestEndpoint(StringBuilder builder, LogEventInfo logEvent) =>
        builder.Append(ScopeContext.TryGetProperty("RequestEndpoint", out var value) ? value?.ToString() : null);
}
