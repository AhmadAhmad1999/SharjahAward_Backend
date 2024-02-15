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
using System.Transactions;

namespace SharijhaAward.Application.Features.DynamicAttributeFeatures.Commands.CreateDynamicAttribute
{
    public class CreateDynamicAttributeCommandHandler : IRequestHandler<CreateDynamicAttributeCommand, CreateDynamicAttributeCommandResponse>
    {
        private readonly IAsyncRepository<DynamicAttribute> _DynamicAttributeRepository;
        private readonly IAsyncRepository<GeneralValidation> _GeneralValidationRepository;
        private readonly IAsyncRepository<DependencyGroup> _DependencyGroupRepository;
        private readonly IAsyncRepository<Dependency> _DependencyRepository;
        private readonly IAsyncRepository<DependencyValidation> _DependencyValidationRepository;
        private readonly IMapper _Mapper;
        public CreateDynamicAttributeCommandHandler(IAsyncRepository<DynamicAttribute> DynamicAttributeRepository,
            IAsyncRepository<GeneralValidation> GeneralValidationRepository,
            IAsyncRepository<DependencyGroup> DependencyGroupRepository,
            IAsyncRepository<Dependency> DependencyRepository,
            IAsyncRepository<DependencyValidation> DependencyValidationRepository,
            IMapper Mapper)
        {
            _DynamicAttributeRepository = DynamicAttributeRepository;
            _GeneralValidationRepository = GeneralValidationRepository;
            _DependencyGroupRepository = DependencyGroupRepository;
            _DependencyRepository = DependencyRepository;
            _DependencyValidationRepository = DependencyValidationRepository;
            _Mapper = Mapper;
        }
        public async Task<CreateDynamicAttributeCommandResponse> Handle(CreateDynamicAttributeCommand Request, CancellationToken cancellationToken)
        {
            TransactionOptions TransactionOptions = new TransactionOptions
            {
                IsolationLevel = IsolationLevel.ReadCommitted,
                Timeout = TimeSpan.FromSeconds(30)
            };

            using (TransactionScope Transaction = new TransactionScope(TransactionScopeOption.Required,
                TransactionOptions, TransactionScopeAsyncFlowOption.Enabled))
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
                        // Create New DependencyGroupId To Combine The Group Of Dependenies With Each Other and With Their Validation..
                        DependencyGroup NewDependencyGroup = new DependencyGroup();
                        await _DependencyGroupRepository.AddAsync(NewDependencyGroup);

                        foreach (CreateDependency DependencyDTO in DependencyValidationDTO.Dependencies)
                        {
                            Dependency NewDependencyEntity = _Mapper.Map<Dependency>(DependencyDTO);
                            NewDependencyEntity.DependencyGroupId = NewDependencyGroup.Id;
                            NewDependencyEntity.MainDynamicAttributeId = NewDynamicAttributeEntity.Id;
                            await _DependencyRepository.AddAsync(NewDependencyEntity);
                        }

                        DependencyValidation NewDependencyValidationEntity = _Mapper.Map<DependencyValidation>(DependencyValidationDTO);
                        NewDependencyValidationEntity.DependencyGroupId = NewDependencyGroup.Id;
                        await _DependencyValidationRepository.AddAsync(NewDependencyValidationEntity);
                    }
                }

                Transaction.Complete();

                return new CreateDynamicAttributeCommandResponse()
                {
                    CreateDynamicAttributeDto = new CreateDynamicAttributeDto()
                    {
                        Id = NewDynamicAttributeEntity.Id,
                        Key = NewDynamicAttributeEntity.Key,
                        ArabicLabel = NewDynamicAttributeEntity.ArabicLabel,
                        EnglishLabel = NewDynamicAttributeEntity.EnglishLabel
                    }
                };
            }
        }
    }
}
