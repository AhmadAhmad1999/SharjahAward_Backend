using MediatR;
using SharijhaAward.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.PageStructures.TextCards.Commands.UpdateTextCard
{
    public class UpdateTextCardCommand : IRequest<BaseResponse<object>>
    {
        public int Id { get; set; }
        public string EnglishContent { get; set; } = string.Empty;
        public string ArabicContent { get; set; } = string.Empty;
        public int orderId { get; set; }
        public bool IsHide { get; set; }
        public int PageStructureId { get; set; }
        public string? lang { get; set; }
    }
}
