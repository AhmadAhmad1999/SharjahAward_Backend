using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.ArbitrationModel;
using SharijhaAward.Domain.Entities.ArbitrationResultModel;
using SharijhaAward.Domain.Entities.CriterionItemModel;
using SharijhaAward.Domain.Entities.CriterionModel;
using SharijhaAward.Domain.Entities.FinalArbitrationModel;
using System.Transactions;

namespace SharijhaAward.Application.Features.FinalArbitrationFeatures.Commands.CreateFinalArbitrationScore
{
    public class CreateFinalArbitrationScoreHandler : IRequestHandler<CreateFinalArbitrationScoreCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<FinalArbitrationScore> _FinalArbitrationScoreRepository;
        private readonly IAsyncRepository<FinalArbitration> _FinalArbitrationRepository;
        private readonly IAsyncRepository<ArbitrationResult> _ArbitrationResultRepository;
        private readonly IAsyncRepository<Criterion> _CriterionRepository;
        private readonly IAsyncRepository<CriterionItem> _CriterionItemRepository;
        private readonly IMapper _Mapper;

        public CreateFinalArbitrationScoreHandler(IAsyncRepository<FinalArbitrationScore> FinalArbitrationScoreRepository,
            IAsyncRepository<FinalArbitration> FinalArbitrationRepository,
            IAsyncRepository<ArbitrationResult> ArbitrationResultRepository,
            IAsyncRepository<Criterion> CriterionRepository,
            IAsyncRepository<CriterionItem> CriterionItemRepository,
            IMapper Mapper)
        {
            _FinalArbitrationScoreRepository = FinalArbitrationScoreRepository;
            _FinalArbitrationRepository = FinalArbitrationRepository;
            _ArbitrationResultRepository = ArbitrationResultRepository;
            _CriterionRepository = CriterionRepository;
            _CriterionItemRepository = CriterionItemRepository;
            _Mapper = Mapper;
        }

        public async Task<BaseResponse<object>> Handle(CreateFinalArbitrationScoreCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            List<Criterion> CriterionEntities = await _CriterionRepository
                .Where(x => Request.CreateFinalArbitrationScoreMainCommand
                    .Where(y => y.CriterionId != null).Select(y => y.CriterionId)
                    .Any(y => y == x.Id))
                .ToListAsync();

            List<CriterionItem> CriterionItemEntities = await _CriterionItemRepository
                .Where(x => Request.CreateFinalArbitrationScoreMainCommand
                    .Where(y => y.CriterionItemId != null).Select(y => y.CriterionItemId)
                    .Any(y => y == x.Id))
                .ToListAsync();

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
                    FinalArbitration? FinalArbitrationEntity = await _FinalArbitrationRepository
                        .Include(x => x.ProvidedForm!)
                        .Include(x => x.ProvidedForm!.Category!)
                        .FirstOrDefaultAsync(x => x.Id == Request.FinalArbitrationId);

                    if (FinalArbitrationEntity is null)
                    {
                        ResponseMessage = Request.lang == "en"
                            ? "Final arbitration is not Found"
                            : "التحكيم النهائي غير موجود";

                        return new BaseResponse<object>(ResponseMessage, false, 404);
                    }

                    foreach (CreateFinalArbitrationScoreMainCommand CreateFinalArbitrationScoreMainCommand in 
                        Request.CreateFinalArbitrationScoreMainCommand)
                    {
                        if (CreateFinalArbitrationScoreMainCommand.CriterionId is not null)
                        {
                            bool CheckInsertedScore = CriterionEntities
                                .FirstOrDefault(x => x.Id == CreateFinalArbitrationScoreMainCommand.CriterionId)!
                                .Score < CreateFinalArbitrationScoreMainCommand.ArbitrationScore;

                            if (CheckInsertedScore)
                            {
                                ResponseMessage = Request.lang == "en"
                                    ? "Final arbitration score can't be bigger than the criterion max score"
                                    : "لا يمكن أن تكون النتيجة النهائية للتحكيم أكبر من الحد الأقصى لنتيجة المعيار";

                                Transaction.Dispose();

                                return new BaseResponse<object>(ResponseMessage, false, 404);
                            }
                        }
                        else if (CreateFinalArbitrationScoreMainCommand.CriterionItemId is not null)
                        {
                            bool CheckInsertedScore = CriterionItemEntities
                                .FirstOrDefault(x => x.Id == CreateFinalArbitrationScoreMainCommand.CriterionItemId)!
                                .Score < CreateFinalArbitrationScoreMainCommand.ArbitrationScore;

                            if (CheckInsertedScore)
                            {
                                ResponseMessage = Request.lang == "en"
                                    ? "Final arbitration score can't be bigger than the criterion item max score"
                                    : "لا يمكن أن تكون النتيجة النهائية للتحكيم أكبر من الحد الأقصى لنتيجة عنصر المعيار ";

                                Transaction.Dispose();

                                return new BaseResponse<object>(ResponseMessage, false, 404);
                            }
                        }

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
                    
                    if (Request.isDoneArbitration)
                    {
                        FinalArbitrationEntity.DateOfArbitration = DateTime.UtcNow;
                        FinalArbitrationEntity.Type = ArbitrationType.DoneArbitratod;
                        FinalArbitrationEntity.FinalScore = Request.CreateFinalArbitrationScoreMainCommand.Sum(x => x.ArbitrationScore);

                        bool EligibleForCertification = false;
                        if ((FinalArbitrationEntity.ProvidedForm!.Category!.MinimumRequirementToObtainACertificate != null &&
                            FinalArbitrationEntity.ProvidedForm!.Category!.MaximumRequirementToObtainACertificate != null)
                                ? (FinalArbitrationEntity.ProvidedForm!.Category!.MinimumRequirementToObtainACertificate <= FinalArbitrationEntity.FinalScore &&
                                   FinalArbitrationEntity.ProvidedForm!.Category!.MaximumRequirementToObtainACertificate >= FinalArbitrationEntity.FinalScore)
                                : false)
                            EligibleForCertification = true;

                        bool EligibleForAStatement = false;
                        if ((FinalArbitrationEntity.ProvidedForm!.Category!.MinimumAmountToObtainAStatement != null &&
                            FinalArbitrationEntity.ProvidedForm!.Category!.MaximumAmountToObtainAStatement != null)
                                ? (FinalArbitrationEntity.ProvidedForm!.Category!.MinimumAmountToObtainAStatement <= FinalArbitrationEntity.FinalScore &&
                                   FinalArbitrationEntity.ProvidedForm!.Category!.MaximumAmountToObtainAStatement >= FinalArbitrationEntity.FinalScore)
                                : false)
                            EligibleForAStatement = true;

                        bool EligibleToWin = true;
                        if (FinalArbitrationEntity.ProvidedForm!.Category!.MinimumWinningScore != null
                                ? FinalArbitrationEntity.ProvidedForm!.Category!.MinimumWinningScore <= FinalArbitrationEntity.FinalScore
                                : false)
                            EligibleToWin = true;

                        ArbitrationResult? ArbitrationResultEntity = await _ArbitrationResultRepository
                            .FirstOrDefaultAsync(x => x.ProvidedFormId == FinalArbitrationEntity.ProvidedFormId &&
                                x.FinalArbitrationId == FinalArbitrationEntity.Id);

                        if (ArbitrationResultEntity is not null)
                        {
                            ArbitrationResultEntity.EligibleForCertification = EligibleForCertification;
                            ArbitrationResultEntity.EligibleForAStatement = EligibleForAStatement;
                            ArbitrationResultEntity.EligibleToWin = EligibleToWin;

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
                                GotStatement = false,
                                Winner = false,
                                FinalArbitrationId = FinalArbitrationEntity.Id
                            };

                            await _ArbitrationResultRepository.AddAsync(NewArbitrationResultEntity);
                        }
                    }

                    else
                        FinalArbitrationEntity.Type = ArbitrationType.BeingReviewed;

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
