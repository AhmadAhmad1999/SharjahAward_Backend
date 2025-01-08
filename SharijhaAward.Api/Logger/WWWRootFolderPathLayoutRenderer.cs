using NLog;
using NLog.LayoutRenderers;
using System.Text;

namespace SharijhaAward.Api.Logger
{
    [LayoutRenderer("WWWRootFolderPath")]
    public class WWWRootFolderPathLayoutRenderer : LayoutRenderer
    {
        private readonly IWebHostEnvironment _WebHostEnvironment;
        public WWWRootFolderPathLayoutRenderer(IWebHostEnvironment WebHostEnvironment)
        {
            _WebHostEnvironment = WebHostEnvironment;
        }
        protected override void Append(StringBuilder builder, LogEventInfo logEvent)
        {
            string wwwRootPath = _WebHostEnvironment.WebRootPath;
            builder.Append(wwwRootPath);
        }
    }
}
