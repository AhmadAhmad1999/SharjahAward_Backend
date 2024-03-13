using MediatR;
using SharijhaAward.Application.Responses;
namespace SharijhaAward.Application.Features.CriterionFeatures.Queries.GetAllCriterionByCategoryId
{
    public class GetAllCriterionByCategoryIdQuery : IRequest<BaseResponse<List<MainCriterionListVM>>>
    {
        public Guid CategoryId { get; set; }
        public int ProvidedFormId { get; set; }
        public string lang { get; set; } = string.Empty;
    }
}
