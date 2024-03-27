using MediatR;
using SharijhaAward.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.AboutAwardPages.Commands.UpdateGoal
{
    public class UpdateGoalCommand :IRequest<BaseResponse<object>>
    {
        public Guid Id { get; set; }
        public string ArabicGoal { get; set; } = string.Empty;
        public string EnglishGoal { get; set; } = string.Empty;
        public string lang {  get; set; } = string.Empty;
    }
}
