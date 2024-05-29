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
                    float? FinalArbitrationQualificationMark = await _ArbitrationRepository
                        .Include(x => x.ProvidedForm!)
                        .Include(x => x.ProvidedForm!.Category!)
                        .Select(x => x.ProvidedForm!.Category!.FinalArbitrationQualificationMark)
                        .FirstOrDefaultAsync();

                    await _ArbitrationRepository
                        .Where(x => x.ProvidedFormId == Request.FormId)
                        .ExecuteUpdateAsync(x => x.SetProperty(y => y.FullScore, Request.FinalScore));

                    FinalArbitration? CheckIfFinalArbitrationEntityIsAlreadyExist = await _FinalArbitrationRepository
                        .FirstOrDefaultAsync(x => x.ProvidedFormId == Request.FormId);

                    if (CheckIfFinalArbitrationEntityIsAlreadyExist is null &&
                        (FinalArbitrationQualificationMark is not null
                            ? Request.FinalScore >= FinalArbitrationQualificationMark
                            : false))
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
                            FinalScore = 0
                        };

                        await _FinalArbitrationRepository.AddAsync(NewFinalArbitrationEntity);
                    }
                    else if (CheckIfFinalArbitrationEntityIsAlreadyExist is not null &&
                        (FinalArbitrationQualificationMark is not null
                            ? Request.FinalScore >= FinalArbitrationQualificationMark
                            : false))
                    {
                        CheckIfFinalArbitrationEntityIsAlreadyExist.FullScore = Request.FinalScore;

                        await _FinalArbitrationRepository.UpdateAsync(CheckIfFinalArbitrationEntityIsAlreadyExist);
                    }
                    else if (CheckIfFinalArbitrationEntityIsAlreadyExist is not null &&
                        (FinalArbitrationQualificationMark is not null
                            ? Request.FinalScore < FinalArbitrationQualificationMark
                            : false))
                    {
                        await _FinalArbitrationRepository.DeleteAsync(CheckIfFinalArbitrationEntityIsAlreadyExist);
                    }

                    Transaction.Complete();

                    ResponseMessage = Request.lang == "en"
                        ? "Final score has been addded successfully"
                        : "تم إضافة العلامة النهائية بنجاح";

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
