using MediatR;
using SharijhaAward.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.EducationalEntities.Command.CreateEducationalEntity
{
    public class CreateEducationalEntityCommand : IRequest<BaseResponse<Guid>>
    {
        public string ArabicName { get; set; } = string.Empty;
        public string EnglishName { get; set; } = string.Empty;
        public string lang { get; set; } = string.Empty;
    }
}
