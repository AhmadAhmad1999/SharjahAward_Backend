using MediatR;
using Microsoft.AspNetCore.Http;
using SharijhaAward.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.GeneralWorkshops.Commands.CreateGeneralWorkshop
{
    public class CreateGeneralWorkshopCommand : IRequest<BaseResponse<int>>
    {
        public string ArabicTitle { get; set; } = string.Empty;
        public string EnglishTitle { get; set; } = string.Empty;
        public string EnglishDescription { get; set; } = string.Empty;
        public string ArabicDescription { get; set; } = string.Empty;
        public IFormFile Thumbnale { get; set; } = null!;
        public DateTime DateOfWorkShop { get; set; }
        public string Time { get; set; } = string.Empty;
        public IFormFile? Video { get; set; }
        public string? RegistrationUrl { get; set; } = string.Empty;
        public IFormFile? AgendaImage { get; set; } = null!;
        public string lang { get; set; } = string.Empty;
    }
}
