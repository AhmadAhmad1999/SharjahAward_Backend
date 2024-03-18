using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.AboutAwardPageModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.AboutAwardPages.Commands.CreateGoal
{
    public class CreateGoalCommandHandler
        : IRequestHandler<CreateGoalCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<OurGoal> _goalRepository;
        private readonly IAsyncRepository<AboutAwardPage> _aboutAwardPageRepository;
        private readonly IMapper _mapper;

        public CreateGoalCommandHandler(IAsyncRepository<AboutAwardPage> aboutAwardPageRepository,  IAsyncRepository<OurGoal> goalRepository, IMapper mapper)
        {
            _goalRepository = goalRepository;
            _aboutAwardPageRepository = aboutAwardPageRepository;
            _mapper = mapper;
        }

        public async Task<BaseResponse<object>> Handle(CreateGoalCommand request, CancellationToken cancellationToken)
        {
            var goal = _mapper.Map<OurGoal>(request);
            var AboutId = (await _aboutAwardPageRepository.Where(a => !a.isDeleted).FirstOrDefaultAsync())!.Id;
           
            if (AboutId.Equals(null))
            {
                return new BaseResponse<object>("You Can't add Goals", false, 400);
            }
           
            goal.AboutAwardPageId = AboutId;
            await _goalRepository.AddAsync(goal);

            return new BaseResponse<object>("Goal has been Created", true, 200);

        }
    }
}
