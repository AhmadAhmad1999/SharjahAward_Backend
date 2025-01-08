using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.ArbitrationModel;
using SharijhaAward.Domain.Entities.ArbitrationResultModel;
using SharijhaAward.Domain.Entities.CycleModel;

namespace SharijhaAward.Application.Features.ArbitrationFeatures.Commands.AssignFormsToArbitrator
{
    public class AssignFormsToArbitratorHandler : IRequestHandler<AssignFormsToArbitratorCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<Arbitration> _ArbitrationRepository;
        private readonly IAsyncRepository<Cycle> _CycleRepository;
        private readonly IJwtProvider _JwtProviderRepository;
        private readonly IAsyncRepository<ArbitrationResult> _ArbitrationResultRepository;

        public AssignFormsToArbitratorHandler(IAsyncRepository<Arbitration> _ArbitrationRepository,
            IAsyncRepository<Cycle> _CycleRepository,
            IJwtProvider _JwtProviderRepository,
            IAsyncRepository<ArbitrationResult> _ArbitrationResultRepository)
        {
            this._ArbitrationRepository = _ArbitrationRepository;
            this._CycleRepository = _CycleRepository;
            this._JwtProviderRepository = _JwtProviderRepository;
            this._ArbitrationResultRepository = _ArbitrationResultRepository;
        }

        public async Task<BaseResponse<object>> Handle(AssignFormsToArbitratorCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            List<Arbitration> CheckArbitration = await _ArbitrationRepository
                .Where(x => x.ProvidedFormId == Request.FormsIds.FirstOrDefault())
                .ToListAsync();

            int UserId = int.Parse(_JwtProviderRepository.GetUserIdFromToken(Request.Token!));

            Cycle? CheckIfThereIsActiveCycle = await _CycleRepository
                .FirstOrDefaultAsync(x => x.Status == Domain.Constants.Common.Status.Active);

            if (CheckIfThereIsActiveCycle is null)
                return new BaseResponse<object>(ResponseMessage, false, 200);

            int ActiveCycleId = CheckIfThereIsActiveCycle.Id;

            if (CheckArbitration.TrueForAll(x => x.isAcceptedFromChairman == FormStatus.Accepted &&
                x.ArbitratorId != UserId &&
                x.ProvidedForm!.Category!.CycleId == ActiveCycleId &&
                x.Type == ArbitrationType.DoneArbitratod))
            {
                ResponseMessage = Request.lang == "en"
                    ? "You can't assign a new arbitrator to this form because it's already reached the arbitration audting step"
                    : "لا يمكنك تعيين محكم جديد لهذه الاستمارة لأنها قد وصلت مسبقاً إلى مرحلة تدقيق التحكيم";

                return new BaseResponse<object>(ResponseMessage, true, 400);
            }

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

            ArbitrationResult? ArbitrationResultEntity = await _ArbitrationResultRepository
                .FirstOrDefaultAsync(x => Request.FormsIds.Contains(x.ProvidedFormId));

            if (ArbitrationResultEntity is null)
            {
                ArbitrationResult NewArbitrationResultEntity = new ArbitrationResult()
                {
                    ProvidedFormId = Request.FormsIds.FirstOrDefault(),
                    EligibleForCertification = false,
                    EligibleForAStatement = false,
                    EligibleToWin = false,
                    GotCertification = false,
                    GotStatement1 = false,
                    GotStatement2 = false,
                    Winner = false,
                    FinalArbitrationId = null
                };

                await _ArbitrationResultRepository.AddAsync(NewArbitrationResultEntity);
            }

            ResponseMessage = Request.lang == "en"
                ? "Created successfully"
                : "تم إنشاء الارتباط بين المحكم و الاستمارة بنجاح";

            return new BaseResponse<object>(ResponseMessage, true, 200);
        }
    }
}
