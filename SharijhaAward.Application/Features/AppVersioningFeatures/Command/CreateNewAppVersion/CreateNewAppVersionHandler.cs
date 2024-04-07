using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.AppVersioningModel;

namespace SharijhaAward.Application.Features.AppVersioningFeatures.Command.CreateNewAppVersion
{
    public class CreateNewAppVersionHandler : IRequestHandler<CreateNewAppVersionCommand, BaseResponse<object>>
    {
        private readonly IMapper _Mapper;
        private readonly IAsyncRepository<AppVersion> _AppVersionRepository;

        public CreateNewAppVersionHandler(IMapper Mapper,
            IAsyncRepository<AppVersion> AppVersionRepository)
        {
            _Mapper = Mapper;
            _AppVersionRepository = AppVersionRepository;
        }
        public async Task<BaseResponse<object>> Handle(CreateNewAppVersionCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            AppVersion NewAppVersionEntity = _Mapper.Map<AppVersion>(Request);

            await _AppVersionRepository.AddAsync(NewAppVersionEntity);

            ResponseMessage = Request.lang == "en"
                ? "Created successfully"
                : "تم إنشاء النسخة بنجاح";

            return new BaseResponse<object>(ResponseMessage, true, 200);
        }
    }
}
