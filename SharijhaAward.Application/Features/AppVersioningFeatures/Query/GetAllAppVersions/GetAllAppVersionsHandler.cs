using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Common;
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
            FilterObject filterObject = new FilterObject() { Filters = Request.filters };

            string ResponseMessage = string.Empty;

            var AllAppVersions = Request.AppType == null
                ? await _AppVersionRepository.OrderByDescending(filterObject, x => x.CreatedAt, Request.page, Request.perPage).ToListAsync()
                : await _AppVersionRepository.OrderByDescending(filterObject, x => x.CreatedAt, Request.page,Request.perPage).Where(x=>x.AppType == Request.AppType).ToListAsync();
                
            var data = _Mapper.Map<List<GetAllAppVersionsListVM>>(AllAppVersions);

            int TotalCount = Request.AppType == null
                ? _AppVersionRepository.WhereThenFilter(a=>true, filterObject).Count()
                : _AppVersionRepository.WhereThenFilter(a => a.AppType == Request.AppType, filterObject).Count();

            Pagination PaginationParameter = new Pagination(Request.page,
                Request.perPage, TotalCount);

            return new BaseResponse<List<GetAllAppVersionsListVM>>(ResponseMessage, true, 200, data, PaginationParameter);
        }
    }
}
