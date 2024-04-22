using MediatR;
using SharijhaAward.Application.Features.CycleConditions.Queries.GetAllCycleConditions;
using SharijhaAward.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.CycleConditions.Attachments.Queries.ReviewCycleConditionAttachments
{
    public class ReviewCycleConditionAttachmentsQuery : IRequest<BaseResponse<List<CycleConditionListVM>>>
    {
        public int formId {  get; set; }
        public string token {  get; set; } = string.Empty;
        public string? lang {  get; set; }
    }
}
