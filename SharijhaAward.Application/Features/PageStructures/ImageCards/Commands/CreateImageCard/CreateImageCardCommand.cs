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
        public int PageId { get; set; }
        public bool IsHide { get; set; }
        public string? lang { get; set; }
        public List<IFormFile> CardImages { get; set; } = null!;
    }
}
