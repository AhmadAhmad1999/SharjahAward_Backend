using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.ArbitrationModel;
using SharijhaAward.Domain.Entities.FinalArbitrationModel;
using System.Transactions;

namespace SharijhaAward.Application.Features.ArbitrationAuditFeatures.Commands.RejectInitialArbiitrationFromArbitrationAudit
{
    public class RejectInitialArbiitrationFromArbitrationAuditHandler
        : IRequestHandler<RejectInitialArbiitrationFromArbitrationAuditCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<Arbitration> _ArbitrationRepository;
        private readonly IAsyncRepository<FinalArbitration> _FinalArbitrationRepository;
        private readonly IJwtProvider _JwtProvider;

        public RejectInitialArbiitrationFromArbitrationAuditHandler(IAsyncRepository<Arbitration> ArbitrationRepository,
            IAsyncRepository<FinalArbitration> FinalArbitrationRepository,
            IJwtProvider JwtProvider)
        {
            _ArbitrationRepository = ArbitrationRepository;
            _FinalArbitrationRepository = FinalArbitrationRepository;
            _JwtProvider = JwtProvider;
        }

        public async Task<BaseResponse<object>> Handle(RejectInitialArbiitrationFromArbitrationAuditCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

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
                    if (!Request.IsAccepted)
                    {
                        FinalArbitration? FinalArbitrationEntity = await _FinalArbitrationRepository
                            .FirstOrDefaultAsync(x => x.ProvidedFormId == Request.FormId);

                        if (FinalArbitrationEntity is not null)
                            await _FinalArbitrationRepository.DeleteAsync(FinalArbitrationEntity);

                        ResponseMessage = Request.lang == "en"
                            ? "Initial arbitration has been rejected successfully"
                            : "تم رفض التحكيم الأولي على الاستمارة بنجاح";
                    }
                    else
                    {
                        int ArbitratorId = int.Parse(_JwtProvider.GetUserIdFromToken(Request.Token!));

                        List<float> FullScores = await _ArbitrationRepository
                            .Where(x => x.ProvidedFormId == Request.FormId)
                            .Select(x => x.FullScore)
                            .ToListAsync();

                        float FullScore = FullScores.Sum() / FullScores.Count();

                        FinalArbitration NewFinalArbitrationEntity = new FinalArbitration()
                        {
                            isAccepted = false,
                            ReasonForRejecting = null,
                            isAcceptedFromChairman = false,
                            ArbitratorId = ArbitratorId,
                            ProvidedFormId = Request.FormId,
                            Type = ArbitrationType.NotBeenArbitrated,
                            DateOfArbitration = null,
                            FullScore = FullScore,
                            FinalScore = 0
                        };

                        await _FinalArbitrationRepository.AddAsync(NewFinalArbitrationEntity);

                        ResponseMessage = Request.lang == "en"
                            ? "Initial arbitration has been accepted successfully"
                            : "تم قبول التحكيم الأولي على الاستمارة بنجاح";
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
