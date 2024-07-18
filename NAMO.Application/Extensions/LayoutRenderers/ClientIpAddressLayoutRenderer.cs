using NLog;
using NLog.LayoutRenderers;
using System.Text;

namespace NAMO.Application.Extensions.LayoutRenderers
{
    [LayoutRenderer("clientIpAddress")]
    public class ClientIpAddressLayoutRenderer() : LayoutRenderer
    {
        protected override void Append(StringBuilder builder, LogEventInfo logEvent)
        {
            var opNum = ScopeContext.TryGetProperty("clientIpAddress", out var value) ? value?.ToString() : null;

            if (!string.IsNullOrEmpty(opNum))
            {
                builder.Append(opNum);
            }
        }
    }
}
