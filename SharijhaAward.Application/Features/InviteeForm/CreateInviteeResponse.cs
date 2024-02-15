using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.InviteeForm
{
    public class CreateInviteeResponse
    {
        public string Name { get; set; } = string.Empty;
        public string EventName { get; set; } = string.Empty;
        public string EventSiteName { get; set; } = string.Empty;
        public string EventDayName { get; set; } = string.Empty;
        public string EventDate { get; set; } = string.Empty;
        public string EventTime { get; set; } = string.Empty;
        public string ImageURl { get; set; } = string.Empty;
        public string DownLoadURL { get; set; } = string.Empty;
        public string DownloadFileURL { get; set; } = string.Empty;
    }
}
