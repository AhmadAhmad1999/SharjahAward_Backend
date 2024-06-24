using AutoMapper;
using FluentValidation;
using FluentValidation.Results;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.DynamicAttributeModel;
using System.Transactions;

namespace SharijhaAward.Application.Features.DynamicAttributeFeatures.Commands.UpdateDynamicAttribute
{
    public class UpdateDynamicAttributeHandler : IRequestHandler<UpdateDynamicAttributeCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<DynamicAttribute> _DynamicAttributeRepository;
        private readonly IAsyncRepository<DynamicAttributeListValue> _DynamicAttributeListValueRepository;
        private readonly IMapper _Mapper;

        public UpdateDynamicAttributeHandler(IAsyncRepository<DynamicAttribute> DynamicAttributeRepository,
            IAsyncRepository<DynamicAttributeListValue> DynamicAttributeListValueRepository,
            IMapper Mapper)
        {
            _DynamicAttributeRepository = DynamicAttributeRepository;
            _DynamicAttributeListValueRepository = DynamicAttributeListValueRepository;
            _Mapper = Mapper;
        }
        public async Task<BaseResponse<object>> Handle(UpdateDynamicAttributeCommand Request, CancellationToken cancellationToken)
        {
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
                    string ResponseMessage = string.Empty;

                    DynamicAttribute? DynamicAttributeOldData = await _DynamicAttributeRepository
                        .Include(x => x.DynamicAttributeSection!)
                        .FirstOrDefaultAsync(x => x.Id == Request.Id);

                    if (DynamicAttributeOldData == null)
                    {
                        ResponseMessage = Request.lang == "en"
                            ? "Field not found"
                            : "هذا الحقل غير موجود";

                        return new BaseResponse<object>(ResponseMessage, false, 404);
                    }

                    if (DynamicAttributeOldData.DynamicAttributeSection!.TableTypeSection)
                    {
                        Request.IsRequired = false;
                    }

                    UpdateDynamicAttributeValidator Validator = new UpdateDynamicAttributeValidator();
                    ValidationResult ValidationResult = await Validator.ValidateAsync(Request);

                    if (ValidationResult.Errors.Count > 0)
                        throw new ValidationException(ValidationResult.Errors);

                    _Mapper.Map(Request, DynamicAttributeOldData, typeof(UpdateDynamicAttributeCommand),
                        typeof(DynamicAttribute));

                    await _DynamicAttributeRepository.UpdateAsync(DynamicAttributeOldData);

                    List<DynamicAttributeListValue> OldDynamicAttributeValueEntities = await _DynamicAttributeListValueRepository
                        .Where(x => x.DynamicAttributeId == Request.Id)
                        .ToListAsync();

                    if (Request.Values is not null
                        ? Request.Values.Any()
                        : false)
                    {
                        List<DynamicAttributeListValue> NewDynamicAttributeListValuesEntities = Request.Values
                            .Where(x => x.Id == 0)
                            .Select(x => new DynamicAttributeListValue()
                            {
                                ArabicValue = x.ArabicValue,
                                EnglishValue = x.EnglishValue,
                                DynamicAttributeId = Request.Id
                            }).ToList();

                        if (NewDynamicAttributeListValuesEntities.Any())
                            await _DynamicAttributeListValueRepository.AddRangeAsync(NewDynamicAttributeListValuesEntities);

                        IEnumerable<UpdateDynamicAttributeValueDto> UpdatedDynamicAttributeListValues = Request.Values
                            .Where(x => x.Id != 0);

                        foreach (UpdateDynamicAttributeValueDto DynamicAttributeValue in UpdatedDynamicAttributeListValues)
                        {
                            DynamicAttributeListValue? DynamicAttributeListValueEntity = OldDynamicAttributeValueEntities
                                .FirstOrDefault(x => x.Id == DynamicAttributeValue.Id);

                            if (DynamicAttributeListValueEntity is not null)
                            {
                                if (DynamicAttributeListValueEntity.ArabicValue.ToLower() != DynamicAttributeValue.ArabicValue.ToLower() ||
                                    DynamicAttributeListValueEntity.EnglishValue.ToLower() != DynamicAttributeValue.EnglishValue.ToLower())
                                {
                                    DynamicAttributeListValueEntity.EnglishValue = DynamicAttributeValue.EnglishValue;
                                    DynamicAttributeListValueEntity.ArabicValue = DynamicAttributeValue.ArabicValue;

                                    await _DynamicAttributeListValueRepository.UpdateAsync(DynamicAttributeListValueEntity);
                                }
                            }
                        }
                    }

                    List<DynamicAttributeListValue> DeleteDynamicAttributeListValuesEntities = OldDynamicAttributeValueEntities
                        .Where(x => Request.Values != null
                            ? !Request.Values.Select(y => y.Id).Contains(x.Id)
                            : true)
                        .ToList();

                    if (DeleteDynamicAttributeListValuesEntities.Any())
                    {
                        await _DynamicAttributeListValueRepository.DeleteListAsync(DeleteDynamicAttributeListValuesEntities);
                    }

                    Transaction.Complete();

                    ResponseMessage = Request.lang == "en"
                        ? "Field has been updated successfully"
                        : "تم تعديل الحقل بنجاح";

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
