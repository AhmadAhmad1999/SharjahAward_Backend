using MediatR;
using SharijhaAward.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.CriterionFeatures.Commands.DeleteCriterionAttachment
{
    public class DeleteCriterionAttachmentCommand : IRequest<BaseResponse<object>>
    {
        public int CriterionAttachmentId { get; set; }
        public string lang { get; set; } = string.Empty;
    }
}
