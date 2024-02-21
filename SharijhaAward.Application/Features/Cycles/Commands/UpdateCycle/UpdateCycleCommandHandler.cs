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

namespace SharijhaAward.Application.Features.Cycles.Commands.UpdateCycle
{
    public class UpdateCycleCommandHandler
        : IRequestHandler<UpdateCycleCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<Cycle> _cycleRepository;
        private readonly IMapper _mapper;

        public UpdateCycleCommandHandler(IAsyncRepository<Cycle> cycleRepository, IMapper mapper)
        {
            _cycleRepository = cycleRepository;
            _mapper = mapper;
        }

        public async Task<BaseResponse<object>> Handle(UpdateCycleCommand request, CancellationToken cancellationToken)
        {
            var cycleToUpdate = await _cycleRepository.GetByIdAsync(request.Id);
            string msg;
            if (cycleToUpdate == null)
            {
                msg = request.lang == "en"
                    ? "The Cycle is Not Found"
                    : "الدورة غير موجودة";

                return new BaseResponse<object>(msg, true, 404);
            }
            _mapper.Map(request, cycleToUpdate, typeof(UpdateCycleCommand), typeof(Cycle));
            
            await _cycleRepository.UpdateAsync(cycleToUpdate);
            
            msg = request.lang == "en"
                ? "The Cycle has been Updated"
                : "تم تعديل الدورة بنجاح";

            return new BaseResponse<object>(msg,true,200);
        }
    }
}
