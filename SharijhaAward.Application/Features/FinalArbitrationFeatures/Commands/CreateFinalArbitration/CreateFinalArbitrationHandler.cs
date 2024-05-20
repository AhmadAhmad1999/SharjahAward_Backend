using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.FinalArbitrationModel;

namespace SharijhaAward.Application.Features.FinalArbitrationFeatures.Commands.CreateFinalArbitration
{
    public class CreateFinalArbitrationHandler : IRequestHandler<CreateFinalArbitrationCommand, BaseResponse<object>>
    {
        private readonly IMapper _Mapper;
        private readonly IAsyncRepository<FinalArbitration> _FinalArbitrationRepository;
        private readonly IJwtProvider _JWTProvider;

        public CreateFinalArbitrationHandler(IMapper Mapper,
            IAsyncRepository<FinalArbitration> FinalArbitrationRepository,
            IJwtProvider JWTProvider)
        {
            _Mapper = Mapper;
            _FinalArbitrationRepository = FinalArbitrationRepository;
            _JWTProvider = JWTProvider;
        }

        public async Task<BaseResponse<object>> Handle(CreateFinalArbitrationCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            int UserId = int.Parse(_JWTProvider.GetUserIdFromToken(Request.Token!));

            FinalArbitration NewFinalArbitrationEntity = _Mapper.Map<FinalArbitration>(Request);

            NewFinalArbitrationEntity.ArbitratorId = UserId;

            await _FinalArbitrationRepository.AddAsync(NewFinalArbitrationEntity);

            ResponseMessage = Request.lang == "en"
                ? "Created successfully"
                : "تم منح النتيجة النهائية بنجاح";

            return new BaseResponse<object>(ResponseMessage, true, 200);
        }
    }
}
