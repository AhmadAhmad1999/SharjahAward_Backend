using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.ArbitrationModel;
using SharijhaAward.Domain.Entities.ArbitrationResultModel;
using SharijhaAward.Domain.Entities.CycleModel;
using System.Transactions;

namespace SharijhaAward.Application.Features.ArbitrationFeatures.Commands.AssignMultipleFormsToMultipleArbitrators
{
    public class AssignMultipleFormsToMultipleArbitratorsHandler 
        : IRequestHandler<AssignMultipleFormsToMultipleArbitratorsCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<Arbitration> _ArbitrationRepository;
        private readonly IAsyncRepository<Cycle> _CycleRepository;
        private readonly IJwtProvider _JwtProviderRepository;
        private readonly IAsyncRepository<ArbitrationResult> _ArbitrationResultRepository;

        public AssignMultipleFormsToMultipleArbitratorsHandler(IAsyncRepository<Arbitration> _ArbitrationRepository,
            IAsyncRepository<Cycle> _CycleRepository,
            IJwtProvider _JwtProviderRepository,
            IAsyncRepository<ArbitrationResult> _ArbitrationResultRepository)
        {
            this._ArbitrationRepository = _ArbitrationRepository;
            this._CycleRepository = _CycleRepository;
            this._JwtProviderRepository = _JwtProviderRepository;
            this._ArbitrationResultRepository = _ArbitrationResultRepository;
        }

        public async Task<BaseResponse<object>> Handle(AssignMultipleFormsToMultipleArbitratorsCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            Cycle? CheckIfThereIsActiveCycle = await _CycleRepository
                .FirstOrDefaultAsync(x => x.Status == Domain.Constants.Common.Status.Active);

            if (CheckIfThereIsActiveCycle is null)
                return new BaseResponse<object>(ResponseMessage, false, 200);

            int ActiveCycleId = CheckIfThereIsActiveCycle.Id;

            if (Request.Assign)
            {
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
                        List<Arbitration> CheckArbitration = await _ArbitrationRepository
                            .Where(x => Request.FormsIds.Contains(x.ProvidedFormId))
                            .ToListAsync();

                        int UserId = int.Parse(_JwtProviderRepository.GetUserIdFromToken(Request.Token!));

                        if (CheckArbitration.Any(x => x.isAcceptedFromChairman == FormStatus.Accepted &&
                            x.ArbitratorId != UserId &&
                            x.ProvidedForm!.Category!.CycleId == ActiveCycleId &&
                            x.Type == ArbitrationType.DoneArbitratod))
                        {
                            string EndedFormsIds = string.Join(" , ", CheckArbitration
                                .Where(x => x.isAcceptedFromChairman == FormStatus.Accepted &&
                                    x.ArbitratorId != UserId &&
                                    x.ProvidedForm!.Category!.CycleId == ActiveCycleId &&
                                    x.Type == ArbitrationType.DoneArbitratod)!
                                .Select(x => x.ProvidedFormId)
                                .ToList());

                            ResponseMessage = Request.lang == "en"
                                ? $"You can't assign a new arbitrators to the forms with Ids: {EndedFormsIds} because it's already reached the arbitration audting step"
                                : $"لا يمكنك تعيين محكمين جدد للاستمارات ذات المعرف: {EndedFormsIds} لأنها قد وصلت مسبقاً إلى مرحلة تدقيق التحكيم";

                            return new BaseResponse<object>(ResponseMessage, true, 400);
                        }

                        List<Arbitration> AlreadyExistArbitrationEntities = await _ArbitrationRepository
                            .Where(x => Request.FormsIds.Contains(x.ProvidedFormId))
                            .ToListAsync();

                        List<Arbitration> NewArbitrationEntities = Request.ArbitratorsIds
                            .SelectMany(ArbitratorId => Request.FormsIds
                                .Where(x => !AlreadyExistArbitrationEntities
                                    .Any(y => y.ProvidedFormId == x &&
                                        y.ArbitratorId == ArbitratorId))
                                .Select(x => new Arbitration()
                                {
                                    ArbitratorId = ArbitratorId,
                                    isAccepted = FormStatus.NotArbitratedYet,
                                    ProvidedFormId = x,
                                    isAcceptedFromChairman = FormStatus.NotArbitratedYet,
                                    AssignedByUserId = UserId
                                }))
                            .ToList();

                        await _ArbitrationRepository.AddRangeAsync(NewArbitrationEntities);

                        List<ArbitrationResult> ArbitrationResultEntities = await _ArbitrationResultRepository
                            .Where(x => Request.FormsIds.Contains(x.ProvidedFormId))
                            .ToListAsync();

                        List<int> NewFormsIds = Request.FormsIds
                            .Where(x => !ArbitrationResultEntities.Select(y => y.ProvidedFormId).Contains(x))
                            .ToList();

                        if (NewFormsIds.Any())
                        {
                            IEnumerable<ArbitrationResult> NewArbitrationResultEntities = NewFormsIds
                                .Select(NewFormId => new ArbitrationResult()
                                {
                                    ProvidedFormId = NewFormId,
                                    EligibleForCertification = false,
                                    EligibleForAStatement = false,
                                    EligibleToWin = false,
                                    GotCertification = false,
                                    GotStatement1 = false,
                                    GotStatement2 = false,
                                    Winner = false,
                                    FinalArbitrationId = null
                                });

                            await _ArbitrationResultRepository.AddRangeAsync(NewArbitrationResultEntities);
                        }

                        ResponseMessage = Request.lang == "en"
                            ? "Created successfully"
                            : "تم إنشاء الارتباط بين المحكمين و الاستمارات المختارة بنجاح";

                        Transaction.Complete();

                        return new BaseResponse<object>(ResponseMessage, true, 200);
                    }
                    catch (Exception)
                    {
                        Transaction.Dispose();
                        throw;
                    }
                }
            }
            else
            {
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
                        List<Arbitration> CheckArbitration = await _ArbitrationRepository
                            .Where(x => Request.FormsIds.Contains(x.ProvidedFormId) &&
                                Request.ArbitratorsIds.Contains(x.ArbitratorId) &&
                                x.ProvidedForm!.Category!.CycleId == ActiveCycleId)
                            .ToListAsync();

                        await _ArbitrationRepository.DeleteListAsync(CheckArbitration);

                        List<Arbitration> RemainigArbitrationEntities = await _ArbitrationRepository
                            .Where(x => Request.FormsIds.Contains(x.ProvidedFormId) &&
                                x.ProvidedForm!.Category!.CycleId == ActiveCycleId)
                            .ToListAsync();

                        List<int> FormsIdsToDeleteFromArbitrationResultTable = Request.FormsIds
                            .Where(x => !RemainigArbitrationEntities.Select(y => y.ProvidedFormId).Contains(x))
                            .ToList();

                        if (FormsIdsToDeleteFromArbitrationResultTable.Any())
                        {
                            List<ArbitrationResult> ArbitrationResultEntitiesToDelete = await _ArbitrationResultRepository
                                .Where(x => FormsIdsToDeleteFromArbitrationResultTable.Contains(x.ProvidedFormId))
                                .ToListAsync();

                            await _ArbitrationResultRepository.DeleteListAsync(ArbitrationResultEntitiesToDelete);
                        }

                        Transaction.Complete();

                        ResponseMessage = Request.lang == "en"
                            ? "Created successfully"
                            : "تم إلغاء الارتباط بين المحكمين و الاستمارات المختارة بنجاح";

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
}
