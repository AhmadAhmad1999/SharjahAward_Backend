using MediatR;
using Microsoft.AspNetCore.Http;
using SharijhaAward.Application.Features.TrainingWorkshops.Attacments.Commands.UpdateWorkshopAttachment;
using SharijhaAward.Application.Features.TrainingWorkshops.Command.CreateTrainingWorkshop;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.TrainingWorkshops.Command.UpdateTrainingWrokshop
{
    public class UpdateTrainingWorkshopCommand : IRequest<BaseResponse<object>>
    {
        public int Id { get; set; }
        public string ArabicTitle { get; set; } = string.Empty;
        public string EnglishTitle { get; set; } = string.Empty;
        public IFormFile? Thumbnail { get; set; } = null!;
        public bool EditeOnThumbnail { get; set; }
        public int CategoryId { get; set; }
        public List<int> TrainingWorkshopAttachmentsToDelete { get; set; } = new List<int>();
        public List<UpdateWorkshopAttachmentCommand> TrainingWorkshopAttachmentsToUpdate { get; set; } = new List<UpdateWorkshopAttachmentCommand>();
        public List<CreateTrainingWorkshopAttachmentsDto> TrainingWorkshopAttachmentsToAdd { get; set; } = new List<CreateTrainingWorkshopAttachmentsDto>();
        public string lang { get; set; } = string.Empty;
    }
}
