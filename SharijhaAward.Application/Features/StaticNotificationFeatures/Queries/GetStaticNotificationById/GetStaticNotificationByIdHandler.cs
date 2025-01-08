using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.StaticNotificationModel;

namespace SharijhaAward.Application.Features.StaticNotificationFeatures.Queries.GetStaticNotificationById
{
    public class GetStaticNotificationByIdHandler : IRequestHandler<GetStaticNotificationByIdQuery, BaseResponse<GetStaticNotificationByIdDto>>
    {
        private readonly IAsyncRepository<StaticNotification> _StaticNotificationRepository;
        private readonly IMapper _Mapper;
        public GetStaticNotificationByIdHandler(IAsyncRepository<StaticNotification> StaticNotificationRepository,
            IMapper Mapper)
        {
            _StaticNotificationRepository = StaticNotificationRepository;
            _Mapper = Mapper;
        }
        public async Task<BaseResponse<GetStaticNotificationByIdDto>> Handle(GetStaticNotificationByIdQuery Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            StaticNotification? StaticNotificationEntity = await _StaticNotificationRepository
                .FirstOrDefaultAsync(x => x.Id == Request.Id);

            if (StaticNotificationEntity == null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Static notification is not found"
                    : "الإشعار غير موجود";

                return new BaseResponse<GetStaticNotificationByIdDto>(ResponseMessage, false, 404);
            }

            GetStaticNotificationByIdDto GetStaticNotificationByIdDto = _Mapper.Map<GetStaticNotificationByIdDto>(StaticNotificationEntity);

            return new BaseResponse<GetStaticNotificationByIdDto>(ResponseMessage, true, 200, GetStaticNotificationByIdDto);
        }
    }
}
