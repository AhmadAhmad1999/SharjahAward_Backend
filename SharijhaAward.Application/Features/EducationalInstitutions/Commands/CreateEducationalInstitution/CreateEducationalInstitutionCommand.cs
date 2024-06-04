using MediatR;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Constants;

namespace SharijhaAward.Application.Features.EducationalInstitutions.Commands.CreateEducationalInstitution
{
    public class CreateEducationalInstitutionCommand 
    {
        public string EnglishName { get; set; } = string.Empty;
        public string ArabicName { get; set; } = string.Empty;
        public EducationType EducationType { get; set; }
        public Emirates Emirates { get; set; }
    }
}
