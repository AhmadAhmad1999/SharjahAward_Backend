using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.AppVersioningModel;

namespace SharijhaAward.Application.Features.AppVersioningFeatures.Query.GetLastAppVersion
{
    public class GetLastAppVersionHandler : IRequestHandler<GetLastAppVersionQuery, BaseResponse<GetLastAppVersionDto>>
    {
        private readonly IAsyncRepository<AppVersion> _AppVersionRepository;
        private readonly IMapper _Mapper;
        public GetLastAppVersionHandler(IAsyncRepository<AppVersion> AppVersionRepository,
            IMapper Mapper)
        {
            _AppVersionRepository = AppVersionRepository;
            _Mapper = Mapper;
        }

        public async Task<BaseResponse<GetLastAppVersionDto>> Handle(GetLastAppVersionQuery Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            GetLastAppVersionDto LastAppVersion = _Mapper.Map<GetLastAppVersionDto>(await _AppVersionRepository
                .OrderBy(x => x.VersionNumber)
                .LastOrDefaultAsync());

            return new BaseResponse<GetLastAppVersionDto>(ResponseMessage, true, 200, LastAppVersion);
        }
    }
}
