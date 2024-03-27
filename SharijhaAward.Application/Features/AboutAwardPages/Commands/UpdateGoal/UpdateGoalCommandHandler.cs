using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.AboutAwardPageModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.AboutAwardPages.Commands.UpdateGoal
{
    public class UpdateGoalCommandHandler
        : IRequestHandler<UpdateGoalCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<OurGoal> _ourGoalRepository;
        private readonly IMapper _mapper;

        public UpdateGoalCommandHandler(IAsyncRepository<OurGoal> ourGoalRepository, IMapper mapper)
        {
            _ourGoalRepository = ourGoalRepository;
            _mapper = mapper;
        }

        public async Task<BaseResponse<object>> Handle(UpdateGoalCommand request, CancellationToken cancellationToken)
        {
            var Goal = await _ourGoalRepository.GetByIdAsync(request.Id);
            if(Goal == null)
            {
                return new BaseResponse<object>("", false, 404);
            }
            _mapper.Map(request, Goal, typeof(UpdateGoalCommand), typeof(OurGoal));

            await _ourGoalRepository.UpdateAsync(Goal);
            string msg = request.lang == "en"
                ? "the Goal has been updated"
                : "تم تعديل الهدف بنجاح";
            return new BaseResponse<object>(msg, true, 200);
        }
    }
}
