using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.ArbitrationScalesFeatures.Queries.GetAllArbitrationScales
{
    public class GetAllArbitrationScalesQuery : IRequest<BaseResponse<GetAllArbitrationScalesListVM>>
    {
        public int SubCategoryId { get; set; }
        public string? lang { get; set; }
        public int page { get; set; }
        public int perPage { get; set; }
    }
}
