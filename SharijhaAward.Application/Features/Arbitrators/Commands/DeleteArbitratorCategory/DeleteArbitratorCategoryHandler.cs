using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.CategoryArbitratorModel;

namespace SharijhaAward.Application.Features.Arbitrators.Commands.DeleteArbitratorCategory
{
    public class DeleteArbitratorCategoryHandler : IRequestHandler<DeleteArbitratorCategoryCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<CategoryArbitrator> _CategoryArbitratorRepository;
        public DeleteArbitratorCategoryHandler(IAsyncRepository<CategoryArbitrator> CategoryArbitratorRepository)
        {
            _CategoryArbitratorRepository = CategoryArbitratorRepository;
        }

        public async Task<BaseResponse<object>> Handle(DeleteArbitratorCategoryCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            CategoryArbitrator? CategoryArbitratorEntityToDelete = await _CategoryArbitratorRepository
                .FirstOrDefaultAsync(x => x.Id == Request.Id);

            if (CategoryArbitratorEntityToDelete == null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Arbitrator category is not found"
                    : "فئة المحكم غير موجودة";

                return new BaseResponse<object>(ResponseMessage, false, 404);
            }

            await _CategoryArbitratorRepository.DeleteAsync(CategoryArbitratorEntityToDelete);

            ResponseMessage = Request.lang == "en"
                ? "Arbitrator category has been deleted successfully"
                : "تم حذف فئة المحكم بنجاح";

            return new BaseResponse<object>(ResponseMessage, true, 200);
        }
    }
}
