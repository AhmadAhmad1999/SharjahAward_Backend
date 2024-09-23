using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.CycleModel;
using SharijhaAward.Domain.Entities.IdentityModels;
using SharijhaAward.Domain.Entities.ProvidedFormModel;
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
        private readonly IAsyncRepository<UserToken> _UserTokenRepository;
        private readonly IAsyncRepository<Domain.Entities.ProvidedFormModel.ProvidedForm> _providedFormRepository;

        private readonly IMapper _mapper;

        public UpdateCycleCommandHandler(IAsyncRepository<Domain.Entities.ProvidedFormModel.ProvidedForm> providedFormRepository, IAsyncRepository<UserToken> UserTokenRepository,IAsyncRepository<Cycle> cycleRepository, IMapper mapper)
        {
            _cycleRepository = cycleRepository;
            _UserTokenRepository = UserTokenRepository;
            _mapper = mapper;
            _providedFormRepository = providedFormRepository;
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



            var ActiveCycle = await _cycleRepository.Where(c => c.Status == 0 && c.Id != cycleToUpdate.Id).FirstOrDefaultAsync();
           
            if (request.Status == 0)
            {
                if (ActiveCycle != null)
                {
                    msg = request.lang == "en"
                      ? "You can't add to Active Cycle"
                      : "لا يمكن إضافة أكثر من دورة فعالة";

                    return new BaseResponse<object>(msg, false, 400);
                }

            }

            // for Make all Forms Previous when Closed Cycle
            if (cycleToUpdate.Status == Domain.Constants.Common.Status.Active && request.Status != Domain.Constants.Common.Status.Active)
            {
                var forms = _providedFormRepository
                    .Where(f => f.Category.CycleId == cycleToUpdate.Id)
                    .ToList();

                foreach (var form in forms)
                {
                    form.Type = Domain.Constants.ProvidedFromConstants.ProvidedFormType.Previous;
                }

                await _providedFormRepository.UpdateListAsync(forms);
            }

            _mapper.Map(request, cycleToUpdate, typeof(UpdateCycleCommand), typeof(Cycle));
            
            await _cycleRepository.UpdateAsync(cycleToUpdate);

            ActiveCycle = await _cycleRepository.Where(c => c.Status == Domain.Constants.Common.Status.Active).FirstOrDefaultAsync();
            
            if(ActiveCycle == null)
            {
                var UserTokenEntitiesToDelete = await _UserTokenRepository
                .ListAllAsync();

                await _UserTokenRepository.DeleteListAsync(UserTokenEntitiesToDelete);
            }

            return new BaseResponse<object>(msg,true,200);
        }
    }
}
