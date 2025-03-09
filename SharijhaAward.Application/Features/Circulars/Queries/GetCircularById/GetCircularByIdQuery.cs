using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.Circulars.Queries.GetCircularById
{
    public class GetCircularByIdQuery : IRequest<BaseResponse<CircularDto>>
    {
        public int Id {  get; set; }
        public string? token { get; set; }
        public string? lang {  get; set; }
        public bool View { get; set; }
    }
}
