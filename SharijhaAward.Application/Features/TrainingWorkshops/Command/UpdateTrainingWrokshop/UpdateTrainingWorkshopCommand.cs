using MediatR;
using Microsoft.AspNetCore.Http;
using SharijhaAward.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.TrainingWorkshops.Command.UpdateTrainingWrokshop
{
    public class UpdateTrainingWorkshopCommand : IRequest<BaseResponse<object>>
    {
        public Guid Id { get; set; }
        public string ArabicTitle { get; set; } = string.Empty;
        public string EnglishTitle { get; set; } = string.Empty;
        public IFormFile? Thumbnail { get; set; } = null!;
        public bool EditeOnThumbnail {  get; set; }
        public Guid CategoryId { get; set; }
        public string lang { get; set; } = string.Empty;
    }
}
