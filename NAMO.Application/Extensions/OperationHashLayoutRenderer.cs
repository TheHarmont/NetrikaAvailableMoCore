using NAMO.Domain.Common;
using NLog;
using NLog.LayoutRenderers;
using System.Text;

namespace NAMO.Application.Extensions
{
    [LayoutRenderer("operationHash")]
    public class OperationHashLayoutRenderer : LayoutRenderer
    {
        protected override void Append(StringBuilder builder, LogEventInfo logEvent)
        {
            var opNum = ScopeContext.TryGetProperty("OperationHash", out var value) ? value?.ToString() : null;

            if (!string.IsNullOrEmpty(opNum))
            {
                builder.Append(opNum);
            }
        }
    }
}
