using MediatR;
using SharijhaAward.Application.Features.TermsAndConditions.Queries.GetAllTermsByCategoryId;
using SharijhaAward.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.TermsAndConditions.Queries.GetFilesToApproveByFormId
{
    public class GetFilesToApproveByFormId : IRequest<BaseResponse<List<ConditionProvidedFormListVm>>>
    {
        public int formId {  get; set; }
        public Guid TermAndCondition {  get; set; }
    }
}
