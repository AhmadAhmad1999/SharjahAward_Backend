using MediatR;
using Microsoft.AspNetCore.Http;
using SharijhaAward.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.News.Commands.UpdateNews
{
    public class UpdateNewsCommand : IRequest<BaseResponse<object>>
    {
        public int Id { get; set; }
        public IFormFile? Image { get; set; }
        public bool EditeOnImage { get; set; }
        public string ArabicTitle { get; set; } = string.Empty;
        public string EnglishTitle { get; set; } = string.Empty;
        public string? ArabicDescription { get; set; }
        public string? EnglishDescription { get; set; }
        public bool AddNewImages { get; set; }
        public List<IFormFile>? Images { get; set; }
        public bool IsHidden { get; set; }
        public int CycleId { get; set; }
        public string lang { get; set; } = string.Empty;
    }
}
