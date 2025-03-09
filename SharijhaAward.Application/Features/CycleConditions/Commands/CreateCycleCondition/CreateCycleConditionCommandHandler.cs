using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.CycleConditionModel;
using SharijhaAward.Domain.Entities.CycleModel;
using System.Transactions;

namespace SharijhaAward.Application.Features.CycleConditions.Commands.CreateCycleCondition
{
    public class CreateCycleConditionCommandHandler
        : IRequestHandler<CreateCycleConditionCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<CycleCondition> _CycleConditionRepository;
        private readonly IAsyncRepository<Cycle> _CycleRepository;
        private readonly IMapper _Mapper;
        private readonly IAsyncRepository<CycleConditionAttachmentType> _CycleConditionAttachmentTypeRepository;

        public CreateCycleConditionCommandHandler(
            IAsyncRepository<CycleCondition> _CycleConditionRepository,
            IAsyncRepository<Cycle> _CycleRepository,
            IMapper _Mapper,
            IAsyncRepository<CycleConditionAttachmentType> _CycleConditionAttachmentTypeRepository)
        {
            this._CycleConditionRepository = _CycleConditionRepository;
            this._CycleRepository = _CycleRepository;
            this._Mapper = _Mapper;
            this._CycleConditionAttachmentTypeRepository = _CycleConditionAttachmentTypeRepository;
        }

        public async Task<BaseResponse<object>> Handle(CreateCycleConditionCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            Cycle? CycleEntity = await _CycleRepository
                .FirstOrDefaultAsync(x => x.Id == Request.CycleId);

            if (CycleEntity is null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Cycle is not Found"
                    : "الدورة غير موجودة";

                return new BaseResponse<object>(ResponseMessage, false, 404);
            }

            if (CycleEntity.Status == Domain.Constants.Common.Status.Close)
            {
                ResponseMessage = Request.lang == "en"
                    ? "The status of cycle is close"
                    : "حالة الدورة مغلقة";

                return new BaseResponse<object>(ResponseMessage, false, 400);
            }

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
                    CycleCondition NewCycleConditionEntity = _Mapper.Map<CycleCondition>(Request);

                    await _CycleConditionRepository.AddAsync(NewCycleConditionEntity);

                    IEnumerable<CycleConditionAttachmentType> NewCycleConditionAttachmentTypeEntities = Request.AttachmentType
                        .Select(x => new CycleConditionAttachmentType()
                        {
                            AttachmentType = x,
                            CycleConditionId = NewCycleConditionEntity.Id
                        });

                    await _CycleConditionAttachmentTypeRepository.AddRangeAsync(NewCycleConditionAttachmentTypeEntities);

                    ResponseMessage = Request.lang == "en"
                        ? "The Cycle Condition has been Created"
                        : "تم إضافة شرط الدورة بنجاح";

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
