using MediatR;
using Microsoft.AspNetCore.Http;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.TrainingWorkshops.Command.CreateTrainingWorkshop
{
    public class CreateTrainingWorkshopsCommand : IRequest<BaseResponse<int>>
    {
        public string ArabicTitle { get; set; } = string.Empty;
        public string EnglishTitle { get; set; } = string.Empty;
        public IFormFile Thumbnail { get; set; } = null!;
        public int CategoryId { get; set; }
        public string? lang { get; set; }
        public List<CreateTrainingWorkshopAttachmentsDto> TrainingWorkshopAttachments { get; set; } = new List<CreateTrainingWorkshopAttachmentsDto>();
    }
}
