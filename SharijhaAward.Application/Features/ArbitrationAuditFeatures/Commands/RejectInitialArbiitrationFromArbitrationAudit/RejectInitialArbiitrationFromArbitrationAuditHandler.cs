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
        private readonly IJwtProvider _JwtProvider;

        public RejectInitialArbiitrationFromArbitrationAuditHandler(IAsyncRepository<Arbitration> ArbitrationRepository,
            IAsyncRepository<FinalArbitration> FinalArbitrationRepository,
            IAsyncRepository<Arbitrator> ArbitratorRepository,
            IJwtProvider JwtProvider)
        {
            _ArbitrationRepository = ArbitrationRepository;
            _FinalArbitrationRepository = FinalArbitrationRepository;
            _ArbitratorRepository = ArbitratorRepository;
            _JwtProvider = JwtProvider;
        }

        public async Task<BaseResponse<object>> Handle(RejectInitialArbiitrationFromArbitrationAuditCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

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

                        ResponseMessage = Request.lang == "en"
                            ? "Initial arbitration has been rejected successfully"
                            : "تم رفض التحكيم الأولي على الاستمارة بنجاح";
                    }
                    else if (Request.IsAccepted == FormStatus.Accepted)
                    {
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

                    if (Request.ReasonForRejecting != null)
                    {
                        foreach (Arbitration ArbitrationEntity in ArbitrationEntities)
                        {
                            ArbitrationEntity.isAcceptedFromChairmanFromArbitrationAudit = Request.IsAccepted;
                            ArbitrationEntity.ReasonForRejectingFromArbitrationAudit = Request.ReasonForRejecting;
                        }

                        await _ArbitrationRepository.UpdateListAsync(ArbitrationEntities);
                    }
                    else
                    {
                        foreach (Arbitration ArbitrationEntity in ArbitrationEntities)
                        {
                            ArbitrationEntity.isAcceptedFromChairmanFromArbitrationAudit = Request.IsAccepted;
                        }

                        await _ArbitrationRepository.UpdateListAsync(ArbitrationEntities);
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
