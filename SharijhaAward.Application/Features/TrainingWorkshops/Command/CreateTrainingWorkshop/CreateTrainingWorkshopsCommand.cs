using MediatR;
using Microsoft.AspNetCore.Http;
using SharijhaAward.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.TrainingWorkshops.Command.CreateTrainingWorkshop
{
    public class CreateTrainingWorkshopsCommand : IRequest<BaseResponse<Guid>>
    {
        public string ArabicTitle { get; set; } = string.Empty;
        public string EnglishTitle { get; set; } = string.Empty;
        public string Thumbnail { get; set; } = string.Empty;
        public Guid CategoryId { get; set; }
    }
}
