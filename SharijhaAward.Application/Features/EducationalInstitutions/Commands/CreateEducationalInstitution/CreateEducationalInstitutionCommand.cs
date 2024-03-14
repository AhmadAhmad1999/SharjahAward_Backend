using MediatR;
using SharijhaAward.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.EducationalInstitutions.Commands.CreateEducationalInstitution
{
    public class CreateEducationalInstitutionCommand :IRequest<BaseResponse<Guid>>
    {
        public string EnglishName { get; set; } = string.Empty;
        public string ArabicName { get; set; } = string.Empty;
        public Guid EducationalEntityId { get; set; }
        public string lang { get; set; }= string.Empty;
    }
}
