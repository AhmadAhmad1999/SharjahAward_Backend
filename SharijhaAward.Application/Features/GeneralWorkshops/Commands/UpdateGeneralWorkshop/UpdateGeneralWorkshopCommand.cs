using MediatR;
using Microsoft.AspNetCore.Http;
using SharijhaAward.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.GeneralWorkshops.Commands.UpdateGeneralWorkshop
{
    public class UpdateGeneralWorkshopCommand : IRequest<BaseResponse<int>>
    {
        public int Id { get; set; }
        public string ArabicTitle { get; set; } = string.Empty;
        public string EnglishTitle { get; set; } = string.Empty;
        public string EnglishDescription { get; set; } = string.Empty;
        public string ArabicDescription { get; set; } = string.Empty;
        public IFormFile Thumbnale { get; set; } = null!;
        public bool UpdateThumbnale {  get; set; }
        public DateTime DateOfWorkShop { get; set; }
        public string Time { get; set; } = string.Empty;
        public IFormFile? Video { get; set; }
        public bool UpdateVideo { get; set; }
        public string? RegistrationUrl { get; set; } = string.Empty;
        public IFormFile? AgendaImage { get; set; } = null!;
        public bool UpdateAgendaImage { get; set; }
        public string lang { get; set; } = string.Empty;
    }
}
