using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.FilesManagementFeatures.Queries.GetFilePathById
{
    public class GetFilePathByIdQuery : IRequest<BaseResponse<GetFilePathByIdDto>>
    {
        public int Id { get; set; }
        public int? RowId { get; set; }
        public int FilterId { get; set; }
        public string? lang { get; set; }
    }
}
