using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.FilesManagementFeatures.Queries.GetAllFilesByFilter
{
    public class GetAllFilesByFilterQuery : IRequest<BaseResponse<List<GetAllFilesByFilterListVM>>>
    {
        public FilesFilter Filter { get; set; }
        public string? lang { get; set; }
        public int page { get; set; }
        public int pageSize { get; set; }
    }
}
