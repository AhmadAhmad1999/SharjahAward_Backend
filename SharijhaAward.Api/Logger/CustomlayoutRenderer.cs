using NLog;
using NLog.LayoutRenderers;
using System.Diagnostics;
using System.Text;

namespace SharijhaAward.Api.Logger
{
    [LayoutRenderer("Custom-Layout")]
    public class CustomlayoutRenderer : LayoutRenderer
    {
        protected override void Append(StringBuilder builder, LogEventInfo logEvent)
        {
            // 1. Date Time.. 
            // Done in NLog.config File..

            // 2. Activity Id..
            Guid ActivityId = Trace.CorrelationManager.ActivityId;
            if (ActivityId != null && ActivityId != Guid.Empty)
                builder.Append($"ActivityId: {ActivityId} | ");

            // 3. User Name.. 
            string UserName = Environment.UserName;
            if (!string.IsNullOrEmpty(UserName))
                builder.Append($"UserName: {UserName}");
            else
                builder.Append(" | UserName: Null");

            // 4. Message
            // Done in NLog.config File

            // 5. Log Level
            // Done in NLog.config File

        }
    }
}
