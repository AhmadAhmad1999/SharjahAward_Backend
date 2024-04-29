using MediatR;
using SharijhaAward.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.PageStructures.ParagraphCards.Queries.GetParagraphCardById
{
    public class GetParagraphCardByIdQuery : IRequest<BaseResponse<ParagraphCardDto>>
    {
        public int Id {  get; set; }
        public string? lang {  get; set; }
    }
}
