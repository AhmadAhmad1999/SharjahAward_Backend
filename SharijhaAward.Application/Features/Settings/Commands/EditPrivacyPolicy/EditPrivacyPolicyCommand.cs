using MediatR;
using SharijhaAward.Application.Responses;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.Settings.Commands.EditPrivacyPolicy
{
    public class EditPrivacyPolicyCommand : IRequest<BaseResponse<object>>
    {
        public int Id { get; set; }
        [MaxLength]
        public string ArabicText { get; set; } = null!;
        [MaxLength]
        public string EnglishText { get; set; } = null!;
        public string? lang { get; set; }
    }
}
