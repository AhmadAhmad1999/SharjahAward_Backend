using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.AboutAwardPageModel;

namespace SharijhaAward.Application.Features.AboutAwardPages.Commands.DeleteGoal
{
    public class DeleteGoalCommandHandler
        : IRequestHandler<DeleteGoalCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<OurGoal> _goalRepository;

        public DeleteGoalCommandHandler(IAsyncRepository<OurGoal> goalRepository)
        {
            _goalRepository = goalRepository;
        }

        public async Task<BaseResponse<object>> Handle(DeleteGoalCommand request, CancellationToken cancellationToken)
        {
            var goal = await _goalRepository.GetByIdAsync(request.Id);

            if(goal == null)
            {
                return new BaseResponse<object>("الهدف غير موجود", false, 404);
            }

            await _goalRepository.DeleteAsync(goal);

            return new BaseResponse<object>("تم حذف الهدف", true, 200);
        }
    }
}
