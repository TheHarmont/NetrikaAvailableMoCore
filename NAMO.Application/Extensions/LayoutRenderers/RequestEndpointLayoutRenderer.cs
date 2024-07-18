using NLog.LayoutRenderers;
using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NAMO.Application.Extensions.LayoutRenderers
{
    [LayoutRenderer("requestEndpoint")]
    public class RequestEndpointLayoutRenderer : LayoutRenderer
    {
        protected override void Append(StringBuilder builder, LogEventInfo logEvent)
        {
            var opNum = ScopeContext.TryGetProperty("requestEndpoint", out var value) ? value?.ToString() : null;

            if (!string.IsNullOrEmpty(opNum))
            {
                builder.Append(opNum);
            }
        }
    }
}
