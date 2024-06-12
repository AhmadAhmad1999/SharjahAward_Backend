using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.DynamicAttributeModel;
using System.Transactions;

namespace SharijhaAward.Application.Features.DynamicAttributePatterns.Commands.SelectPatternAsDynamicAttribute
{
    public class SelectPatternAsDynamicAttributeHandler : IRequestHandler<SelectPatternAsDynamicAttributeCommand,
        BaseResponse<SelectPatternAsDynamicAttributeResponse>>
    {
        private readonly IMapper _Mapper;
        private readonly IAsyncRepository<DynamicAttribute> _DynamicAttributeRepository;
        private readonly IAsyncRepository<DynamicAttributeListValue> _DynamicAttributeListValueRepository;
        private readonly IAsyncRepository<DynamicAttributePattern> _DynamicAttributePatternRepository;
        private readonly IAsyncRepository<DynamicAttributePatternValue> _DynamicAttributePatternValueRepository;
        private readonly IAsyncRepository<AttributeDataType> _AttributeDataTypeRepository;
        public SelectPatternAsDynamicAttributeHandler(IMapper Mapper,
            IAsyncRepository<DynamicAttribute> DynamicAttributeRepository,
            IAsyncRepository<DynamicAttributeListValue> DynamicAttributeListValueRepository,
            IAsyncRepository<DynamicAttributePattern> DynamicAttributePatternRepository,
            IAsyncRepository<DynamicAttributePatternValue> DynamicAttributePatternValueRepository,
            IAsyncRepository<AttributeDataType> AttributeDataTypeRepository)
        {
            _Mapper = Mapper;
            _DynamicAttributeRepository = DynamicAttributeRepository;
            _DynamicAttributeListValueRepository = DynamicAttributeListValueRepository;
            _DynamicAttributePatternRepository = DynamicAttributePatternRepository;
            _DynamicAttributePatternValueRepository = DynamicAttributePatternValueRepository;
            _AttributeDataTypeRepository = AttributeDataTypeRepository;
        }
        public async Task<BaseResponse<SelectPatternAsDynamicAttributeResponse>> Handle(SelectPatternAsDynamicAttributeCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            DynamicAttributePattern? SelectedDynamicAttributePattern = await _DynamicAttributePatternRepository
                .FirstOrDefaultAsync(x => x.Id == Request.DynamicAttributePatternId);

            if (SelectedDynamicAttributePattern == null)
            {
                ResponseMessage = Request.lang == "en"
                  ? "Pattern is not Found"
                  : "النموذج غير موجود";

                return new BaseResponse<SelectPatternAsDynamicAttributeResponse>(ResponseMessage, false, 404);
            }

            AttributeDataType? AttributeListDataTypeEntity = await _AttributeDataTypeRepository
                .FirstOrDefaultAsync(x => x.Name.ToLower() == "List".ToLower());

            if (AttributeListDataTypeEntity == null)
            {
                ResponseMessage = Request.lang == "en"
                  ? "Field type is not Found"
                  : "نوع الحقل غير موجود";

                return new BaseResponse<SelectPatternAsDynamicAttributeResponse>(ResponseMessage, false, 404);
            }

            DynamicAttribute NewDynamicAttributeEntity = _Mapper.Map<DynamicAttribute>(SelectedDynamicAttributePattern);
            NewDynamicAttributeEntity.Id = 0;
            NewDynamicAttributeEntity.CreatedAt = DateTime.UtcNow;
            NewDynamicAttributeEntity.DeletedAt = null;
            NewDynamicAttributeEntity.CreatedBy = null;
            NewDynamicAttributeEntity.LastModifiedAt = null;
            NewDynamicAttributeEntity.LastModifiedBy = null;
            NewDynamicAttributeEntity.LinkedToAnotherAttribute = false;
            NewDynamicAttributeEntity.DynamicAttributeSectionId = Request.DynamicAttributeSectionId;
            NewDynamicAttributeEntity.Status = Domain.Constants.DynamicAttribute.DynamicAttributeStatus.Active;
            NewDynamicAttributeEntity.AttributeDataTypeId = AttributeListDataTypeEntity.Id;
            NewDynamicAttributeEntity.ArabicTitle = SelectedDynamicAttributePattern.ArabicTitle;
            NewDynamicAttributeEntity.EnglishTitle = SelectedDynamicAttributePattern.EnglishTitle;

            using (TransactionScope Transaction = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled))
            {
                try
                {
                    await _DynamicAttributeRepository.AddAsync(NewDynamicAttributeEntity);

                    List<DynamicAttributeListValue> ListOfPatternValues = await _DynamicAttributePatternValueRepository
                        .Where(x => x.DynamicAttributePatternId == Request.DynamicAttributePatternId)
                        .Select(x => new DynamicAttributeListValue()
                        {
                            ArabicValue = x.ArabicValue,
                            EnglishValue = x.EnglishValue,
                            CreatedAt = DateTime.UtcNow,
                            CreatedBy = null,
                            DeletedAt = null,
                            DynamicAttributeId = NewDynamicAttributeEntity.Id,
                            isDeleted = false,
                            LastModifiedAt = null,
                            LastModifiedBy = null
                        }).ToListAsync();

                    await _DynamicAttributeListValueRepository.AddRangeAsync(ListOfPatternValues);

                    Transaction.Complete();
                }
                catch (Exception)
                {
                    Transaction.Dispose();
                    throw;
                }
            }

            return new BaseResponse<SelectPatternAsDynamicAttributeResponse>(ResponseMessage, true, 200);
        }
    }
}
