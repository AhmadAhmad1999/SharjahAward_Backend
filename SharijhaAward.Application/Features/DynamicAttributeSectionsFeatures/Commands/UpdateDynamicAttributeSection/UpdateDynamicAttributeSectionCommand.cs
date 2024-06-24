using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.DynamicAttributeSectionsFeatures.Commands.UpdateDynamicAttributeSection
{
    public class UpdateDynamicAttributeSectionCommand : IRequest<BaseResponse<object>>
    {
        public int Id { get; set; }
        public string ArabicName { get; set; } = null!;
        public string EnglishName { get; set; } = null!;
        public int? MinNumberOfRows { get; set; }
        public int? MaxNumberOfRows { get; set; }
        public string? lang { get; set; }
    }
}
