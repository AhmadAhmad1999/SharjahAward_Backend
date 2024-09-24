using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.CriterionModel;

namespace SharijhaAward.Application.Features.CriterionFeatures.Commands.DeleteCriterion
{
    public class DeleteCriterionHandler : IRequestHandler<DeleteCriterionCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<Criterion> _CriterionRepository;
        public DeleteCriterionHandler(IAsyncRepository<Criterion> CriterionRepository)
        {
            _CriterionRepository = CriterionRepository;
        }
        public async Task<BaseResponse<object>> Handle(DeleteCriterionCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            Criterion? CriterionEntity = await _CriterionRepository
                .IncludeThenFirstOrDefaultAsync(x => x.Parent!, x => x.Id == Request.Id);

            if (CriterionEntity == null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Criterion is not found"
                    : "المعيار غير موجود";

                return new BaseResponse<object>(ResponseMessage, false, 404);
            }

            await _CriterionRepository.DeleteAsync(CriterionEntity);

            ResponseMessage = Request.lang == "en"
                ? "Criterion has been deleted successfully"
                : "تم حذف المعيار بنجاح";

            return new BaseResponse<object>(ResponseMessage, true, 200);
        }
    }
}
