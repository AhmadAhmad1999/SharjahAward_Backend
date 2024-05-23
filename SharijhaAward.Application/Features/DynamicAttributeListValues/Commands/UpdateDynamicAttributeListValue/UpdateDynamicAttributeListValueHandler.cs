using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.DynamicAttributeModel;
using System.Transactions;
namespace SharijhaAward.Application.Features.DynamicAttributeListValues.Commands.UpdateDynamicAttributeListValue
{
    public class UpdateDynamicAttributeListValueHandler : IRequestHandler<UpdateDynamicAttributeListValueCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<DynamicAttributeListValue> _DynamicAttributeListValueRepository;
        private readonly IAsyncRepository<DynamicAttributeValue> _DynamicAttributeValueRepository;
        private readonly IAsyncRepository<DynamicAttributeTableValue> _DynamicAttributeTableValueRepository;
        private readonly IMapper _Mapper;

        public UpdateDynamicAttributeListValueHandler(IAsyncRepository<DynamicAttributeListValue> DynamicAttributeListValueRepository,
            IAsyncRepository<DynamicAttributeValue> DynamicAttributeValueRepository,
            IAsyncRepository<DynamicAttributeTableValue> DynamicAttributeTableValueRepository,
            IMapper Mapper)
        {
            _DynamicAttributeListValueRepository = DynamicAttributeListValueRepository;
            _DynamicAttributeValueRepository = DynamicAttributeValueRepository;
            _DynamicAttributeTableValueRepository = DynamicAttributeTableValueRepository;
            _Mapper = Mapper;
        }
        public async Task<BaseResponse<object>> Handle(UpdateDynamicAttributeListValueCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            DynamicAttributeListValue? DynamicAttributeListValueOldData = await _DynamicAttributeListValueRepository
                .Include(x => x.DynamicAttribute!)
                .Include(x => x.DynamicAttribute!.DynamicAttributeSection!)
                .FirstOrDefaultAsync(x => x.Id == Request.Id);

            if (DynamicAttributeListValueOldData == null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Value is not found"
                    : "هذه القيمة غير موجودة";

                return new BaseResponse<object>(ResponseMessage, false, 404);
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
                    _Mapper.Map(Request, DynamicAttributeListValueOldData, typeof(UpdateDynamicAttributeListValueCommand),
                        typeof(DynamicAttributeListValue));

                    await _DynamicAttributeListValueRepository.UpdateAsync(DynamicAttributeListValueOldData);

                    if (!DynamicAttributeListValueOldData.DynamicAttribute!.DynamicAttributeSection!.TableTypeSection)
                        await _DynamicAttributeValueRepository
                            .Where(x => x.DynamicAttributeId == DynamicAttributeListValueOldData.DynamicAttributeId)
                            .ExecuteUpdateAsync(x => x.SetProperty(y => y.Value, Request.Value));

                    else
                        await _DynamicAttributeTableValueRepository
                            .Where(x => x.DynamicAttributeId == DynamicAttributeListValueOldData.DynamicAttributeId)
                            .ExecuteUpdateAsync(x => x.SetProperty(y => y.Value, Request.Value));

                    Transaction.Complete();

                    ResponseMessage = Request.lang == "en"
                        ? "Value has been updated successfully"
                        : "تم تعديل القيمة بنجاح";

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
