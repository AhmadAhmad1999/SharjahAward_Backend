using MediatR;
using SharijhaAward.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.TermsAndConditions.Queries.GetTermAndConditionById
{
    public class GetTermAndConditionByIdQuery : IRequest<BaseResponse<TermAndConditionDto>>
    {
        public string lang { get; set; } = string.Empty;
        public int Id { get; set; }
    }
}
