using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.ArbitrationModel;
using SharijhaAward.Domain.Entities.ArbitratorModel;
using SharijhaAward.Domain.Entities.FinalArbitrationModel;
using System.Transactions;

namespace SharijhaAward.Application.Features.ArbitrationAuditFeatures.Commands.RejectInitialArbiitrationFromArbitrationAudit
{
    public class RejectInitialArbiitrationFromArbitrationAuditHandler
        : IRequestHandler<RejectInitialArbiitrationFromArbitrationAuditCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<Arbitration> _ArbitrationRepository;
        private readonly IAsyncRepository<FinalArbitration> _FinalArbitrationRepository;
        private readonly IAsyncRepository<Arbitrator> _ArbitratorRepository;
        private readonly IAsyncRepository<ArbitrationAudit> _ArbitrationAuditRepository;
        private readonly IJwtProvider _JwtProvider;
        private readonly IAsyncRepository<Domain.Entities.ProvidedFormModel.ProvidedForm> _ProvidedFormRepository;

        public RejectInitialArbiitrationFromArbitrationAuditHandler(IAsyncRepository<Arbitration> ArbitrationRepository,
            IAsyncRepository<FinalArbitration> FinalArbitrationRepository,
            IAsyncRepository<Arbitrator> ArbitratorRepository,
            IAsyncRepository<ArbitrationAudit> _ArbitrationAuditRepository,
            IJwtProvider JwtProvider,
            IAsyncRepository<Domain.Entities.ProvidedFormModel.ProvidedForm> _ProvidedFormRepository)
        {
            _ArbitrationRepository = ArbitrationRepository;
            _FinalArbitrationRepository = FinalArbitrationRepository;
            _ArbitratorRepository = ArbitratorRepository;
            this._ArbitrationAuditRepository = _ArbitrationAuditRepository;
            _JwtProvider = JwtProvider;
            this._ProvidedFormRepository = _ProvidedFormRepository;
        }

        public async Task<BaseResponse<object>> Handle(RejectInitialArbiitrationFromArbitrationAuditCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            Domain.Entities.ProvidedFormModel.ProvidedForm? ProvidedFormEntity = await _ProvidedFormRepository
                .FirstOrDefaultAsync(x => x.Id == Request.FormId);

            if (ProvidedFormEntity is not null)
            {
                if (DateTime.UtcNow < ProvidedFormEntity.Category!.ArbitrationAuditStartDate)
                {
                    ResponseMessage = Request.lang == "en"
                        ? "Arbitration audit didn't start yet for the category of this form"
                        : "عملية تدقيق التحكيم للفئة الخاصة بهذه الإستمارة لم تبدأ بعد";

                    return new BaseResponse<object>(ResponseMessage, false, 400);
                }
                else if (DateTime.UtcNow > ProvidedFormEntity.Category!.ArbitrationAuditEndDate)
                {
                    ResponseMessage = Request.lang == "en"
                        ? "Arbitration audit has already ended for the category of this form"
                        : "عملية تدقيق التحكيم للفئة الخاصة بهذه الإستمارة انتهت بالفعل";

                    return new BaseResponse<object>(ResponseMessage, false, 400);
                }
            }

            List<Arbitration> ArbitrationEntities = await _ArbitrationRepository
                .Where(x => x.ProvidedFormId == Request.FormId)
                .ToListAsync();

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
                    if (Request.IsAccepted == FormStatus.Rejected)
                    {
                        FinalArbitration? FinalArbitrationEntity = await _FinalArbitrationRepository
                            .FirstOrDefaultAsync(x => x.ProvidedFormId == Request.FormId);

                        if (FinalArbitrationEntity is not null)
                            await _FinalArbitrationRepository.DeleteAsync(FinalArbitrationEntity);

                        foreach (Arbitration? ArbitrationEntity in ArbitrationEntities)
                        {
                            ArbitrationEntity.isAcceptedFromChairmanFromArbitrationAudit = FormStatus.Rejected;
                            ArbitrationEntity.ReasonForRejectingFromArbitrationAudit = Request.ReasonForRejecting;

                            ArbitrationEntity.ArbitrationAuditType = ArbitrationType.BeingReviewed;
                        }

                        await _ArbitrationRepository.UpdateListAsync(ArbitrationEntities);

                        if (ProvidedFormEntity!.EligibileForInterview)
                        {
                            ProvidedFormEntity.EligibileForInterview = false;

                            await _ProvidedFormRepository.UpdateAsync(ProvidedFormEntity);
                        }    

                        ResponseMessage = Request.lang == "en"
                            ? "Initial arbitration has been rejected successfully"
                            : "تم رفض التحكيم الأولي على الاستمارة بنجاح";
                    }
                    else if (Request.IsAccepted == FormStatus.Accepted)
                    {
                        bool ItExceededTheMarginOfDifferenceInArbitrationScores = false;

                        var CopyOfArbitrationEntities = ArbitrationEntities
                            .Where(x => x.RollbackArbitrationId == null);

                        int MarginOfDifferenceBetweenArbitrators = CopyOfArbitrationEntities
                            .Select(x => x.ProvidedForm!.Category!.MarginOfDifferenceBetweenArbitrators)
                            .FirstOrDefault();

                        foreach (Arbitration ArbitrationEntity1 in CopyOfArbitrationEntities)
                        {
                            foreach (Arbitration ArbitrationEntity2 in CopyOfArbitrationEntities)
                            {
                                if (Math.Abs(ArbitrationEntity1.FullScore - ArbitrationEntity2.FullScore) > MarginOfDifferenceBetweenArbitrators)
                                {
                                    ItExceededTheMarginOfDifferenceInArbitrationScores = true;
                                    break;
                                }
                            }
                        }

                        if (ItExceededTheMarginOfDifferenceInArbitrationScores)
                        {
                            ResponseMessage = Request.lang == "en"
                                ? "You can accept the arbitration on this form unless the margin of difference in arbitration scores is correct"
                                : "لا يمكنك الموافقة على التحكيم على هذه الاستمارة حتى يكون هامش الفرق بين المحكمين صحيح";

                            Transaction.Dispose();

                            return new BaseResponse<object>(ResponseMessage, false, 400);
                        }

                        int ArbitratorId = int.Parse(_JwtProvider.GetUserIdFromToken(Request.Token!));

                        FinalArbitration? FinalArbitrationEntity = await _FinalArbitrationRepository
                            .FirstOrDefaultAsync(x => x.ProvidedFormId == Request.FormId);

                        if (FinalArbitrationEntity is null)
                        {
                            FinalArbitration NewFinalArbitrationEntity = new FinalArbitration()
                            {
                                ReasonForRejecting = null,
                                isAcceptedFromChairman = FormStatus.NotArbitratedYet,
                                ArbitratorId = ArbitratorId,
                                ProvidedFormId = Request.FormId,
                                Type = ArbitrationType.NotBeenArbitrated,
                                DateOfArbitration = null,
                                FullScore = 0,
                                FinalScore = 0
                            };

                            await _FinalArbitrationRepository.AddAsync(NewFinalArbitrationEntity);
                        }

                        foreach (Arbitration? ArbitrationEntity in ArbitrationEntities)
                        {
                            ArbitrationEntity.isAcceptedFromChairmanFromArbitrationAudit = Request.IsAccepted;

                            ArbitrationEntity.ArbitrationAuditType = ArbitrationType.DoneArbitratod;

                            ArbitrationEntity.ReasonForRejectingFromArbitrationAudit = Request.ReasonForRejecting;
                        }

                        await _ArbitrationRepository.UpdateListAsync(ArbitrationEntities);

                        if (ProvidedFormEntity is not null)
                        {
                            var ArbitrationAuditScore = await _ArbitrationAuditRepository
                                .Where(x => ProvidedFormEntity!.Id == x.ProvidedFormId)
                                .SumAsync(x => x.ArbitrationScore);

                            if (ArbitrationAuditScore >= ProvidedFormEntity!.Category!.MinimumEligibilityForInterview)
                            {
                                ProvidedFormEntity.EligibileForInterview = true;

                                await _ProvidedFormRepository.UpdateAsync(ProvidedFormEntity);
                            }
                            else if (ProvidedFormEntity.EligibileForInterview &&
                                ArbitrationAuditScore < ProvidedFormEntity.Category!.MinimumEligibilityForInterview)
                            {
                                ProvidedFormEntity.EligibileForInterview = false;

                                await _ProvidedFormRepository.UpdateAsync(ProvidedFormEntity);
                            }
                        }
                        
                        ResponseMessage = Request.lang == "en"
                            ? "Initial arbitration has been accepted successfully"
                            : "تم قبول التحكيم الأولي على الاستمارة بنجاح";
                    }
                    else if (Request.IsAccepted == FormStatus.NotArbitratedYet)
                    {
                        ResponseMessage = Request.lang == "en"
                            ? "You can't change the acceptance status of an arbitration into Not Arbitrated Yet"
                            : "لا يمكنك تغيير حالة قبول التحكيم إلى \"لم يتم التحكيم بعد\"";

                        return new BaseResponse<object>(ResponseMessage, true, 400);
                    }

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
    }
}
