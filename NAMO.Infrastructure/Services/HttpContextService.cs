using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using NAMO.Application.Interfaces;

namespace NAMO.Infrastructure.Services
{
    public class HttpContextService : IHttpContextService
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public HttpContextService(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }
        public string? GetClientIpAddresses()
        {
            var context = _httpContextAccessor.HttpContext;
            var forwardedHeader = context?.Request?.Headers["X-Forwarded-For"].FirstOrDefault();
            var remoteIpAddress = context?.Connection?.RemoteIpAddress?.ToString();
            var ipAddress = string.IsNullOrEmpty(forwardedHeader) ? remoteIpAddress : forwardedHeader?.Split(',').FirstOrDefault()?.Trim();

            return ipAddress;
        }

        public string? GetRequestEndpoint()
        {
            return _httpContextAccessor.HttpContext?.Request?.Path;
        }

        public string? GetRequestMethod()
        {
            return _httpContextAccessor.HttpContext?.Request?.Method;
        }
    }
}
