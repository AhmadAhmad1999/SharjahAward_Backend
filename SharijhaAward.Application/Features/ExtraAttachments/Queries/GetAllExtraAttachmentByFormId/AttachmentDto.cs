using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.ExtraAttachments.Queries.GetAllExtraAttachmentByFormId
{
    public class AttachmentDto
    {
        public int Id { get; set; }
        public string FileUrl { get; set; } = string.Empty;
        public bool IsAccept { get; set; }
        public string ReasonOfReject { get; set; } = string.Empty;
    }
}
