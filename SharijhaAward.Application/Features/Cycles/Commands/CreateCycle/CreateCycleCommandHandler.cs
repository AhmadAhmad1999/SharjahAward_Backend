using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.CycleModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.Cycles.Commands.CreateCycle
{
    public class CreateCycleCommandHandler 
        : IRequestHandler<CreateCycleCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<Cycle> _cycleRepository;
        private readonly IMapper _mapper;

        public CreateCycleCommandHandler(IAsyncRepository<Cycle> cycleRepository, IMapper mapper)
        {
            _cycleRepository = cycleRepository;
            _mapper = mapper;
        }

        public async Task<BaseResponse<object>> Handle(CreateCycleCommand request, CancellationToken cancellationToken)
        {
            var cycle = _mapper.Map<Cycle>(request);

            await _cycleRepository.AddAsync(cycle);
            string msg = request.lang == "en"
                ? "Cycle has been Created"
                : "تم إنشاء الدورة بنجاح";

            return new BaseResponse<object>(msg, true, 200);
           
        }
    }
}
