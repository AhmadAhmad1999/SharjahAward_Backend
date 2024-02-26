using AutoMapper;
using FluentValidation;
using FluentValidation.Results;
using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Domain.Entities.DynamicAttributeModel;

namespace SharijhaAward.Application.Features.DynamicAttributeFeatures.Commands.UpdateDynamicAttribute
{
    public class UpdateDynamicAttributeHandler : IRequestHandler<UpdateDynamicAttributeCommand, Unit>
    {
        private readonly IAsyncRepository<DynamicAttribute> _DynamicAttributeRepository;
        private readonly IMapper _Mapper;

        public UpdateDynamicAttributeHandler(IAsyncRepository<DynamicAttribute> DynamicAttributeRepository,
            IMapper Mapper)
        {
            _DynamicAttributeRepository = DynamicAttributeRepository;
            _Mapper = Mapper;
        }
        public async Task<Unit> Handle(UpdateDynamicAttributeCommand Request, CancellationToken cancellationToken)
        {
            DynamicAttribute? DynamicAttributeOldData = await _DynamicAttributeRepository.GetByIdAsync(Request.Id);

            if (DynamicAttributeOldData == null)
                throw new OpenQA.Selenium.NotFoundException(!string.IsNullOrEmpty(Request.lang)
                    ? (Request.lang.ToLower() == "en"
                        ? "Dynamic field not found"
                        : "هذا الحقل غير موجود")
                    : "Dynamic field not found");

            UpdateDynamicAttributeValidator Validator = new UpdateDynamicAttributeValidator();
            ValidationResult ValidationResult = await Validator.ValidateAsync(Request);

            if (ValidationResult.Errors.Count > 0)
                throw new ValidationException(ValidationResult.Errors);

            else
            {
                _Mapper.Map(Request, DynamicAttributeOldData, typeof(UpdateDynamicAttributeCommand),
                    typeof(DynamicAttribute));

                await _DynamicAttributeRepository.UpdateAsync(DynamicAttributeOldData);
            }

            return Unit.Value;
        }
    }
}
