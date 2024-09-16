using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.CommitteeModel;

namespace SharijhaAward.Application.Features.CommitteeFeatures.Commands.DeleteCommittee
{
    public class DeleteCommitteeHandler : IRequestHandler<DeleteCommitteeCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<Committee> _CommitteeRepository;

        public DeleteCommitteeHandler(IAsyncRepository<Committee> CommitteeRepository)
        {
            _CommitteeRepository = CommitteeRepository;
        }

        public async Task<BaseResponse<object>> Handle(DeleteCommitteeCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            Committee? CommitteeEntityToDelete = await _CommitteeRepository
                .FirstOrDefaultAsync(x => x.Id == Request.Id);

            if (CommitteeEntityToDelete == null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Committee is not found"
                    : "اللجنة غير موجود";

                return new BaseResponse<object>(ResponseMessage, false, 404);
            }

            await _CommitteeRepository.DeleteAsync(CommitteeEntityToDelete);

            ResponseMessage = Request.lang == "en"
                ? "Committee has been deleted successfully"
                : "تم حذف اللجنة بنجاح";

            return new BaseResponse<object>(ResponseMessage, true, 200);
        }
    }
}
