using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.Settings.Queries.GetProfileById
{
    public class GetProfileByIdHandler : IRequestHandler<GetProfileByIdQuery, BaseResponse<GetProfileByIdDto>>
    {
        private readonly IAsyncRepository<Domain.Entities.SubscriberModel.Subscriber> _SubscriberRepository;
        private readonly IMapper _Mapper;

        public GetProfileByIdHandler(IMapper Mapper,
            IAsyncRepository<Domain.Entities.SubscriberModel.Subscriber> SubscriberRepository)
        {
            _SubscriberRepository = SubscriberRepository;
            _Mapper = Mapper;
        }
        public async Task<BaseResponse<GetProfileByIdDto>> Handle(GetProfileByIdQuery Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            Domain.Entities.SubscriberModel.Subscriber? SubscriberEntity = await _SubscriberRepository
                .FirstOrDefaultAsync(x => x.Id == Request.Id);

            if (SubscriberEntity == null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Profile is not found"
                    : "الملف الشخصي غير موجود";

                return new BaseResponse<GetProfileByIdDto>(ResponseMessage, false, 404);
            }

            GetProfileByIdDto GeneralFAQDto = _Mapper.Map<GetProfileByIdDto>(SubscriberEntity);

            return new BaseResponse<GetProfileByIdDto>(ResponseMessage, true, 200, GeneralFAQDto);
        }
    }
}
