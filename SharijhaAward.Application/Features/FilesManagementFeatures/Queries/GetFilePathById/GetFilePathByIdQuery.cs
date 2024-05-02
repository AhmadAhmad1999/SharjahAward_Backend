using MediatR;
using SharijhaAward.Application.Features.FilesManagementFeatures.Queries.GetAllFilesByFilter;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.FilesManagementFeatures.Queries.GetFilePathById
{
    public class GetFilePathByIdQuery : IRequest<BaseResponse<GetFilePathByIdDto>>
    {
        public int Id { get; set; }
        public int FilterId { get; set; }
        public string? lang { get; set; }
    }
}
