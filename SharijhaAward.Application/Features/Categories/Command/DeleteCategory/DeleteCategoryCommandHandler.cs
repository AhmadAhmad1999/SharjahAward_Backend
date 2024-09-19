using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.CategoryModel;

namespace SharijhaAward.Application.Features.Categories.Command.DeleteCategory
{
    public class DeleteCategoryCommandHandler
        : IRequestHandler<DeleteCategoryCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<Category> _CategoryRepository;

        public DeleteCategoryCommandHandler(IAsyncRepository<Category> categoryRepository)
        {
            _CategoryRepository = categoryRepository;
        }

        public async Task<BaseResponse<object>> Handle(DeleteCategoryCommand request, CancellationToken cancellationToken)
        {
            string msg = request.lang == "en"
                ? "The Category has been Deleted"
                : "تم حذف الفئة بنجاح";

            var category = await _CategoryRepository.GetByIdAsync(request.CategoryId);

            if (category == null)
            {
                msg = request.lang == "en"
                    ? "The Category not found"
                    : "الفئة غير موجودة";

                return new BaseResponse<object>(msg, false, 404);
            }

            await _CategoryRepository.DeleteAsync(category);

            return new BaseResponse<object>(msg, true, 200);
        }
    }
}
