using MediatR;
using Microsoft.AspNetCore.Http;
using SharijhaAward.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.ReferenceSources.Commands.UpdateReferenceSourcePage
{
    public class UpdateReferenceSourcePageCommand : IRequest<BaseResponse<object>>
    {
        public string Title { get; set; } = string.Empty;
        public string Sources { get; set; } = string.Empty;
        public bool UpdateOnImage { get; set; }
        public IFormFile? Image { get; set; } 
        public string? lang {  get; set; }
    }
}
