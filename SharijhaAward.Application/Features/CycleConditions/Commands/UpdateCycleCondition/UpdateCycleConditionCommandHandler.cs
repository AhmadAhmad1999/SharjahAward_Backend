using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.CycleConditionModel;
using System.Transactions;

namespace SharijhaAward.Application.Features.CycleConditions.Commands.UpdateCycleCondition
{
    public class UpdateCycleConditionCommandHandler
        : IRequestHandler<UpdateCycleConditionCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<CycleCondition> _CycleConditionRepository;
        private readonly IMapper _Mapper;
        private readonly IAsyncRepository<CycleConditionAttachmentType> _CycleConditionAttachmentTypeRepository;

        public UpdateCycleConditionCommandHandler(IAsyncRepository<CycleCondition> _CycleConditionRepository,
            IMapper _Mapper,
            IAsyncRepository<CycleConditionAttachmentType> _CycleConditionAttachmentTypeRepository)
        {
            this._CycleConditionRepository = _CycleConditionRepository;
            this._Mapper = _Mapper;
            this._CycleConditionAttachmentTypeRepository = _CycleConditionAttachmentTypeRepository;
        }

        public async Task<BaseResponse<object>> Handle(UpdateCycleConditionCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            CycleCondition? CycleConditionEntity = await _CycleConditionRepository
                .FirstOrDefaultAsync(x => x.Id == Request.Id);
            
            if (CycleConditionEntity is null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Cycle condition is not found"
                    : "شرط الدورة غير موجود";

                return new BaseResponse<object>(ResponseMessage, false, 404);
            }

            _Mapper.Map(Request, CycleConditionEntity, typeof(UpdateCycleConditionCommand), typeof(CycleCondition));

            List<CycleConditionAttachmentType> CycleConditionAttachmentTypeEntitiesToDelete = _CycleConditionAttachmentTypeRepository
                .Where(x => x.CycleConditionId == Request.Id)
                .ToList();

            List<CycleConditionAttachmentType> NewCycleConditionAttachmentTypeEntities = Request.AttachmentType
                .Select(x => new CycleConditionAttachmentType()
                {
                    CycleConditionId = Request.Id,
                    AttachmentType = x
                }).ToList();

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
                    await _CycleConditionRepository.UpdateAsync(CycleConditionEntity);

                    if (CycleConditionAttachmentTypeEntitiesToDelete.Any())
                        await _CycleConditionAttachmentTypeRepository.DeleteListAsync(CycleConditionAttachmentTypeEntitiesToDelete);

                    if (NewCycleConditionAttachmentTypeEntities.Any())
                        await _CycleConditionAttachmentTypeRepository.AddRangeAsync(NewCycleConditionAttachmentTypeEntities);

                    ResponseMessage = Request.lang == "en"
                        ? "Cycle condition has been updated successfully"
                        : "تم تعديل شرط الدورة بنجاح";

                    Transaction.Complete();

                    return new BaseResponse<object>(ResponseMessage, false, 200);
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
