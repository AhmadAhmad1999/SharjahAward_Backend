using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.AppVersioningModel;

namespace SharijhaAward.Application.Features.AppVersioningFeatures.Query.GetAllLastVersionsForAllTypes
{
    public class GetAllLastVersionsForAllTypesHandler 
        : IRequestHandler<GetAllLastVersionsForAllTypesQuery, BaseResponse<List<GetAllLastVersionsForAllTypesListVM>>>
    {
        private readonly IAsyncRepository<AppVersion> _AppVersionRepository;
        private readonly IMapper _Mapper;
        public GetAllLastVersionsForAllTypesHandler(IAsyncRepository<AppVersion> AppVersionRepository,
            IMapper Mapper)
        {
            _AppVersionRepository = AppVersionRepository;
            _Mapper = Mapper;
        }

        public async Task<BaseResponse<List<GetAllLastVersionsForAllTypesListVM>>> 
            Handle(GetAllLastVersionsForAllTypesQuery Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            List<GetAllLastVersionsForAllTypesListVM> LastAppVersion = 
                _Mapper.Map<List<GetAllLastVersionsForAllTypesListVM>>(_AppVersionRepository
                    .OrderByDescending(x => x.VersionNumber, 0, -1)
                    .AsEnumerable()
                    .DistinctBy(x => x.AppType)
                    .ToList());

            return new BaseResponse<List<GetAllLastVersionsForAllTypesListVM>>(ResponseMessage, true, 200, LastAppVersion);
        }
    }
}
