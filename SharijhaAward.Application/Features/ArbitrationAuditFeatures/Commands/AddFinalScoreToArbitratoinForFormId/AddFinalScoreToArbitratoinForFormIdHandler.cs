using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.ArbitrationModel;
using SharijhaAward.Domain.Entities.FinalArbitrationModel;
using System.Transactions;

namespace SharijhaAward.Application.Features.ArbitrationAuditFeatures.Commands.AddFinalScoreToArbitratoinForFormId
{
    public class AddFinalScoreToArbitratoinForFormIdHandler
        : IRequestHandler<AddFinalScoreToArbitratoinForFormIdCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<Arbitration> _ArbitrationRepository;
        private readonly IAsyncRepository<FinalArbitration> _FinalArbitrationRepository;
        private readonly IJwtProvider _JwtProvider;

        public AddFinalScoreToArbitratoinForFormIdHandler(IAsyncRepository<Arbitration> ArbitrationRepository,
            IAsyncRepository<FinalArbitration> FinalArbitrationRepository,
            IJwtProvider JwtProvider)
        {
            _ArbitrationRepository = ArbitrationRepository;
            _FinalArbitrationRepository = FinalArbitrationRepository;
            _JwtProvider = JwtProvider;
        }

        public async Task<BaseResponse<object>> Handle(AddFinalScoreToArbitratoinForFormIdCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            int ArbitratorId = int.Parse(_JwtProvider.GetUserIdFromToken(Request.Token!));

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
                    await _ArbitrationRepository
                        .Where(x => x.ProvidedFormId == Request.FormId)
                        .ExecuteUpdateAsync(x => x.SetProperty(y => y.FullScore, Request.FinalScore));

                    await _ArbitrationRepository
                        .Where(x => x.ProvidedFormId == Request.FormId)
                        .ExecuteUpdateAsync(x => x.SetProperty(y => y.IsRejectedFromArbitrationAuditStep, false));

                    FinalArbitration? CheckIfFinalArbitrationEntityIsAlreadyExist = await _FinalArbitrationRepository
                        .FirstOrDefaultAsync(x => x.ProvidedFormId == Request.FormId);
                    
                    if (CheckIfFinalArbitrationEntityIsAlreadyExist is null)
                    {
                        FinalArbitration NewFinalArbitrationEntity = new FinalArbitration()
                        {
                            isAccepted = false,
                            ReasonForRejecting = null,
                            isAcceptedFromChairman = false,
                            ArbitratorId = ArbitratorId,
                            ProvidedFormId = Request.FormId,
                            Type = ArbitrationType.NotBeenArbitrated,
                            DateOfArbitration = null,
                            FullScore = Request.FinalScore,
                            FinalScore = 0,
                            ParentId = null
                        };

                        await _FinalArbitrationRepository.AddAsync(NewFinalArbitrationEntity);
                    }
                    else
                    {
                        CheckIfFinalArbitrationEntityIsAlreadyExist.FullScore = Request.FinalScore;

                        await _FinalArbitrationRepository.UpdateAsync(CheckIfFinalArbitrationEntityIsAlreadyExist);
                    }

                    Transaction.Complete();

                    ResponseMessage = Request.lang == "en"
                        ? "Final score has been updated successfully"
                        : "تم تعديل العلامة النهائية بنجاح";

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
