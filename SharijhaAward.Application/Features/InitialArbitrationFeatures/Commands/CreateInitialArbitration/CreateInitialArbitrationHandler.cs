using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.ArbitrationModel;
using SharijhaAward.Domain.Entities.CriterionItemModel;
using SharijhaAward.Domain.Entities.CriterionModel;
using SharijhaAward.Domain.Entities.FinalArbitrationModel;
using System.Transactions;

namespace SharijhaAward.Application.Features.InitialArbitrationFeatures.Commands.CreateInitialArbitration
{
    public class CreateInitialArbitrationHandler : IRequestHandler<CreateInitialArbitrationCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<InitialArbitration> _InitialArbitrationRepository;
        private readonly IAsyncRepository<Arbitration> _ArbitrationRepository;
        private readonly IAsyncRepository<Criterion> _CriterionRepository;
        private readonly IAsyncRepository<CriterionItem> _CriterionItemRepository;
        private readonly IAsyncRepository<FinalArbitration> _FinalArbitrationRepository;
        private readonly IMapper _Mapper;

        public CreateInitialArbitrationHandler(IAsyncRepository<InitialArbitration> InitialArbitrationRepository,
            IAsyncRepository<Arbitration> ArbitrationRepository,
            IAsyncRepository<Criterion> CriterionRepository,
            IAsyncRepository<CriterionItem> CriterionItemRepository,
            IAsyncRepository<FinalArbitration> _FinalArbitrationRepository,
            IMapper Mapper)
        {
            _InitialArbitrationRepository = InitialArbitrationRepository;
            _ArbitrationRepository = ArbitrationRepository;
            _CriterionRepository = CriterionRepository;
            _CriterionItemRepository = CriterionItemRepository;
            this._FinalArbitrationRepository = _FinalArbitrationRepository;
            _Mapper = Mapper;
        }

        public async Task<BaseResponse<object>> Handle(CreateInitialArbitrationCommand Request, CancellationToken cancellationToken)
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
                    string ResponseMessage = string.Empty;

                    int ArbitrationEntityId = 0;

                    Arbitration? ArbitrationEntity = await _ArbitrationRepository
                        .FirstOrDefaultAsync(x => x.Id == Request.ArbitrationId);

                    if (ArbitrationEntity is null)
                    {
                        ResponseMessage = Request.lang == "en"
                            ? "Arbitration is not Found"
                            : "التحكيم غير موجود";

                        return new BaseResponse<object>(ResponseMessage, false, 404);
                    }

                    if (DateTime.UtcNow < ArbitrationEntity.ProvidedForm!.Category!.InitialArbitrationStartDate)
                    {
                        ResponseMessage = Request.lang == "en"
                            ? "Initial arbitration didn't start yet for the category of this form"
                            : "عملية التحكيم الأولي للفئة الخاصة بهذه الإستمارة لم تبدأ بعد";

                        return new BaseResponse<object>(ResponseMessage, false, 400);
                    }
                    else if (DateTime.UtcNow > ArbitrationEntity.ProvidedForm!.Category!.InitialArbitrationEndDate)
                    {
                        ResponseMessage = Request.lang == "en"
                            ? "Initial arbitration has already ended for the category of this form"
                            : "عملية التحكيم الأولي للفئة الخاصة بهذه الإستمارة انتهت بالفعل";

                        return new BaseResponse<object>(ResponseMessage, false, 400);
                    }

                    Arbitration? NewArbitrationEntity = null;

                    if (ArbitrationEntity.DateOfArbitration == DateTime.UtcNow &&
                        ArbitrationEntity.Type == ArbitrationType.DoneArbitratod &&
                        ArbitrationEntity.isAcceptedFromChairman == FormStatus.Rejected)
                    {
                        NewArbitrationEntity = ArbitrationEntity;
                        NewArbitrationEntity.Id = 0;

                        await _ArbitrationRepository.AddAsync(NewArbitrationEntity);

                        ArbitrationEntityId = NewArbitrationEntity.Id;

                        ArbitrationEntity.RollbackArbitrationId = NewArbitrationEntity.Id;

                        await _ArbitrationRepository.UpdateAsync(ArbitrationEntity);
                    }
                    else
                    {
                        ArbitrationEntityId = ArbitrationEntity.Id;
                    }

                    var InitialArbitrationMainCommandCriterion = Request.InitialArbitrationMainCommand
                        .Where(y => y.CriterionId != null)
                        .Select(y => y.CriterionId);

                    List<Criterion> CriterionEntities = await _CriterionRepository
                        .Where(x => InitialArbitrationMainCommandCriterion.Contains(x.Id))
                        .Include(x => x.Parent!)
                        .ToListAsync();

                    var InitialArbitrationMainCommandCriterionItem = Request.InitialArbitrationMainCommand
                        .Where(y => y.CriterionItemId != null)
                        .Select(y => y.CriterionItemId);

                    List<CriterionItem> CriterionItemEntities = await _CriterionItemRepository
                        .Where(x => InitialArbitrationMainCommandCriterionItem.Contains(x.Id))
                        .ToListAsync();

                    IEnumerable<InitialArbitrationMainCommand> InitialArbitrationMainCommands = Request.InitialArbitrationMainCommand
                        .Where(x => x.ArbitrationScore != null);

                    List<InitialArbitration> InitialArbitrationEntities = await _InitialArbitrationRepository
                        .Where(x => x.ArbitrationId == ArbitrationEntityId)
                        .ToListAsync();

                    foreach (InitialArbitrationMainCommand InitialArbitrationMainCommand in InitialArbitrationMainCommands)
                    {
                        if (InitialArbitrationMainCommand.CriterionId is not null &&
                            InitialArbitrationMainCommand.CriterionItemId is null)
                        {
                            bool CheckInsertedScore = CriterionEntities
                                .FirstOrDefault(x => x.Id == InitialArbitrationMainCommand.CriterionId)!
                                .Score < InitialArbitrationMainCommand.ArbitrationScore;

                            if (CheckInsertedScore)
                            {
                                ResponseMessage = Request.lang == "en"
                                    ? "Arbitration score can't be bigger than the criterion max score"
                                    : "لا يمكن أن تكون نتيجة التحكيم أكبر من الحد الأقصى لنتيجة المعيار";

                                Transaction.Dispose();

                                return new BaseResponse<object>(ResponseMessage, false, 400);
                            }
                        }
                        else if (InitialArbitrationMainCommand.CriterionItemId is not null)
                        {
                            bool CheckInsertedScore = CriterionItemEntities
                                .FirstOrDefault(x => x.Id == InitialArbitrationMainCommand.CriterionItemId)!
                                .Score < InitialArbitrationMainCommand.ArbitrationScore;

                            if (CheckInsertedScore)
                            {
                                ResponseMessage = Request.lang == "en"
                                    ? "Arbitration score can't be bigger than the criterion item max score"
                                    : "لا يمكن أن تكون نتيجة التحكيم أكبر من الحد الأقصى لنتيجة عنصر المعيار ";

                                Transaction.Dispose();

                                return new BaseResponse<object>(ResponseMessage, false, 400);
                            }
                        }

                        if (InitialArbitrationMainCommand.InitialArbitrationId == 0)
                        {
                            InitialArbitration NewInitialArbitrationEntity = _Mapper.Map<InitialArbitration>(InitialArbitrationMainCommand);

                            NewInitialArbitrationEntity.ArbitrationId = Request.ArbitrationId;

                            await _InitialArbitrationRepository.AddAsync(NewInitialArbitrationEntity);
                        }
                        else
                        {
                            InitialArbitration? InitialArbitrationEntity = await _InitialArbitrationRepository
                                .FirstOrDefaultAsync(x => x.Id == InitialArbitrationMainCommand.InitialArbitrationId);

                            if (InitialArbitrationEntity is null)
                            {
                                ResponseMessage = Request.lang == "en"
                                    ? "Initial arbitration is not Found"
                                    : "التحكيم الأولي غير موجود";

                                return new BaseResponse<object>(ResponseMessage, false, 404);
                            }

                            InitialArbitrationEntity.StrengthPoint = InitialArbitrationMainCommand.StrengthPoint;
                            InitialArbitrationEntity.ImprovementAreas = InitialArbitrationMainCommand.ImprovementAreas;
                            InitialArbitrationEntity.ArbitrationScore = InitialArbitrationMainCommand.ArbitrationScore!.Value;

                            await _InitialArbitrationRepository.UpdateAsync(InitialArbitrationEntity);
                        }
                    }

                    if (Request.isDoneArbitration)
                    {
                        if (NewArbitrationEntity is null)
                        {
                            ArbitrationEntity.DateOfArbitration = DateTime.UtcNow;
                            ArbitrationEntity.Type = ArbitrationType.DoneArbitratod;
                            ArbitrationEntity.isAcceptedFromChairman = FormStatus.Accepted;
                        }
                        else
                        {
                            NewArbitrationEntity.DateOfArbitration = DateTime.UtcNow;
                            NewArbitrationEntity.Type = ArbitrationType.DoneArbitratod;
                            NewArbitrationEntity.isAcceptedFromChairman = FormStatus.Accepted;
                        }
                    }

                    else
                    {
                        if (NewArbitrationEntity is null)
                        {
                            ArbitrationEntity.Type = ArbitrationType.BeingReviewed;
                        }
                        else
                        {
                            NewArbitrationEntity.Type = ArbitrationType.BeingReviewed;
                        }
                    }
                        
                    if (NewArbitrationEntity is null)
                    {
                        ArbitrationEntity.FullScore = Request.InitialArbitrationMainCommand.Sum(x => x.ArbitrationScore!.Value);

                        await _ArbitrationRepository.UpdateAsync(ArbitrationEntity);

                        List<Arbitration> CheckIfAllArbitratorsAreDone = await _ArbitrationRepository
                            .Where(x => x.ProvidedFormId == ArbitrationEntity.ProvidedFormId &&
                                x.RollbackArbitrationId == null)
                            .ToListAsync();

                        if (CheckIfAllArbitratorsAreDone.All(x => x.Type == ArbitrationType.DoneArbitratod &&
                                x.isAcceptedFromChairman == FormStatus.Accepted &&
                                x.DateOfArbitration != null))
                        {
                            bool ItExceededTheMarginOfDifferenceInArbitrationScores = false;

                            int MarginOfDifferenceBetweenArbitrators = CheckIfAllArbitratorsAreDone
                                .Select(x => x.ProvidedForm!.Category!.MarginOfDifferenceBetweenArbitrators)
                                .FirstOrDefault();

                            foreach (Arbitration ArbitrationEntity1 in CheckIfAllArbitratorsAreDone)
                            {
                                foreach (Arbitration ArbitrationEntity2 in CheckIfAllArbitratorsAreDone)
                                {
                                    if (Math.Abs(ArbitrationEntity1.FullScore - ArbitrationEntity2.FullScore) > MarginOfDifferenceBetweenArbitrators)
                                    {
                                        ItExceededTheMarginOfDifferenceInArbitrationScores = true;
                                        break;
                                    }
                                }
                            }

                            if (!ItExceededTheMarginOfDifferenceInArbitrationScores)
                            {
                                await _ArbitrationRepository
                                    .Where(x => x.ProvidedFormId == ArbitrationEntity.ProvidedFormId)
                                    .ExecuteUpdateAsync(x => x
                                        .SetProperty(y => y.DateOfArbitrationAuditing, DateTime.UtcNow)
                                        .SetProperty(y => y.ArbitrationAuditType, ArbitrationType.DoneArbitratod)
                                        .SetProperty(y => y.isAcceptedFromChairmanFromArbitrationAudit, FormStatus.Accepted));

                                int ArbitratorId = CheckIfAllArbitratorsAreDone.FirstOrDefault()!.ArbitratorId;

                                FinalArbitration? FinalArbitrationEntity = await _FinalArbitrationRepository
                                    .FirstOrDefaultAsync(x => x.ProvidedFormId == ArbitrationEntity.ProvidedFormId);

                                if (FinalArbitrationEntity is null)
                                {
                                    FinalArbitration NewFinalArbitrationEntity = new FinalArbitration()
                                    {
                                        ReasonForRejecting = null,
                                        isAcceptedFromChairman = FormStatus.NotArbitratedYet,
                                        ArbitratorId = ArbitratorId,
                                        ProvidedFormId = ArbitrationEntity.ProvidedFormId,
                                        Type = ArbitrationType.NotBeenArbitrated,
                                        DateOfArbitration = null,
                                        FullScore = 0,
                                        FinalScore = 0
                                    };

                                    await _FinalArbitrationRepository.AddAsync(NewFinalArbitrationEntity);
                                }
                            }
                        }
                    }
                    else
                    {
                        NewArbitrationEntity.FullScore = Request.InitialArbitrationMainCommand.Sum(x => x.ArbitrationScore!.Value);

                        await _ArbitrationRepository.UpdateAsync(NewArbitrationEntity);

                        List<Arbitration> CheckIfAllArbitratorsAreDone = await _ArbitrationRepository
                            .Where(x => x.ProvidedFormId == NewArbitrationEntity.ProvidedFormId &&
                                x.RollbackArbitrationId == null)
                            .ToListAsync();

                        if (CheckIfAllArbitratorsAreDone.All(x => x.Type == ArbitrationType.DoneArbitratod &&
                                x.isAcceptedFromChairman == FormStatus.Accepted &&
                                x.DateOfArbitration != null))
                        {
                            bool ItExceededTheMarginOfDifferenceInArbitrationScores = false;

                            int MarginOfDifferenceBetweenArbitrators = CheckIfAllArbitratorsAreDone
                                .Select(x => x.ProvidedForm!.Category!.MarginOfDifferenceBetweenArbitrators)
                                .FirstOrDefault();

                            foreach (Arbitration ArbitrationEntity1 in CheckIfAllArbitratorsAreDone)
                            {
                                foreach (Arbitration ArbitrationEntity2 in CheckIfAllArbitratorsAreDone)
                                {
                                    if (Math.Abs(ArbitrationEntity1.FullScore - ArbitrationEntity2.FullScore) > MarginOfDifferenceBetweenArbitrators)
                                    {
                                        ItExceededTheMarginOfDifferenceInArbitrationScores = true;
                                        break;
                                    }
                                }
                            }

                            if (!ItExceededTheMarginOfDifferenceInArbitrationScores)
                            {
                                await _ArbitrationRepository
                                    .Where(x => x.ProvidedFormId == NewArbitrationEntity.ProvidedFormId)
                                    .ExecuteUpdateAsync(x => x.SetProperty(y => y.DateOfArbitrationAuditing, DateTime.UtcNow)
                                        .SetProperty(y => y.ArbitrationAuditType, ArbitrationType.DoneArbitratod)
                                        .SetProperty(y => y.isAcceptedFromChairmanFromArbitrationAudit, FormStatus.Accepted));

                                int ArbitratorId = CheckIfAllArbitratorsAreDone.FirstOrDefault()!.ArbitratorId;

                                FinalArbitration? FinalArbitrationEntity = await _FinalArbitrationRepository
                                    .FirstOrDefaultAsync(x => x.ProvidedFormId == NewArbitrationEntity.ProvidedFormId);

                                if (FinalArbitrationEntity is null)
                                {
                                    FinalArbitration NewFinalArbitrationEntity = new FinalArbitration()
                                    {
                                        ReasonForRejecting = null,
                                        isAcceptedFromChairman = FormStatus.NotArbitratedYet,
                                        ArbitratorId = ArbitratorId,
                                        ProvidedFormId = NewArbitrationEntity.ProvidedFormId,
                                        Type = ArbitrationType.NotBeenArbitrated,
                                        DateOfArbitration = null,
                                        FullScore = 0,
                                        FinalScore = 0
                                    };

                                    await _FinalArbitrationRepository.AddAsync(NewFinalArbitrationEntity);
                                }
                            }
                        }
                    }

                    Transaction.Complete();

                    ResponseMessage = Request.lang == "en"
                        ? "Created successfully"
                        : "تم إنشاء التحكيم الأولي بنجاح";

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
