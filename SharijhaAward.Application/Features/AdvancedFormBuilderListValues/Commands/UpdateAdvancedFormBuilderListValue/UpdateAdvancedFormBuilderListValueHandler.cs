using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.AdvancedFormBuilderModel;
using System.Transactions;

namespace SharijhaAward.Application.Features.AdvancedFormBuilderListValues.Commands.UpdateAdvancedFormBuilderListValue
{
    public class UpdateAdvancedFormBuilderListValueHandler : IRequestHandler<UpdateAdvancedFormBuilderListValueCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<AdvancedFormBuilderListValue> _AdvancedFormBuilderListValueRepository;
        private readonly IAsyncRepository<AdvancedFormBuilderValue> _AdvancedFormBuilderValueRepository;
        private readonly IAsyncRepository<AdvancedFormBuilderTableValue> _AdvancedFormBuilderTableValueRepository;
        private readonly IMapper _Mapper;

        public UpdateAdvancedFormBuilderListValueHandler(IAsyncRepository<AdvancedFormBuilderListValue> AdvancedFormBuilderListValueRepository,
            IAsyncRepository<AdvancedFormBuilderValue> AdvancedFormBuilderValueRepository,
            IAsyncRepository<AdvancedFormBuilderTableValue> AdvancedFormBuilderTableValueRepository,
            IMapper Mapper)
        {
            _AdvancedFormBuilderListValueRepository = AdvancedFormBuilderListValueRepository;
            _AdvancedFormBuilderValueRepository = AdvancedFormBuilderValueRepository;
            _AdvancedFormBuilderTableValueRepository = AdvancedFormBuilderTableValueRepository;
            _Mapper = Mapper;
        }
        public async Task<BaseResponse<object>> Handle(UpdateAdvancedFormBuilderListValueCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            AdvancedFormBuilderListValue? AdvancedFormBuilderListValueOldData = await _AdvancedFormBuilderListValueRepository
                .FirstOrDefaultAsync(x => x.Id == Request.Id);

            if (AdvancedFormBuilderListValueOldData == null)
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
                    _Mapper.Map(Request, AdvancedFormBuilderListValueOldData, typeof(UpdateAdvancedFormBuilderListValueCommand),
                        typeof(AdvancedFormBuilderListValue));

                    await _AdvancedFormBuilderListValueRepository.UpdateAsync(AdvancedFormBuilderListValueOldData);

                    if (!AdvancedFormBuilderListValueOldData.AdvancedFormBuilder!.AdvancedFormBuilderSection!.TableTypeSection)
                        await _AdvancedFormBuilderValueRepository
                            .Where(x => x.AdvancedFormBuilderId == AdvancedFormBuilderListValueOldData.AdvancedFormBuilderId)
                            .ExecuteUpdateAsync(x => x.SetProperty(y => y.Value, Request.Value));

                    else
                        await _AdvancedFormBuilderTableValueRepository
                            .Where(x => x.AdvancedFormBuilderId == AdvancedFormBuilderListValueOldData.AdvancedFormBuilderId)
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
