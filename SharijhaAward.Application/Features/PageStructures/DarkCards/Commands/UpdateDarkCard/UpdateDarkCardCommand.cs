using MediatR;
using SharijhaAward.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.PageStructures.DarkCards.Commands.UpdateDarkCard
{
    public class UpdateDarkCardCommand : IRequest<BaseResponse<object>>
    {
        public int Id {  get; set; }
        public int orderId { get; set; }
        public string EnglishTitle { get; set; } = string.Empty;
        public string ArabicTitle { get; set; } = string.Empty;
        public string EnglishContent { get; set; } = string.Empty;
        public string ArabicContent { get; set; } = string.Empty;
        public int PageId { get; set; }
        public string? lang { get; set; }
    }
}
