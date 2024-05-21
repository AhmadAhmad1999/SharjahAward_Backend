using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.ArbitrationModel;
using SharijhaAward.Domain.Entities.FinalArbitrationModel;
using System.Transactions;

namespace SharijhaAward.Application.Features.FinalArbitrationFeatures.Commands.CreateFinalArbitrationScore
{
    public class CreateFinalArbitrationScoreHandler : IRequestHandler<CreateFinalArbitrationScoreCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<FinalArbitrationScore> _FinalArbitrationScoreRepository;
        private readonly IAsyncRepository<FinalArbitration> _FinalArbitrationRepository;
        private readonly IMapper _Mapper;

        public CreateFinalArbitrationScoreHandler(IAsyncRepository<FinalArbitrationScore> FinalArbitrationScoreRepository,
            IAsyncRepository<FinalArbitration> FinalArbitrationRepository,
            IMapper Mapper)
        {
            _FinalArbitrationScoreRepository = FinalArbitrationScoreRepository;
            _FinalArbitrationRepository = FinalArbitrationRepository;
            _Mapper = Mapper;
        }

        public async Task<BaseResponse<object>> Handle(CreateFinalArbitrationScoreCommand Request, CancellationToken cancellationToken)
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
                    foreach (CreateFinalArbitrationScoreMainCommand CreateFinalArbitrationScoreMainCommand in Request.CreateFinalArbitrationScoreMainCommand)
                    {
                        if (CreateFinalArbitrationScoreMainCommand.FinalArbitrationScoreId == 0)
                        {
                            FinalArbitrationScore NewFinalArbitrationScoreEntity = _Mapper.Map<FinalArbitrationScore>(CreateFinalArbitrationScoreMainCommand);

                            NewFinalArbitrationScoreEntity.FinalArbitrationId = Request.FinalArbitrationId;

                            await _FinalArbitrationScoreRepository.AddAsync(NewFinalArbitrationScoreEntity);
                        }
                        else
                        {
                            FinalArbitrationScore? FinalArbitrationScoreEntity = await _FinalArbitrationScoreRepository
                                .FirstOrDefaultAsync(x => x.Id == CreateFinalArbitrationScoreMainCommand.FinalArbitrationScoreId);

                            if (FinalArbitrationScoreEntity is null)
                            {
                                ResponseMessage = Request.lang == "en"
                                    ? "Final arbitration score is not Found"
                                    : "التحكيم النهائي غير موجود";

                                return new BaseResponse<object>(ResponseMessage, false, 404);
                            }

                            FinalArbitrationScoreEntity.StrengthPoint = CreateFinalArbitrationScoreMainCommand.StrengthPoint;
                            FinalArbitrationScoreEntity.ImprovementAreas = CreateFinalArbitrationScoreMainCommand.ImprovementAreas;
                            FinalArbitrationScoreEntity.ArbitrationScore = CreateFinalArbitrationScoreMainCommand.ArbitrationScore;

                            await _FinalArbitrationScoreRepository.UpdateAsync(FinalArbitrationScoreEntity);
                        }
                    }

                    FinalArbitration? FinalArbitrationEntity = await _FinalArbitrationRepository
                        .FirstOrDefaultAsync(x => x.Id == Request.FinalArbitrationId);

                    if (FinalArbitrationEntity is null)
                    {
                        ResponseMessage = Request.lang == "en"
                            ? "Final arbitration is not Found"
                            : "التحكيم النهائي غير موجود";

                        return new BaseResponse<object>(ResponseMessage, false, 404);
                    }

                    if (Request.isDoneArbitration)
                    {
                        FinalArbitrationEntity.DateOfArbitration = DateTime.UtcNow;
                        FinalArbitrationEntity.Type = ArbitrationType.DoneArbitratod;
                    }

                    else
                        FinalArbitrationEntity.Type = ArbitrationType.BeingReviewed;

                    FinalArbitrationEntity.FullScore = Request.CreateFinalArbitrationScoreMainCommand.Sum(x => x.ArbitrationScore);

                    await _FinalArbitrationRepository.UpdateAsync(FinalArbitrationEntity);

                    Transaction.Complete();

                    ResponseMessage = Request.lang == "en"
                        ? "Created successfully"
                        : "تم إنشاء التحكيم النهائي بنجاح";

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
