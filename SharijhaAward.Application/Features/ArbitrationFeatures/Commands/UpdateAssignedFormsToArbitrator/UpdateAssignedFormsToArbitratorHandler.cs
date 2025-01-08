using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.ArbitrationModel;
using SharijhaAward.Domain.Entities.ArbitrationResultModel;
using SharijhaAward.Domain.Entities.ArbitratorModel;
using SharijhaAward.Domain.Entities.CycleModel;
using System.Transactions;

namespace SharijhaAward.Application.Features.ArbitrationFeatures.Commands.UpdateAssignedFormsToArbitrator
{
    public class UpdateAssignedFormsToArbitratorHandler
        : IRequestHandler<UpdateAssignedFormsToArbitratorCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<Arbitrator> _ArbitratorRepository;
        private readonly IAsyncRepository<Arbitration> _ArbitrationRepository;
        private readonly IAsyncRepository<ArbitrationResult> _ArbitrationResultRepository;
        private readonly IAsyncRepository<Cycle> _CycleRepository;
        private readonly IJwtProvider _JwtProvider;

        public UpdateAssignedFormsToArbitratorHandler(IAsyncRepository<Arbitrator> _ArbitratorRepository,
            IAsyncRepository<Arbitration> _ArbitrationRepository,
            IAsyncRepository<ArbitrationResult> _ArbitrationResultRepository,
            IAsyncRepository<Cycle> _CycleRepository,
            IJwtProvider _JwtProvider)
        {
            this._ArbitratorRepository = _ArbitratorRepository;
            this._ArbitrationRepository = _ArbitrationRepository;
            this._ArbitrationResultRepository = _ArbitrationResultRepository;
            this._CycleRepository = _CycleRepository;
            this._JwtProvider = _JwtProvider;
        }

        public async Task<BaseResponse<object>>
            Handle(UpdateAssignedFormsToArbitratorCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            Arbitrator? ArbitratorEntity = await _ArbitratorRepository
                .FirstOrDefaultAsync(x => x.Id == Request.ArbitratorId);

            if (ArbitratorEntity == null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Arbitrator not found"
                    : "المحكم غير موجود";

                return new BaseResponse<object>(ResponseMessage, false, 404);
            }

            Cycle? CheckIfThereIsActiveCycle = await _CycleRepository
                .FirstOrDefaultAsync(x => x.Status == Domain.Constants.Common.Status.Active);

            if (CheckIfThereIsActiveCycle is null)
                return new BaseResponse<object>(ResponseMessage, false, 200);

            int ActiveCycleId = CheckIfThereIsActiveCycle.Id;

            List<Arbitration> ArbitrationEntitiesToDelete = await _ArbitrationRepository
                .Where(x => Request.DeleteFormsIds.Contains(x.ProvidedFormId) &&
                    x.ArbitratorId == Request.ArbitratorId)
                .ToListAsync();

            int UserId = int.Parse(_JwtProvider.GetUserIdFromToken(Request.Token!));

            IEnumerable<Arbitration> NewArbitrationEntites = Request.NewFormsIds
                .Select(x => new Arbitration()
                {
                    ArbitratorId = Request.ArbitratorId,
                    ProvidedFormId = x,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    isDeleted = false,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    isAccepted = FormStatus.NotArbitratedYet,
                    isAcceptedFromChairman = FormStatus.NotArbitratedYet,
                    isAcceptedFromChairmanFromArbitrationAudit = FormStatus.NotArbitratedYet,
                    AssignedByUserId = UserId
                });

            TransactionOptions TransactionOptions = new TransactionOptions
            {
                IsolationLevel = IsolationLevel.ReadCommitted,
                Timeout = TimeSpan.FromMinutes(5)
            };

            using (TransactionScope Transaction = new TransactionScope(TransactionScopeOption.Required,
                TransactionOptions, TransactionScopeAsyncFlowOption.Enabled))
            {
                try
                {
                    await _ArbitrationRepository.DeleteListAsync(ArbitrationEntitiesToDelete);

                    await _ArbitrationRepository.AddRangeAsync(NewArbitrationEntites);

                    List<ArbitrationResult> ArbitrationResultEntities = await _ArbitrationResultRepository
                        .Where(x => Request.NewFormsIds.Contains(x.ProvidedFormId))
                        .ToListAsync();

                    List<int> NewFormsIdsForArbitrationResult = Request.NewFormsIds
                        .Where(x => !ArbitrationResultEntities
                            .Select(y => y.ProvidedFormId).Contains(x))
                        .ToList();

                    if (NewFormsIdsForArbitrationResult.Any())
                    {
                        List<ArbitrationResult> NewArbitrationResultEntity = Request.NewFormsIds
                            .Select(x => new ArbitrationResult()
                            {
                                ProvidedFormId = x,
                                EligibleForCertification = false,
                                EligibleForAStatement = false,
                                EligibleToWin = false,
                                GotCertification = false,
                                GotStatement1 = false,
                                GotStatement2 = false,
                                Winner = false,
                                FinalArbitrationId = null
                            }).ToList();

                        await _ArbitrationResultRepository.AddRangeAsync(NewArbitrationResultEntity);
                    }

                    if (Request.DeleteFormsIds.Any())
                    {
                        List<Arbitration> RemainigArbitrationEntities = await _ArbitrationRepository
                            .Where(x => Request.DeleteFormsIds.Contains(x.ProvidedFormId) &&
                                x.ProvidedForm!.Category!.CycleId == ActiveCycleId)
                            .ToListAsync();

                        List<int> FormsIdsToDeleteFromArbitrationResultTable = Request.DeleteFormsIds
                            .Where(x => !RemainigArbitrationEntities.Select(y => y.ProvidedFormId).Contains(x))
                            .ToList();

                        if (FormsIdsToDeleteFromArbitrationResultTable.Any())
                        {
                            List<ArbitrationResult> ArbitrationResultEntitiesToDelete = await _ArbitrationResultRepository
                                .Where(x => FormsIdsToDeleteFromArbitrationResultTable.Contains(x.ProvidedFormId))
                                .ToListAsync();

                            await _ArbitrationResultRepository.DeleteListAsync(ArbitrationResultEntitiesToDelete);
                        }
                    }

                    Transaction.Complete();

                    ResponseMessage = Request.lang == "en"
                        ? "Arbitrator's forms has been updated successfully"
                        : "تم تعديل الاستمارات المسندة للمحكم بنجاح";

                    return new BaseResponse<object>(ResponseMessage, true, 200);
                }
                catch (Exception)
                {
                    Transaction.Dispose();
                    throw;
                }
            }
        }
    }
}
