using MediatR;
using Microsoft.AspNetCore.Http;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.CycleModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.News.Commands.CreateNews
{
    public class CreateNewsCommand : IRequest<BaseResponse<object>>
    {
        public string lang { get; set; } = string.Empty;
        public string ArabicTitle { get; set; } = string.Empty;
        public string EnglishTitle { get; set; } = string.Empty;
        public string? ArabicDescription { get; set; }
        public string? EnglishDescription { get; set; }
        public IFormFile? Image { get; set; }
        public int CycleId { get; set; }
    }
}
