using MediatR;
using Microsoft.AspNetCore.Http;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.PageStructureModels;

namespace SharijhaAward.Application.Features.PageStructures.ImageCards.Commands.UpdateImageCard
{
    public class UpdateImageCardCommand : IRequest<BaseResponse<object>>
    {
        public int Id { get; set; }
        public int orderId { get; set; }
        public bool IsHide { get; set; }
        public int PageId { get; set; }
        public string? lang { get; set; }
        public CardType CardType { get; set; }
        public List<IFormFile> CardImages { get; set; } = new List<IFormFile>();
        public List<int> DeletedCardImages { get; set; } = new List<int>();
    }
}
