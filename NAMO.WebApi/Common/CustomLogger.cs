using NLog;

namespace NAMO.WebApi.Common;

internal class CustomLogger
{
    internal static IDisposable FillInСustomLogs(IHttpContextAccessor httpContextAccessor)
    {
        return ScopeContext.PushProperties(new[]
        {
            new KeyValuePair<string, object>("RequestIp", httpContextAccessor?.HttpContext?.GetRequestIp() ?? ""),
            new KeyValuePair<string, object>("TraceIdentifier", httpContextAccessor?.HttpContext?.GetTraceIdentifier() ?? ""),
            new KeyValuePair<string, object>("RequestEndpoint", httpContextAccessor?.HttpContext?.GetTraceIdentifier() ?? ""),
        });
    }
}
