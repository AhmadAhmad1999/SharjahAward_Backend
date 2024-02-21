using AutoMapper;
using FluentValidation;
using FluentValidation.Results;
using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Features.Event.Commands.UpdateEvent;
using SharijhaAward.Domain.Entities.DynamicAttributeModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.DynamicAttributeSectionsFeatures.Commands.UpdateDynamicAttributeSection
{
    public class UpdateDynamicAttributeSectionHandler : IRequestHandler<UpdateDynamicAttributeSectionCommand, Unit>
    {
        private readonly IAsyncRepository<DynamicAttributeSection> _DynamicAttributeSectionRepository;
        private readonly IMapper _Mapper;

        public UpdateDynamicAttributeSectionHandler(IAsyncRepository<DynamicAttributeSection> DynamicAttributeSectionRepository, 
            IMapper Mapper)
        {
            _DynamicAttributeSectionRepository = DynamicAttributeSectionRepository;
            _Mapper = Mapper;
        }
        public async Task<Unit> Handle(UpdateDynamicAttributeSectionCommand Request, CancellationToken cancellationToken)
        {
            DynamicAttributeSection? DynamicAttributeSectionOldData = await _DynamicAttributeSectionRepository.GetByIdAsync(Request.Id);

            if (DynamicAttributeSectionOldData == null)
                throw new OpenQA.Selenium.NotFoundException("Section Not found");

            UpdateDynamicAttributeSectionValidator Validator = new UpdateDynamicAttributeSectionValidator();
            ValidationResult ValidationResult = await Validator.ValidateAsync(Request);

            if (ValidationResult.Errors.Count > 0)
                throw new ValidationException(ValidationResult.Errors);

            else
            {
                _Mapper.Map(Request, DynamicAttributeSectionOldData, typeof(UpdateDynamicAttributeSectionCommand),
                    typeof(DynamicAttributeSection));

                await _DynamicAttributeSectionRepository.UpdateAsync(DynamicAttributeSectionOldData);
            }

            return Unit.Value;
        }
    }
}
