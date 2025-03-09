using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.GeneralWorkshops.Queries.GetGeneralWorkshopById
{
    public class GetGeneralWorkshopByIdQuery : IRequest<BaseResponse<GeneralWorkshopDto>>
    {
        public int Id { get; set; }
        public string lang { get; set; } = string.Empty;
    }
}
