using MediatR;
using SharijhaAward.Application.Features.PageStructures.ParagraphCards.Queries.GetAllParagraphCardsByPageId;
using SharijhaAward.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.PageStructures.ParagraphCards.Queries.GetAllParagraphCardsDashborad
{
    public class GetAllParagraphCardsDashboradQuery
        : IRequest<BaseResponse<List<ParagraphCardListVM>>>
    {
        public int PageId { get; set; }
        public string? lang { get; set; }
    }
}
