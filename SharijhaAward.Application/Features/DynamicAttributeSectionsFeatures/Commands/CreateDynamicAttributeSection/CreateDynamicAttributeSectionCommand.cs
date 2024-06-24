using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.DynamicAttributeSectionsFeatures.Commands.CreateDynamicAttributeSection
{
    public class CreateDynamicAttributeSectionCommand : IRequest<BaseResponse<CreateDynamicAttributeSectionResponse>>
    {
        public string ArabicName { get; set; } = null!;
        public string EnglishName { get; set; } = null!;
        public int AttributeTableNameId { get; set; }
        public int? RecordIdOnRelation { get; set; }
        public bool TableTypeSection { get; set; }
        public int? MinNumberOfRows { get; set; }
        public int? MaxNumberOfRows { get; set; }
        public string? lang { get; set; }
    }
}
