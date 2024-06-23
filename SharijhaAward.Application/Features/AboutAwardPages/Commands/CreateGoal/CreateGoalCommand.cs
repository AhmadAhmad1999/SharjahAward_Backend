using MediatR;
using SharijhaAward.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.AboutAwardPages.Commands.CreateGoal
{
    public class CreateGoalCommand :IRequest<BaseResponse<object>>
    {
        public string ArabicGoal { get; set; } = string.Empty;
        public string EnglishGoal { get; set; } = string.Empty;
        public bool IsHidden { get; set; }

    }
}
