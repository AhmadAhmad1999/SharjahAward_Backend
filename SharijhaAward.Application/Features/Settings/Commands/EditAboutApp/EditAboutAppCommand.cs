using MediatR;
using SharijhaAward.Application.Responses;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.Settings.Commands.EditAboutApp
{
    public class EditAboutAppCommand : IRequest<BaseResponse<object>>
    {
        public string Slug { get; set; } = string.Empty;
        [MaxLength]
        public string? ArabicText { get; set; }
        [MaxLength]
        public string? EnglishText { get; set; }

        public string? lang { get; set; }
    }
}
