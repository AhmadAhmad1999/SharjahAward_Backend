using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.AdvancedFormBuilderModel;
using SharijhaAward.Domain.Entities.DynamicAttributeModel;
using System.Transactions;

namespace SharijhaAward.Application.Features.AdvancedFormBuilderPatterns.Commands.SelectPatternAsAdvancedFormBuilder
{
    public class SelectPatternAsAdvancedFormBuilderHandler 
        : IRequestHandler<SelectPatternAsAdvancedFormBuilderCommand, BaseResponse<object>>
    {
        private readonly IMapper _Mapper;
        private readonly IAsyncRepository<AdvancedFormBuilder> _AdvancedFormBuilderRepository;
        private readonly IAsyncRepository<AdvancedFormBuilderListValue> _AdvancedFormBuilderListValueRepository;
        private readonly IAsyncRepository<AdvancedFormBuilderPattern> _AdvancedFormBuilderPatternRepository;
        private readonly IAsyncRepository<AdvancedFormBuilderPatternValue> _AdvancedFormBuilderPatternValueRepository;
        private readonly IAsyncRepository<AttributeDataType> _AttributeDataTypeRepository;
        public SelectPatternAsAdvancedFormBuilderHandler(IMapper Mapper,
            IAsyncRepository<AdvancedFormBuilder> AdvancedFormBuilderRepository,
            IAsyncRepository<AdvancedFormBuilderListValue> AdvancedFormBuilderListValueRepository,
            IAsyncRepository<AdvancedFormBuilderPattern> AdvancedFormBuilderPatternRepository,
            IAsyncRepository<AdvancedFormBuilderPatternValue> AdvancedFormBuilderPatternValueRepository,
            IAsyncRepository<AttributeDataType> AttributeDataTypeRepository)
        {
            _Mapper = Mapper;
            _AdvancedFormBuilderRepository = AdvancedFormBuilderRepository;
            _AdvancedFormBuilderListValueRepository = AdvancedFormBuilderListValueRepository;
            _AdvancedFormBuilderPatternRepository = AdvancedFormBuilderPatternRepository;
            _AdvancedFormBuilderPatternValueRepository = AdvancedFormBuilderPatternValueRepository;
            _AttributeDataTypeRepository = AttributeDataTypeRepository;
        }

        public async Task<BaseResponse<object>> Handle(SelectPatternAsAdvancedFormBuilderCommand Request, CancellationToken cancellationToken)
        {
            return new BaseResponse<object>();
            string ResponseMessage = string.Empty;

            //    AdvancedFormBuilderPattern? SelectedAdvancedFormBuilderPattern = await _AdvancedFormBuilderPatternRepository
            //        .FirstOrDefaultAsync(x => x.Id == Request.AdvancedFormBuilderPatternId);

            //    if (SelectedAdvancedFormBuilderPattern == null)
            //    {
            //        ResponseMessage = Request.lang == "en"
            //          ? "Pattern is not Found"
            //          : "النموذج غير موجود";

            //        return new BaseResponse<object>(ResponseMessage, false, 404);
            //    }

            //    AttributeDataType? AttributeListDataTypeEntity = await _AttributeDataTypeRepository
            //        .FirstOrDefaultAsync(x => x.Name.ToLower() == "List".ToLower());

            //    if (AttributeListDataTypeEntity == null)
            //    {
            //        ResponseMessage = Request.lang == "en"
            //          ? "Field type is not Found"
            //          : "نوع الحقل غير موجود";

            //        return new BaseResponse<object>(ResponseMessage, false, 404);
            //    }

            //    AdvancedFormBuilder NewAdvancedFormBuilderEntity = _Mapper.Map<AdvancedFormBuilder>(SelectedAdvancedFormBuilderPattern);
            //    NewAdvancedFormBuilderEntity.Id = 0;
            //    NewAdvancedFormBuilderEntity.CreatedAt = DateTime.UtcNow;
            //    NewAdvancedFormBuilderEntity.DeletedAt = null;
            //    NewAdvancedFormBuilderEntity.CreatedBy = null;
            //    NewAdvancedFormBuilderEntity.LastModifiedAt = null;
            //    NewAdvancedFormBuilderEntity.LastModifiedBy = null;
            //    NewAdvancedFormBuilderEntity.LinkedToAnotherAttribute = false;
            //    NewAdvancedFormBuilderEntity.AdvancedFormBuilderSectionId = Request.AdvancedFormBuilderSectionId;
            //    NewAdvancedFormBuilderEntity.Status = Domain.Constants.DynamicAttribute.DynamicAttributeStatus.Active;
            //    NewAdvancedFormBuilderEntity.AttributeDataTypeId = AttributeListDataTypeEntity.Id;

            //    TransactionOptions TransactionOptions = new TransactionOptions
            //    {
            //        IsolationLevel = IsolationLevel.ReadCommitted,
            //        Timeout = TimeSpan.FromMinutes(5)
            //    };

            //    using (TransactionScope Transaction = new TransactionScope(TransactionScopeOption.Required,
            //        TransactionOptions, TransactionScopeAsyncFlowOption.Enabled))
            //    {
            //        try
            //        {
            //            await _AdvancedFormBuilderRepository.AddAsync(NewAdvancedFormBuilderEntity);

            //            List<AdvancedFormBuilderListValue> ListOfPatternValues = await _AdvancedFormBuilderPatternValueRepository
            //                .Where(x => x.AdvancedFormBuilderPatternId == Request.AdvancedFormBuilderPatternId)
            //                .Select(x => new AdvancedFormBuilderListValue()
            //                {
            //                    Value = x.Value,
            //                    CreatedAt = DateTime.UtcNow,
            //                    CreatedBy = null,
            //                    DeletedAt = null,
            //                    AdvancedFormBuilderId = NewAdvancedFormBuilderEntity.Id,
            //                    isDeleted = false,
            //                    LastModifiedAt = null,
            //                    LastModifiedBy = null
            //                }).ToListAsync();

            //            await _AdvancedFormBuilderListValueRepository.AddRangeAsync(ListOfPatternValues);

            //            Transaction.Complete();
            //        }
            //        catch (Exception)
            //        {
            //            Transaction.Dispose();
            //            throw;
            //        }
            //    }

            //    return new BaseResponse<object>(ResponseMessage, true, 200);
        }
    }
}
