using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.CategoryModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.Categories.Command.DeleteCategory
{
    public class DeleteCategoryCommandHandler
        : IRequestHandler<DeleteCategoryCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<Category> _categoryRepository;

        public DeleteCategoryCommandHandler(IAsyncRepository<Category> categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public async Task<BaseResponse<object>> Handle(DeleteCategoryCommand request, CancellationToken cancellationToken)
        {
            string msg = request.lang == "en"
                ? "The Category has been Deleted"
                : "تم حذف الفئة بنجاح";

            var category = await _categoryRepository.GetByIdAsync(request.CategoryId);
            
            if(category == null)
            {
                msg = request.lang == "en"
                    ? "The Category not found"
                    : "الفئة غير موجودة";

                return new BaseResponse<object>(msg, false, 404);
            }
            await _categoryRepository.DeleteAsync(category);

            return new BaseResponse<object>(msg, true, 200);
        }
    }
}
