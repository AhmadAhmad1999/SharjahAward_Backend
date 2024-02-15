using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Features.DynamicAttributeFeatures.Commands.CreateDynamicAttribute;
using SharijhaAward.Domain.Entities.DynamicAttributeModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.DynamicAttributeSectionsFeatures.Commands.CreateDynamicAttributeSection
{
    public class CreateDynamicAttributeSectionCommandHandler : IRequestHandler<CreateDynamicAttributeSectionCommand, CreateDynamicAttributeSectionCommandResponse>
    {
        private readonly IMapper _Mapper;
        private readonly IAsyncRepository<DynamicAttributeSection> _DynamicAttributeSectionRepository;
        public CreateDynamicAttributeSectionCommandHandler(IMapper Mapper,
            IAsyncRepository<DynamicAttributeSection> DynamicAttributeSectionRepository)
        {
            _Mapper = Mapper;
            _DynamicAttributeSectionRepository = DynamicAttributeSectionRepository;
        }
        public async Task<CreateDynamicAttributeSectionCommandResponse> Handle(CreateDynamicAttributeSectionCommand Request, CancellationToken cancellationToken)
        {
            DynamicAttributeSection NewDynamicAttributeSectionEntity = _Mapper.Map<DynamicAttributeSection>(Request);
            await _DynamicAttributeSectionRepository.AddAsync(NewDynamicAttributeSectionEntity);

            return new CreateDynamicAttributeSectionCommandResponse()
            {
                CreateDynamicAttributeSectionDto = new CreateDynamicAttributeSectionDto()
                {
                    Id = NewDynamicAttributeSectionEntity.Id,
                    ArabicName = NewDynamicAttributeSectionEntity.ArabicName,
                    EnglishName = NewDynamicAttributeSectionEntity.EnglishName
                }
            };
        }
    }
}
