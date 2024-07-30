using MediatR;
using SharijhaAward.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.PageStructures.ImageCards.Commands.UpdateImageCard
{
    public class UpdateImageCardCommand : IRequest<BaseResponse<object>>
    {
        public int Id { get; set; }
        public int orderId { get; set; }
        public bool IsHide { get; set; }
        public int PageId { get; set; }
        public string? lang { get; set; }
    }
}
