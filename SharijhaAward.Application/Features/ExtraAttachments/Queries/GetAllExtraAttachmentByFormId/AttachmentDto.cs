using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.ExtraAttachments.Queries.GetAllExtraAttachmentByFormId
{
    public class AttachmentDto
    {
        public Guid Id { get; set; }
        public string FileUrl { get; set; } = string.Empty;
    }
}
