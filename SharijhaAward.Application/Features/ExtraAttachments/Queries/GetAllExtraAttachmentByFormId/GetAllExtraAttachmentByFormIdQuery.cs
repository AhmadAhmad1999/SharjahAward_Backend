using MediatR;
using SharijhaAward.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.ExtraAttachments.Queries.GetAllExtraAttachment
{
    public class GetAllExtraAttachmentByFormIdQuery : IRequest<BaseResponse<List<ExtraAttachmentListVM>>>
    {
        public int formId { get; set; }
        public string lang { get; set; } = string.Empty;
    }
}
