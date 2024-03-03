using MediatR;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Constants.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.Cycles.Commands.CreateCycle
{
    public class CreateCycleCommand : IRequest<BaseResponse<object>>
    {
        public string Year { get; set; } = string.Empty;
        public string ArabicName { get; set; } = string.Empty;
        public string EnglishName { get; set; } = string.Empty;
        public Status Status { get; set; } = Status.InActive;
        public DateTime RegistrationPortalOpeningDate { get; set; }
        public DateTime RegistrationPortalClosingDate { get; set; }
        public int IndividualCategoryNumber { get; set; } = 0;
        public int GroupCategoryNumber { get; set; } = 0;
        public string lang {  get; set; } = string.Empty;
    }
}
