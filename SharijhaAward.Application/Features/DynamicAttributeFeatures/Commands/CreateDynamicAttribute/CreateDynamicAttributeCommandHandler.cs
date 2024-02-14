using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Features.DynamicAttributeFeaturesFeatures.Commands.CreateDynamicAttribute;
using SharijhaAward.Application.Features.Event.Commands.CreateEvent;
using SharijhaAward.Domain.Constants.DynamicAttribute;
using SharijhaAward.Domain.Entities.DynamicAttributeModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.DynamicAttributeFeatures.Commands.CreateDynamicAttribute
{
    public class CreateDynamicAttributeCommandHandler : IRequestHandler<CreateDynamicAttributeCommand, CreateDynamicAttributeCommandResponse>
    {
        private readonly IAsyncRepository<DynamicAttribute> _DynamicAttributeRepository;
        private readonly IAsyncRepository<GeneralValidation> _GeneralValidationRepository;
        private readonly IMapper _Mapper;
        public CreateDynamicAttributeCommandHandler(IAsyncRepository<DynamicAttribute> DynamicAttributeRepository,
            IAsyncRepository<GeneralValidation> GeneralValidationRepository,
            IMapper Mapper)
        {
            _DynamicAttributeRepository = DynamicAttributeRepository;
            _GeneralValidationRepository = GeneralValidationRepository;
            _Mapper = Mapper;
        }
        public async Task<CreateDynamicAttributeCommandResponse> Handle(CreateDynamicAttributeCommand Request, CancellationToken cancellationToken)
        {
            // Add Dynamic Attribute Main Data..
            DynamicAttribute NewDynamicAttributeEntity = _Mapper.Map<DynamicAttribute>(Request);
            NewDynamicAttributeEntity.Status = DynamicAttributeStatus.Active;
            
            await _DynamicAttributeRepository.AddAsync(NewDynamicAttributeEntity);

            // Add General Validaiton if The Request.GeneralValidationObject is NOT NULL..
            if (Request.GeneralValidationObject is not null)
            {
                GeneralValidation NewGeneralValidationEntity = _Mapper.Map<GeneralValidation>(Request.GeneralValidationObject);
                NewGeneralValidationEntity.DynamicAttributeId = NewDynamicAttributeEntity.Id;

                await _GeneralValidationRepository.AddAsync(NewGeneralValidationEntity);
            }

            // Add Dependency Validaiton if The Request.DependencyValidations is NOT NULL..
            if (Request.DependencyValidations is not null)
            {
                foreach (CreateDependencyValidation DependencyValidationDTO in Request.DependencyValidations)
                {
                    foreach (CreateDependency DependencyDTO in DependencyValidationDTO.Dependencies)
                    {
                        DependencyGroup NewDependencyGroup = new DependencyGroup();


                        Dependency NewDependencyEntity = _Mapper.Map<Dependency>(DependencyDTO);
                    }
                }
            }

            throw new NotImplementedException();
        }
    }
}
