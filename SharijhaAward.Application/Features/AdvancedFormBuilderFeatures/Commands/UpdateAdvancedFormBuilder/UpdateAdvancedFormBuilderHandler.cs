using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.AdvancedFormBuilderModel;
using System.Transactions;

namespace SharijhaAward.Application.Features.AdvancedFormBuilderFeatures.Commands.UpdateAdvancedFormBuilder
{
    public class UpdateAdvancedFormBuilderHandler : IRequestHandler<UpdateAdvancedFormBuilderCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<AdvancedFormBuilder> _AdvancedFormBuilderRepository;
        private readonly IAsyncRepository<AdvancedFormBuilderListValue> _AdvancedFormBuilderListValueRepository;
        private readonly IMapper _Mapper;

        public UpdateAdvancedFormBuilderHandler(IAsyncRepository<AdvancedFormBuilder> AdvancedFormBuilderRepository,
            IAsyncRepository<AdvancedFormBuilderListValue> AdvancedFormBuilderListValueRepository,
            IMapper Mapper)
        {
            _AdvancedFormBuilderRepository = AdvancedFormBuilderRepository;
            _AdvancedFormBuilderListValueRepository = AdvancedFormBuilderListValueRepository;
            _Mapper = Mapper;
        }

        public async Task<BaseResponse<object>> Handle(UpdateAdvancedFormBuilderCommand Request, CancellationToken cancellationToken)
        {
            return new BaseResponse<object>();
            //TransactionOptions TransactionOptions = new TransactionOptions
            //{
            //    IsolationLevel = IsolationLevel.ReadCommitted,
            //    Timeout = TimeSpan.FromMinutes(5)
            //};

            //using (TransactionScope Transaction = new TransactionScope(TransactionScopeOption.Required,
            //    TransactionOptions, TransactionScopeAsyncFlowOption.Enabled))
            //{
            //    try
            //    {
            //        string ResponseMessage = string.Empty;

            //        AdvancedFormBuilder? AdvancedFormBuilderOldData = await _AdvancedFormBuilderRepository.GetByIdAsync(Request.Id);

            //        if (AdvancedFormBuilderOldData == null)
            //        {
            //            ResponseMessage = Request.lang == "en"
            //                ? "Field not found"
            //                : "هذا الحقل غير موجود";

            //            return new BaseResponse<object>(ResponseMessage, false, 404);
            //        }

            //        _Mapper.Map(Request, AdvancedFormBuilderOldData, typeof(UpdateAdvancedFormBuilderCommand),
            //            typeof(AdvancedFormBuilder));

            //        await _AdvancedFormBuilderRepository.UpdateAsync(AdvancedFormBuilderOldData);

            //        if (Request.Values is not null
            //                ? Request.Values.Any()
            //                : false)
            //        {
            //            List<AdvancedFormBuilderListValue> OldAdvancedFormBuilderValueEntities = await _AdvancedFormBuilderListValueRepository
            //                .Where(x => x.AdvancedFormBuilderId == Request.Id)
            //                .ToListAsync();

            //            List<AdvancedFormBuilderListValue> NewAdvancedFormBuilderListValuesEntities = Request.Values
            //                .Where(x => x.Id == 0)
            //                .Select(x => new AdvancedFormBuilderListValue()
            //                {
            //                    Value = x.Value,
            //                    AdvancedFormBuilderId = Request.Id
            //                }).ToList();

            //            if (NewAdvancedFormBuilderListValuesEntities.Any())
            //                await _AdvancedFormBuilderListValueRepository.AddRangeAsync(NewAdvancedFormBuilderListValuesEntities);

            //            IEnumerable<UpdateAdvancedFormBuilderValueDto> UpdatedAdvancedFormBuilderListValues = Request.Values
            //                .Where(x => x.Id != 0);

            //            foreach (UpdateAdvancedFormBuilderValueDto AdvancedFormBuilderValue in UpdatedAdvancedFormBuilderListValues)
            //            {
            //                AdvancedFormBuilderListValue? AdvancedFormBuilderListValueEntity = OldAdvancedFormBuilderValueEntities
            //                    .FirstOrDefault(x => x.Id == AdvancedFormBuilderValue.Id);

            //                if (AdvancedFormBuilderListValueEntity is not null)
            //                {
            //                    if (AdvancedFormBuilderListValueEntity.Value.ToLower() != AdvancedFormBuilderValue.Value.ToLower())
            //                    {
            //                        AdvancedFormBuilderListValueEntity.Value = AdvancedFormBuilderValue.Value;

            //                        await _AdvancedFormBuilderListValueRepository.UpdateAsync(AdvancedFormBuilderListValueEntity);
            //                    }
            //                }
            //            }
            //        }

            //        Transaction.Complete();

            //        ResponseMessage = Request.lang == "en"
            //            ? "Field has been updated successfully"
            //            : "تم تعديل الحقل بنجاح";

            //        return new BaseResponse<object>(ResponseMessage, true, 200);
            //    }
            //    catch (Exception)
            //    {
            //        Transaction.Dispose();
            //        throw;
            //    }
            //}
        }
    }
}
