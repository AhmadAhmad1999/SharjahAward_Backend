using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Domain.Entities.CycleModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.Cycles.Commands.CreateCycle
{
    public class CreateCycleCommandHandler 
        : IRequestHandler<CreateCycleCommand, CreateCycleResponse>
    {
        private readonly IAsyncRepository<Cycle> _cycleRepository;
        private readonly IMapper _mapper;

        public CreateCycleCommandHandler(IAsyncRepository<Cycle> cycleRepository, IMapper mapper)
        {
            _cycleRepository = cycleRepository;
            _mapper = mapper;
        }

        public async Task<CreateCycleResponse> Handle(CreateCycleCommand request, CancellationToken cancellationToken)
        {
            var cycle = _mapper.Map<Cycle>(request);

            await _cycleRepository.AddAsync(cycle);

            return new CreateCycleResponse()
            {
               Id = cycle.Id,
               ArabicName = cycle.ArabicName,
               EnglishName = cycle.EnglishName,
               GroupCategoryNumber = cycle.GroupCategoryNumber,
               IndividualCategoryNumber = cycle.IndividualCategoryNumber,
               RegistrationPortalClosingDate = cycle.RegistrationPortalClosingDate,
               RegistrationPortalOpeningDate = cycle.RegistrationPortalOpeningDate,
               Status = cycle.Status,
               Year = cycle.Year,
               Name =request.lang=="en"? cycle.EnglishName : cycle.ArabicName,
            };

        }
    }
}
