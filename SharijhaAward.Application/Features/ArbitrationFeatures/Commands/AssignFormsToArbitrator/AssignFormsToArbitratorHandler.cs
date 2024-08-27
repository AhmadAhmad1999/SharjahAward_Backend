using MediatR;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.ArbitrationModel;

namespace SharijhaAward.Application.Features.ArbitrationFeatures.Commands.AssignFormsToArbitrator
{
    public class AssignFormsToArbitratorHandler : IRequestHandler<AssignFormsToArbitratorCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<Arbitration> _ArbitrationRepository;
        private readonly IJwtProvider _JwtProviderRepository;

        public AssignFormsToArbitratorHandler(IAsyncRepository<Arbitration> ArbitrationRepository,
            IJwtProvider JwtProviderRepository)
        {
            _ArbitrationRepository = ArbitrationRepository;
            _JwtProviderRepository = JwtProviderRepository;
        }

        public async Task<BaseResponse<object>> Handle(AssignFormsToArbitratorCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            int UserId = int.Parse(_JwtProviderRepository.GetUserIdFromToken(Request.Token!));

            List<Arbitration> NewArbitrationEntities = Request.FormsIds
                .Select(x => new Arbitration()
                {
                    ArbitratorId = Request.ArbitratorId,
                    isAccepted = FormStatus.NotArbitratedYet,
                    ProvidedFormId = x,
                    isAcceptedFromChairman = FormStatus.NotArbitratedYet,
                    AssignedByUserId = UserId
                }).ToList();

            await _ArbitrationRepository.AddRangeAsync(NewArbitrationEntities);

            ResponseMessage = Request.lang == "en"
                ? "Created successfully"
                : "تم إنشاء الارتباط بين المحكم و الاستمارات بنجاح";

            return new BaseResponse<object>(ResponseMessage, true, 200);
        }
    }
}
