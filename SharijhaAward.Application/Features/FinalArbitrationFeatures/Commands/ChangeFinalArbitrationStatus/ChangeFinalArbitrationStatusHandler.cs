using MediatR;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.ArbitrationModel;
using SharijhaAward.Domain.Entities.ArbitrationResultModel;
using SharijhaAward.Domain.Entities.ArbitratorModel;
using SharijhaAward.Domain.Entities.FinalArbitrationModel;
using System.Transactions;

namespace SharijhaAward.Application.Features.FinalArbitrationFeatures.Commands.ChangeFinalArbitrationStatus
{
    public class ChangeFinalArbitrationStatusHandler : IRequestHandler<ChangeFinalArbitrationStatusCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<FinalArbitration> _FinalArbitrationRepository;
        private readonly IAsyncRepository<ChairmanNotesOnFinalArbitrationScore> _ChairmanNotesOnFinalArbitrationScoreRepository;
        private readonly IAsyncRepository<Arbitrator> _ArbitratorRepository;
        private readonly IAsyncRepository<ArbitrationResult> _ArbitrationResultRepository;
        private readonly IJwtProvider _JwtProvider;
        public ChangeFinalArbitrationStatusHandler(IAsyncRepository<ChairmanNotesOnFinalArbitrationScore> ChairmanNotesOnFinalArbitrationScoreRepository,
            IAsyncRepository<FinalArbitration> ArbitrationRepository,
            IAsyncRepository<Arbitrator> ArbitratorRepository,
            IAsyncRepository<ArbitrationResult> ArbitrationResultRepository,
            IJwtProvider JwtProvider)
        {
            _ChairmanNotesOnFinalArbitrationScoreRepository = ChairmanNotesOnFinalArbitrationScoreRepository;
            _FinalArbitrationRepository = ArbitrationRepository;
            _ArbitratorRepository = ArbitratorRepository;
            _ArbitrationResultRepository = ArbitrationResultRepository;
            _JwtProvider = JwtProvider;
        }

        public async Task<BaseResponse<object>> Handle(ChangeFinalArbitrationStatusCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            FinalArbitration? FinalArbitrationEntity = await _FinalArbitrationRepository
                .FirstOrDefaultAsync(x => x.Id == Request.FinalArbitrationId);

            if (FinalArbitrationEntity is null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Final arbitration is not found"
                    : "التحكيم النهائي غير موجود";

                return new BaseResponse<object>(ResponseMessage, false, 404);
            }

            if (DateTime.UtcNow < FinalArbitrationEntity.ProvidedForm!.Category!.FinalArbitrationStartDate)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Final arbitration didn't start yet for the category of this form"
                    : "عملية التحكيم النهائي للفئة الخاصة بهذه الإستمارة لم تبدأ بعد";

                return new BaseResponse<object>(ResponseMessage, false, 400);
            }
            else if (DateTime.UtcNow > FinalArbitrationEntity.ProvidedForm!.Category!.FinalArbitrationEndDate)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Final arbitration has already ended for the category of this form"
                    : "عملية التحكيم النهائي للفئة الخاصة بهذه الإستمارة انتهت بالفعل";

                return new BaseResponse<object>(ResponseMessage, false, 400);
            }

            int UserId = int.Parse(_JwtProvider.GetUserIdFromToken(Request.Token!));

            Arbitrator? ArbitratorEntity = await _ArbitratorRepository
                .FirstOrDefaultAsync(x => x.Id == UserId);

            if (ArbitratorEntity is null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Arbitrator is not found"
                    : "المحكم غير موجود";

                return new BaseResponse<object>(ResponseMessage, false, 404);
            }

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
                    if (ArbitratorEntity.isChairman ||
                        (Request.AsChairman != null ? Request.AsChairman.Value : false))
                    {
                        FinalArbitrationEntity.isAcceptedFromChairman = Request.isAccepted;

                        bool EligibleForCertification = false;
                        if ((FinalArbitrationEntity.ProvidedForm!.Category!.MinimumRequirementToObtainACertificate != null &&
                            FinalArbitrationEntity.ProvidedForm!.Category!.MaximumRequirementToObtainACertificate != null)
                                ? (FinalArbitrationEntity.ProvidedForm!.Category!.MinimumRequirementToObtainACertificate <= FinalArbitrationEntity.FinalScore &&
                                   FinalArbitrationEntity.ProvidedForm!.Category!.MaximumRequirementToObtainACertificate >= FinalArbitrationEntity.FinalScore)
                                : false)
                            EligibleForCertification = true;

                        bool EligibleForAStatement = false;
                        if ((FinalArbitrationEntity.ProvidedForm!.Category!.MinimumAmountToObtainAStatement2 != null &&
                            FinalArbitrationEntity.ProvidedForm!.Category!.MaximumAmountToObtainAStatement2 != null)
                                ? (FinalArbitrationEntity.ProvidedForm!.Category!.MinimumAmountToObtainAStatement2 <= FinalArbitrationEntity.FinalScore &&
                                   FinalArbitrationEntity.ProvidedForm!.Category!.MaximumAmountToObtainAStatement2 >= FinalArbitrationEntity.FinalScore)
                                : false)
                            EligibleForAStatement = true;

                        bool EligibleToWin = true;
                        if (FinalArbitrationEntity.ProvidedForm!.Category!.MinimumWinningScore != null
                                ? FinalArbitrationEntity.ProvidedForm!.Category!.MinimumWinningScore <= FinalArbitrationEntity.FinalScore
                                : false)
                            EligibleToWin = true;

                        ArbitrationResult? ArbitrationResultEntity = await _ArbitrationResultRepository
                            .FirstOrDefaultAsync(x => x.ProvidedFormId == FinalArbitrationEntity.ProvidedFormId);

                        if (ArbitrationResultEntity is not null)
                        {
                            ArbitrationResultEntity.EligibleForCertification = EligibleForCertification;
                            ArbitrationResultEntity.EligibleForAStatement = EligibleForAStatement;
                            ArbitrationResultEntity.EligibleToWin = EligibleToWin;
                            ArbitrationResultEntity.FinalArbitrationId = FinalArbitrationEntity.Id;

                            await _ArbitrationResultRepository.UpdateAsync(ArbitrationResultEntity);
                        }
                        else
                        {
                            ArbitrationResult NewArbitrationResultEntity = new ArbitrationResult()
                            {
                                ProvidedFormId = FinalArbitrationEntity.ProvidedFormId,
                                EligibleForCertification = EligibleForCertification,
                                EligibleForAStatement = EligibleForAStatement,
                                EligibleToWin = EligibleToWin,
                                GotCertification = false,
                                GotStatement1 = false,
                                GotStatement2 = false,
                                Winner = false,
                                FinalArbitrationId = FinalArbitrationEntity.Id
                            };

                            await _ArbitrationResultRepository.AddAsync(NewArbitrationResultEntity);
                        }
                    }

                    if (Request.isAccepted == FormStatus.Rejected &&
                        (ArbitratorEntity.isChairman ||
                        (Request.AsChairman != null ? Request.AsChairman.Value : false)))
                    {
                        FinalArbitrationEntity.Type = ArbitrationType.BeingReviewed;
                        FinalArbitrationEntity.ReasonForRejecting = Request.ReasonForRejecting;

                        IEnumerable<ChairmanNotesOnFinalArbitrationScore> NewChairmanNotesOnInitialArbitrationEntities = Request.ChairmanNotes
                            .Select(x => new ChairmanNotesOnFinalArbitrationScore()
                            {
                                Note = x.Note,
                                FinalArbitrationScoreId = x.FinalArbitrationScoreId
                            });

                        await _ChairmanNotesOnFinalArbitrationScoreRepository.AddRangeAsync(NewChairmanNotesOnInitialArbitrationEntities);
                    }
                    else if (Request.isAccepted == FormStatus.Accepted &&
                        (ArbitratorEntity.isChairman ||
                        (Request.AsChairman != null ? Request.AsChairman.Value : false)))
                    {
                        FinalArbitrationEntity.Type = ArbitrationType.DoneArbitratod;
                    }
                    else if (Request.isAccepted == FormStatus.NotArbitratedYet)
                    {
                        ResponseMessage = Request.lang == "en"
                            ? "You can't change the acceptance status of an arbitration into Not Arbitrated Yet"
                            : "لا يمكنك تغيير حالة قبول التحكيم إلى \"لم يتم التحكيم بعد\"";

                        return new BaseResponse<object>(ResponseMessage, false, 400);
                    }

                    await _FinalArbitrationRepository.UpdateAsync(FinalArbitrationEntity);

                    Transaction.Complete();

                    ResponseMessage = Request.lang == "en"
                        ? "Created successfully"
                        : (Request.isAccepted == FormStatus.Accepted
                            ? "تم قبول التحكيم بنجاح"
                            : "تم رفض التحكيم بنجاح");

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
