using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Features.Event.Queries.GetEventById;
using SharijhaAward.Domain.Entities.DynamicAttributeModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.DynamicAttributeSectionsFeatures.Queries.GetDynamicAttributeSectionById
{
    public class DynamicAttributeSectionQueryHandler : IRequestHandler<DynamicAttributeSectionQuery, DynamicAttributeSectionDto>
    {
        private readonly IAsyncRepository<DynamicAttributeSection> _DynamicAttributeSectionRepository;
        private readonly IMapper _Mapper;

        public DynamicAttributeSectionQueryHandler(IAsyncRepository<DynamicAttributeSection> DynamicAttributeSectionRepository, IMapper Mapper)
        {
            _DynamicAttributeSectionRepository = DynamicAttributeSectionRepository;
            _Mapper = Mapper;
        }
        public Task<DynamicAttributeSectionDto> Handle(DynamicAttributeSectionQuery Request, CancellationToken cancellationToken)
        {
            //var DynamicAttributeSection = _Mapper.Map<>(_DynamicAttributeSectionRepository.GetByIdAsync(Request.Id));


            throw new NotImplementedException();
        }
    }
}
