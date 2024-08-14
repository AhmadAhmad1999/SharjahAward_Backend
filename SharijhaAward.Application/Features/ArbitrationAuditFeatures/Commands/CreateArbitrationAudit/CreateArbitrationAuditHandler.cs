using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.ArbitrationModel;
using System.Transactions;

namespace SharijhaAward.Application.Features.ArbitrationAuditFeatures.Commands.CreateArbitrationAudit
{
    public class CreateArbitrationAuditHandler : IRequestHandler<CreateArbitrationAuditCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<ArbitrationAudit> _ArbitrationAuditRepository;
        private readonly IAsyncRepository<Arbitration> _ArbitrationRepository;
        private readonly IMapper _Mapper;

        public CreateArbitrationAuditHandler(IAsyncRepository<ArbitrationAudit> ArbitrationAuditRepository,
            IAsyncRepository<Arbitration> ArbitrationRepository,
            IMapper Mapper)
        {
            _ArbitrationAuditRepository = ArbitrationAuditRepository;
            _ArbitrationRepository = ArbitrationRepository;
            _Mapper = Mapper;
        }

        public async Task<BaseResponse<object>> Handle(CreateArbitrationAuditCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            IEnumerable<ArbitrationAuditMainCommand> ArbitrationAuditMainCommands = Request.ArbitrationAuditMainCommand
                .Where(x => x.ArbitrationScore != null);

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
                        if (ArbitrationAuditMainCommand.ArbitrationAuditId == 0)
                        {
                            ArbitrationAudit NewArbitrationAuditEntity = _Mapper.Map<ArbitrationAudit>(ArbitrationAuditMainCommand);

                            NewArbitrationAuditEntity.ArbitrationId = Request.ArbitrationId;

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
                                    : "التحكيم الأولي غير موجود";

                                return new BaseResponse<object>(ResponseMessage, false, 404);
                            }

                            ArbitrationAuditEntity.StrengthPoint = ArbitrationAuditMainCommand.StrengthPoint;
                            ArbitrationAuditEntity.ImprovementAreas = ArbitrationAuditMainCommand.ImprovementAreas;
                            ArbitrationAuditEntity.ArbitrationScore = ArbitrationAuditMainCommand.ArbitrationScore!.Value;

                            await _ArbitrationAuditRepository.UpdateAsync(ArbitrationAuditEntity);
                        }
                    }

                    Arbitration? ArbitrationEntity = await _ArbitrationRepository
                        .FirstOrDefaultAsync(x => x.Id == Request.ArbitrationId);

                    if (ArbitrationEntity is null)
                    {
                        ResponseMessage = Request.lang == "en"
                            ? "Arbitration is not Found"
                            : "التحكيم غير موجود";

                        return new BaseResponse<object>(ResponseMessage, false, 404);
                    }

                    if (Request.isDoneArbitration)
                    {
                        ArbitrationEntity.DateOfArbitration = DateTime.UtcNow;
                        ArbitrationEntity.Type = ArbitrationType.DoneArbitratod;
                    }

                    else
                        ArbitrationEntity.Type = ArbitrationType.BeingReviewed;

                    ArbitrationEntity.FullScore = Request.ArbitrationAuditMainCommand.Sum(x => x.ArbitrationScore!.Value);

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
