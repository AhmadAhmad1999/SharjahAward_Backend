using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.AppVersioningModel;

namespace SharijhaAward.Application.Features.AppVersioningFeatures.Query.GetAllAppVersions
{
    public class GetAllAppVersionsHandler : IRequestHandler<GetAllAppVersionsQuery, BaseResponse<List<GetAllAppVersionsListVM>>>
    {
        private readonly IAsyncRepository<AppVersion> _AppVersionRepository;
        private readonly IMapper _Mapper;
        public GetAllAppVersionsHandler(IAsyncRepository<AppVersion> AppVersionRepository,
            IMapper Mapper)
        {
            _AppVersionRepository = AppVersionRepository;
            _Mapper = Mapper;
        }

        public async Task<BaseResponse<List<GetAllAppVersionsListVM>>> 
            Handle(GetAllAppVersionsQuery Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            var AllAppVersions = Request.AppType == null
                ? await _AppVersionRepository.OrderByDescending(x => x.CreatedAt, Request.page, Request.perPage).ToListAsync()
                : await _AppVersionRepository.OrderByDescending(x => x.CreatedAt, Request.page,Request.perPage).Where(x=>x.AppType == Request.AppType).ToListAsync();
                
            var data = _Mapper.Map<List<GetAllAppVersionsListVM>>(AllAppVersions);

            int TotalCount = await _AppVersionRepository.GetCountAsync(null);

            Pagination PaginationParameter = new Pagination(Request.page,
                Request.perPage, TotalCount);

            return new BaseResponse<List<GetAllAppVersionsListVM>>(ResponseMessage, true, 200, data, PaginationParameter);
        }
    }
}
