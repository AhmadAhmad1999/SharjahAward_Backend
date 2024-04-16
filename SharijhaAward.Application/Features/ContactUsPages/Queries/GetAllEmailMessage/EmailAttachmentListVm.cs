using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.ContactUsPages.Queries.GetAllEmailMessage
{
    public class EmailAttachmentListVm
    {
        public int Id { get; set; }
        public string AttachmentUrl { get; set; } = string.Empty;
        public int MessageId { get; set; }
    }
}
