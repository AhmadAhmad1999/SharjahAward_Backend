using MediatR;
using SharijhaAward.Application.Features.TermsAndConditions.Queries.GetAllTermAndCondition;
using SharijhaAward.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.TermsAndConditions.Attacments.Queries.ReviewSpecialConditionAttachments
{
    public class ReviewSpecialConditionAttachmentsQuery
        : IRequest<BaseResponse<List<SpecialTermAndConditionListVM>>>
    {
        public string lang { get; set; } = string.Empty;
        public string token { get; set; } = string.Empty;
        public int formId { get; set; }
    }
}
