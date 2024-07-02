using MediatR;
using Microsoft.AspNetCore.Http;
using SharijhaAward.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.PageStructures.ImageCards.Commands.CreateImageCard
{
    public class CreateImageCardCommand : IRequest<BaseResponse<object>>
    {
        public int orderId { get; set; }
        public List<IFormFile> Images { get; set; } = null!;
    }
}
