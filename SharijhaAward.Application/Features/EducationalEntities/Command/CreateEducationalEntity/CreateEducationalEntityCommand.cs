using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.EducationalEntities.Command.CreateEducationalEntity
{
    public class CreateEducationalEntityCommand : IRequest<BaseResponse<int>>
    {
        public string ArabicName { get; set; } = null!;
        public string EnglishName { get; set; } = null!;
        public List<CreateEducationalInstitutionDto> EducationalInstitutions { get; set; } = new List<CreateEducationalInstitutionDto>();
        public string? lang { get; set; }
    }
}
