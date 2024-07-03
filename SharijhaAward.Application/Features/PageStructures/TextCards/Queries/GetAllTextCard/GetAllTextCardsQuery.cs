using MediatR;
using SharijhaAward.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.PageStructures.TextCards.Queries.GetAllTextCard
{
    public class GetAllTextCardsQuery : IRequest<BaseResponse<List<TextCardListVM>>>
    {
        public int? pageId { get; set; }
        public int page { get; set; } = 1;
        public int perPage { get; set; } = 10;
    }
}
