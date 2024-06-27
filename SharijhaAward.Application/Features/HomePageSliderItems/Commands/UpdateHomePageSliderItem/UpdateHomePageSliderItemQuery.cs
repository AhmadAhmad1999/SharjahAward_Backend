using MediatR;
using Microsoft.AspNetCore.Http;
using SharijhaAward.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.HomePageSliderItems.Commands.UpdateHomePageSliderItem
{
    public class UpdateHomePageSliderItemQuery : IRequest<BaseResponse<object>>
    {
        public int Id {  get; set; }
        public string ArabicTitle { get; set; } = string.Empty;
        public string EnglishTitle { get; set; } = string.Empty;
        public string ArabicDescription { get; set; } = string.Empty;
        public string EngishDescription { get; set; } = string.Empty;
        public bool EditOnImage {  get; set; }
        public IFormFile Image { get; set; } = null!;
        public string? lang { get; set; }

    }
}
