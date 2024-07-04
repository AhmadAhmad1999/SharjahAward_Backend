using MediatR;
using SharijhaAward.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.PageStructures.ImageCards.Queries.GetImageCardById
{
    public class GetImageCardByIdQuery : IRequest<BaseResponse<ImageCardDto>>
    {
        public int Id { get; set; }
        public string? lang { get; set; }
    }
}
