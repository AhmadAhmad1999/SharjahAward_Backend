using MediatR;
using SharijhaAward.Application.Helpers.ArabicNameValidationAttributeHelper;
using SharijhaAward.Application.Helpers.EnglishNameValidationAttributeHelper;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.EducationalEntities.Command.CreateEducationalEntity
{
    public class CreateEducationalEntityCommand : IRequest<BaseResponse<int>>
    {
        [ArabicNameValidation]
        public string ArabicName { get; set; } = null!;
        [EnglishNameValidation]
        public string EnglishName { get; set; } = null!;
        public int CycleId { get; set; }
        public string? lang { get; set; }
    }
}
