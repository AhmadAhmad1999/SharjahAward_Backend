using MediatR;
using Microsoft.AspNetCore.Http;
using SharijhaAward.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.HomePageSliderItems.Commands.CreateHomePageSliderItem
{
    public class CreateHomePageSliderItemCommand : IRequest<BaseResponse<object>>
    {
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public IFormFile Image { get; set; } = null!;
        public string? lang { get; set; }
    }
}
