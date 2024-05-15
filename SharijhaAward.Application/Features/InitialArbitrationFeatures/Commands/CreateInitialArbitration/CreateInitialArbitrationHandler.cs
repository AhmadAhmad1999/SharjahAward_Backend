using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.ArbitrationModel;
using System.Transactions;

namespace SharijhaAward.Application.Features.InitialArbitrationFeatures.Commands.CreateInitialArbitration
{
    public class CreateInitialArbitrationHandler : IRequestHandler<CreateInitialArbitrationCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<InitialArbitration> _InitialArbitrationRepository;
        private readonly IAsyncRepository<Arbitration> _ArbitrationRepository;
        private readonly IMapper _Mapper;

        public CreateInitialArbitrationHandler(IAsyncRepository<InitialArbitration> InitialArbitrationRepository,
            IAsyncRepository<Arbitration> ArbitrationRepository,
            IMapper Mapper)
        {
            _InitialArbitrationRepository = InitialArbitrationRepository;
            _ArbitrationRepository = ArbitrationRepository;
            _Mapper = Mapper;
        }

        public async Task<BaseResponse<object>> Handle(CreateInitialArbitrationCommand Request, CancellationToken cancellationToken)
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
                    foreach (InitialArbitrationMainCommand InitialArbitrationMainCommand in Request.InitialArbitrationMainCommand)
                    {
                        if (InitialArbitrationMainCommand.InitialArbitrationId == 0)
                        {
                            InitialArbitration NewArbitrationEntity = _Mapper.Map<InitialArbitration>(InitialArbitrationMainCommand);

                            NewArbitrationEntity.ArbitrationId = Request.ArbitrationId;

                            await _InitialArbitrationRepository.AddAsync(NewArbitrationEntity);
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
                            InitialArbitrationEntity.ArbitrationScore = InitialArbitrationMainCommand.ArbitrationScore;

                            await _InitialArbitrationRepository.UpdateAsync(InitialArbitrationEntity);
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

                        ArbitrationEntity.FullScore = Request.InitialArbitrationMainCommand.Sum(x => x.ArbitrationScore);
                    }

                    else
                        ArbitrationEntity.Type = ArbitrationType.BeingReviewed;

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
