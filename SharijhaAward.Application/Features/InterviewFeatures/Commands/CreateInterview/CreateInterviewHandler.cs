using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.InterviewModel;

namespace SharijhaAward.Application.Features.InterviewFeatures.Commands.CreateInterview
{
    public class CreateInterviewHandler : IRequestHandler<CreateInterviewCommand, BaseResponse<object>>
    {
        private readonly IMapper _Mapper;
        private readonly IAsyncRepository<Interview> _InterviewRepository;
        private readonly IAsyncRepository<InterviewUser> _InterviewUserRepository;
        private readonly IAsyncRepository<InterviewCategory> _InterviewCategoryRepository;

        public CreateInterviewHandler(IMapper Mapper,
            IAsyncRepository<Interview> InterviewRepository,
            IAsyncRepository<InterviewUser> InterviewUserRepository,
            IAsyncRepository<InterviewCategory> InterviewCategoryRepository)
        {
            _Mapper = Mapper;
            _InterviewRepository = InterviewRepository;
            _InterviewUserRepository = InterviewUserRepository;
            _InterviewCategoryRepository = InterviewCategoryRepository;
        }

        public async Task<BaseResponse<object>> Handle(CreateInterviewCommand Request, CancellationToken cancellationToken)
        {




            throw new NotImplementedException();
        }
    }
}