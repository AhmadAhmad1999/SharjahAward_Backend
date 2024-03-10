using AutoMapper;
using FluentValidation;
using FluentValidation.Results;
using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.DynamicAttributeModel;

namespace SharijhaAward.Application.Features.DynamicAttributeFeatures.Commands.UpdateDynamicAttribute
{
    public class UpdateDynamicAttributeHandler : IRequestHandler<UpdateDynamicAttributeCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<DynamicAttribute> _DynamicAttributeRepository;
        private readonly IMapper _Mapper;

        public UpdateDynamicAttributeHandler(IAsyncRepository<DynamicAttribute> DynamicAttributeRepository,
            IMapper Mapper)
        {
            _DynamicAttributeRepository = DynamicAttributeRepository;
            _Mapper = Mapper;
        }
        public async Task<BaseResponse<object>> Handle(UpdateDynamicAttributeCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            DynamicAttribute? DynamicAttributeOldData = await _DynamicAttributeRepository.GetByIdAsync(Request.Id);

            if (DynamicAttributeOldData == null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Field not found"
                    : "هذا الحقل غير موجود";

                return new BaseResponse<object>(ResponseMessage, false, 404);
            }
            
            UpdateDynamicAttributeValidator Validator = new UpdateDynamicAttributeValidator();
            ValidationResult ValidationResult = await Validator.ValidateAsync(Request);

            if (ValidationResult.Errors.Count > 0)
                throw new ValidationException(ValidationResult.Errors);

            _Mapper.Map(Request, DynamicAttributeOldData, typeof(UpdateDynamicAttributeCommand),
                typeof(DynamicAttribute));

            await _DynamicAttributeRepository.UpdateAsync(DynamicAttributeOldData);

            ResponseMessage = Request.lang == "en"
                ? "Field has been updated successfully"
                : "تم تعديل الحقل بنجاح";

            return new BaseResponse<object>(ResponseMessage, true, 200);
        }
    }
}
