using MediatR;
using SharijhaAward.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.PageStructures.ImageCards.Queries.GetAllImageCards
{
    public class GetAllImageCardsQuery : IRequest<BaseResponse<List<ImageCardListVM>>>
    {
        public int? pageId { get; set; }
        public int page { get; set; }
        public int perPage { get; set; }
    }
}
