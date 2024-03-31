using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.EducationalEntities.Queries.GetAllEducationalEntities
{
    public class GetAllEducationalEntitiesCommand :IRequest<BaseResponse<List<EducationalEntitiesListVm>>>
    {
        public string? ArabicName { get; set; } = string.Empty;
        public string? EnglishName { get; set; } = string.Empty;
        public string? lang { get; set; }
    }
}
