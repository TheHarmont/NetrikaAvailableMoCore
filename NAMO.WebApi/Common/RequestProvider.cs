namespace NAMO.WebApi.Common;

internal static class RequestProvider
{
    public static string? GetRequestIp(this HttpContext httpContext)
    {
        var forwardedHeader = httpContext?.Request?.Headers["X-Forwarded-For"].FirstOrDefault();
        var remoteIpAddress = httpContext?.Request?.Host.Host.ToString();
        var ipAddress = string.IsNullOrEmpty(forwardedHeader) ? remoteIpAddress : forwardedHeader?.Split(',').FirstOrDefault()?.Trim();

        return ipAddress;
    }

    public static string? GetTraceIdentifier(this HttpContext httpContext)
    {
        return httpContext?.TraceIdentifier;
    }

    public static string? GetTraceEndpoint(this HttpContext httpContext)
    {
        return httpContext?.Request?.Path;
    }
}
