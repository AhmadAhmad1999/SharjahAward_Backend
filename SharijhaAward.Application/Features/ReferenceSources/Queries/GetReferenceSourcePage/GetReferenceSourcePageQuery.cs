using MediatR;
using SharijhaAward.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.ReferenceSources.Queries.GetReferenceSourcePage
{
    public class GetReferenceSourcePageQuery 
        : IRequest<BaseResponse<ReferenceSourceDto>>
    {
        public string? lang {  get; set; }
    }
}
