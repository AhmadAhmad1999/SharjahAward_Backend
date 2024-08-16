using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.ArbitrationModel;
using SharijhaAward.Domain.Entities.CriterionItemModel;
using SharijhaAward.Domain.Entities.CriterionModel;
using System.Transactions;

namespace SharijhaAward.Application.Features.ArbitrationAuditFeatures.Commands.CreateArbitrationAudit
{
    public class CreateArbitrationAuditHandler : IRequestHandler<CreateArbitrationAuditCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<ArbitrationAudit> _ArbitrationAuditRepository;
        private readonly IAsyncRepository<Arbitration> _ArbitrationRepository;
        private readonly IAsyncRepository<Criterion> _CriterionRepository;
        private readonly IAsyncRepository<CriterionItem> _CriterionItemRepository;
        private readonly IMapper _Mapper;

        public CreateArbitrationAuditHandler(IAsyncRepository<ArbitrationAudit> ArbitrationAuditRepository,
            IAsyncRepository<Arbitration> ArbitrationRepository,
            IAsyncRepository<Criterion> CriterionRepository,
            IAsyncRepository<CriterionItem> CriterionItemRepository,
            IMapper Mapper)
        {
            _ArbitrationAuditRepository = ArbitrationAuditRepository;
            _ArbitrationRepository = ArbitrationRepository;
            _CriterionRepository = CriterionRepository;
            _CriterionItemRepository = CriterionItemRepository;
            _Mapper = Mapper;
        }

        public async Task<BaseResponse<object>> Handle(CreateArbitrationAuditCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            IEnumerable<ArbitrationAuditMainCommand> ArbitrationAuditMainCommands = Request.ArbitrationAuditMainCommand
                .Where(x => x.ArbitrationScore != null);

            List<Criterion> CriterionEntities = await _CriterionRepository
                .Where(x => Request.ArbitrationAuditMainCommand
                    .Where(y => y.CriterionId != null).Select(y => y.CriterionId)
                    .Any(y => y == x.Id))
                .ToListAsync();

            List<CriterionItem> CriterionItemEntities = await _CriterionItemRepository
                .Where(x => Request.ArbitrationAuditMainCommand
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
                    foreach (ArbitrationAuditMainCommand ArbitrationAuditMainCommand in ArbitrationAuditMainCommands)
                    {
                        if (ArbitrationAuditMainCommand.CriterionId is not null &&
                            ArbitrationAuditMainCommand.CriterionItemId is null)
                        {
                            bool CheckInsertedScore = CriterionEntities
                                .FirstOrDefault(x => x.Id == ArbitrationAuditMainCommand.CriterionId)!
                                .Score < ArbitrationAuditMainCommand.ArbitrationScore;

                            if (CheckInsertedScore)
                            {
                                ResponseMessage = Request.lang == "en"
                                    ? "Final arbitration score can't be bigger than the criterion max score"
                                    : "لا يمكن أن تكون النتيجة النهائية للتحكيم أكبر من الحد الأقصى لنتيجة المعيار";

                                Transaction.Dispose();

                                return new BaseResponse<object>(ResponseMessage, false, 400);
                            }
                        }
                        else if (ArbitrationAuditMainCommand.CriterionItemId is not null)
                        {
                            bool CheckInsertedScore = CriterionItemEntities
                                .FirstOrDefault(x => x.Id == ArbitrationAuditMainCommand.CriterionItemId)!
                                .Score < ArbitrationAuditMainCommand.ArbitrationScore;

                            if (CheckInsertedScore)
                            {
                                ResponseMessage = Request.lang == "en"
                                    ? "Final arbitration score can't be bigger than the criterion item max score"
                                    : "لا يمكن أن تكون النتيجة النهائية للتحكيم أكبر من الحد الأقصى لنتيجة عنصر المعيار ";

                                Transaction.Dispose();

                                return new BaseResponse<object>(ResponseMessage, false, 400);
                            }
                        }

                        if (ArbitrationAuditMainCommand.ArbitrationAuditId == 0)
                        {
                            ArbitrationAudit NewArbitrationAuditEntity = _Mapper.Map<ArbitrationAudit>(ArbitrationAuditMainCommand);

                            NewArbitrationAuditEntity.ProvidedFormId = Request.FormId;

                            await _ArbitrationAuditRepository.AddAsync(NewArbitrationAuditEntity);
                        }
                        else
                        {
                            ArbitrationAudit? ArbitrationAuditEntity = await _ArbitrationAuditRepository
                                .FirstOrDefaultAsync(x => x.Id == ArbitrationAuditMainCommand.ArbitrationAuditId);

                            if (ArbitrationAuditEntity is null)
                            {
                                ResponseMessage = Request.lang == "en"
                                    ? "Arbitration audit is not Found"
                                    : "تدقيق التحكيم غير موجود";

                                return new BaseResponse<object>(ResponseMessage, false, 404);
                            }

                            ArbitrationAuditEntity.StrengthPoint = ArbitrationAuditMainCommand.StrengthPoint;
                            ArbitrationAuditEntity.ImprovementAreas = ArbitrationAuditMainCommand.ImprovementAreas;
                            ArbitrationAuditEntity.ArbitrationScore = ArbitrationAuditMainCommand.ArbitrationScore!.Value;

                            await _ArbitrationAuditRepository.UpdateAsync(ArbitrationAuditEntity);
                        }
                    }

                    List<Arbitration> ArbitrationEntities = await _ArbitrationRepository
                        .Where(x => x.ProvidedFormId == Request.FormId)
                        .ToListAsync();

                    if (!ArbitrationEntities.Any())
                    {
                        ResponseMessage = Request.lang == "en"
                            ? "Arbitration is not Found"
                            : "التحكيم غير موجود";

                        return new BaseResponse<object>(ResponseMessage, false, 404);
                    }

                    if (Request.isDoneArbitration)
                    {
                        foreach (Arbitration ArbitrationEntity in ArbitrationEntities)
                        {
                            ArbitrationEntity.DateOfArbitrationAuditing = DateTime.UtcNow;
                            ArbitrationEntity.ArbitrationAuditType = ArbitrationType.DoneArbitratod;
                        }
                    }

                    else
                    {
                        foreach (Arbitration ArbitrationEntity in ArbitrationEntities)
                        {
                            ArbitrationEntity.ArbitrationAuditType = ArbitrationType.BeingReviewed;
                        }
                    }

                    await _ArbitrationRepository.UpdateListAsync(ArbitrationEntities);

                    Transaction.Complete();

                    ResponseMessage = Request.lang == "en"
                        ? "Created successfully"
                        : "تم إنشاء تدقيق التحكيم بنجاح";

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
