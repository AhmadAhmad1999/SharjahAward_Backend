using MediatR;
using SharijhaAward.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.PageStructures.DarkCards.Queries.GetDarkCardById
{
    public class GetDarkCardByIdQuery : IRequest<BaseResponse<DarkCardDto>>
    {
        public int Id {  get; set; }
        public string? lang { get; set; }

    }
}
