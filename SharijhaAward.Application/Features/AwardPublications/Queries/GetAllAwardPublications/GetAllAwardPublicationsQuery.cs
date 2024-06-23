using MediatR;
using SharijhaAward.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.AwardPublications.Queries.GetAllAwardPublications
{
    public class GetAllAwardPublicationsQuery : IRequest<BaseResponse<List<AwardPublicationListVM>>>
    {
        public int page { get; set; }
        public int perPage { get; set; }
        public string? lang { get; set; }
    }
}
