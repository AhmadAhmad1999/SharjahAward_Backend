using MediatR;
using SharijhaAward.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.PageStructures.TextCards.Queries.GetTextCardById
{
    public class GetTextCardByIdQuery : IRequest<BaseResponse<TextCardDto>>
    {
        public int Id { get; set; }
        public string? lang { get; set; }
    }
}
