using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.InterviewModel;

namespace SharijhaAward.Application.Features.InterviewFeatures.Commands.DeleteInterview
{
    public class DeleteInterviewHandler : IRequestHandler<DeleteInterviewCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<Interview> _InterviewRepository;
        public DeleteInterviewHandler(IAsyncRepository<Interview> InterviewRepository)
        {
            _InterviewRepository = InterviewRepository;
        }

        public async Task<BaseResponse<object>> Handle(DeleteInterviewCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            Interview? InterviewEntityToDelete = await _InterviewRepository
                .FirstOrDefaultAsync(x => x.Id == Request.Id);

            if (InterviewEntityToDelete == null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Interview is not found"
                    : "المقابلة غير موجودة";

                return new BaseResponse<object>(ResponseMessage, false, 404);
            }

            await _InterviewRepository.DeleteAsync(InterviewEntityToDelete);

            ResponseMessage = Request.lang == "en"
                ? "Interview has been deleted successfully"
                : "تم حذف المقابلة بنجاح";

            return new BaseResponse<object>(ResponseMessage, true, 200);
        }
    }
}
