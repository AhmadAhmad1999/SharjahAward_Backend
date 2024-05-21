using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.ProvidedForm.Queries.GetAllCriterionsForCoordinator
{
    public class GetAllCriterionsForCoordinatorQuery : IRequest<BaseResponse<List<GetAllCriterionsForCoordinatorListVM>>>
    {
        public int FormId { get; set; }
        public string? lang { get; set; }
    }
}
