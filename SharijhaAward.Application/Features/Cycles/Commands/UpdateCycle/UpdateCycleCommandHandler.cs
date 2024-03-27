using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
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
           
            string msg = request.lang == "en"
                ? "The Cycle has been Updated"
                : "تم تعديل الدورة بنجاح";

            if (cycleToUpdate == null)
            {
                msg = request.lang == "en"
                    ? "The Cycle is Not Found"
                    : "الدورة غير موجودة";

                return new BaseResponse<object>(msg, false, 404);
            }
            if (request.Status == 0)
            {
                var ActiveCycle = await _cycleRepository.Where(c => c.Status == 0).FirstOrDefaultAsync();
                if (ActiveCycle != null)
                {
                    msg = request.lang == "en"
                      ? "You can't add to Active Cycle"
                      : "لا يمكن إضافة أكثر من دورة فعالة";

                    return new BaseResponse<object>(msg, false, 400);
                }

            }
            _mapper.Map(request, cycleToUpdate, typeof(UpdateCycleCommand), typeof(Cycle));
            
            await _cycleRepository.UpdateAsync(cycleToUpdate);
            
            

            return new BaseResponse<object>(msg,true,200);
        }
    }
}
