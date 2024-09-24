using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Features.ArbitrationAuditFeatures.Commands.CreateArbitrationAudit;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.ArbitrationModel;
using SharijhaAward.Domain.Entities.CriterionItemModel;
using SharijhaAward.Domain.Entities.CriterionModel;
using System.Transactions;

namespace SharijhaAward.Application.Features.InitialArbitrationFeatures.Commands.CreateInitialArbitration
{
    public class CreateInitialArbitrationHandler : IRequestHandler<CreateInitialArbitrationCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<InitialArbitration> _InitialArbitrationRepository;
        private readonly IAsyncRepository<Arbitration> _ArbitrationRepository;
        private readonly IAsyncRepository<Criterion> _CriterionRepository;
        private readonly IAsyncRepository<CriterionItem> _CriterionItemRepository;
        private readonly IMapper _Mapper;

        public CreateInitialArbitrationHandler(IAsyncRepository<InitialArbitration> InitialArbitrationRepository,
            IAsyncRepository<Arbitration> ArbitrationRepository,
            IAsyncRepository<Criterion> CriterionRepository,
            IAsyncRepository<CriterionItem> CriterionItemRepository,
            IMapper Mapper)
        {
            _InitialArbitrationRepository = InitialArbitrationRepository;
            _ArbitrationRepository = ArbitrationRepository;
            _CriterionRepository = CriterionRepository;
            _CriterionItemRepository = CriterionItemRepository;
            _Mapper = Mapper;
        }

        public async Task<BaseResponse<object>> Handle(CreateInitialArbitrationCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            Arbitration? ArbitrationEntity = await _ArbitrationRepository
                .FirstOrDefaultAsync(x => x.Id == Request.ArbitrationId);

            if (ArbitrationEntity is null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Arbitration is not Found"
                    : "التحكيم غير موجود";

                return new BaseResponse<object>(ResponseMessage, false, 404);
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
                .Where(x => x.ArbitrationId == ArbitrationEntity.Id)
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
                        ArbitrationEntity.DateOfArbitration = DateTime.UtcNow;
                        ArbitrationEntity.Type = ArbitrationType.DoneArbitratod;

                        ArbitrationEntity.isAcceptedFromChairman = FormStatus.NotArbitratedYet;
                    }

                    else
                        ArbitrationEntity.Type = ArbitrationType.BeingReviewed;

                    ArbitrationEntity.FullScore = Request.InitialArbitrationMainCommand.Sum(x => x.ArbitrationScore!.Value);

                    await _ArbitrationRepository.UpdateAsync(ArbitrationEntity);

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
