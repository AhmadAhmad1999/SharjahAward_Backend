using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.CategoryModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace SharijhaAward.Application.Features.Categories.Command.DeleteCategory
{
    public class DeleteCategoryCommandHandler
        : IRequestHandler<DeleteCategoryCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<Category> _categoryRepository;
        private readonly IAsyncRepository<CategoryEducationalEntity> _CategoryEducationalEntityRepository;

        public DeleteCategoryCommandHandler(IAsyncRepository<Category> categoryRepository,
            IAsyncRepository<CategoryEducationalEntity> CategoryEducationalEntityRepository)
        {
            _categoryRepository = categoryRepository;
            _CategoryEducationalEntityRepository = CategoryEducationalEntityRepository;
        }

        public async Task<BaseResponse<object>> Handle(DeleteCategoryCommand request, CancellationToken cancellationToken)
        {
            string msg = request.lang == "en"
                ? "The Category has been Deleted"
                : "تم حذف الفئة بنجاح";

            var category = await _categoryRepository.GetByIdAsync(request.CategoryId);

            if (category == null)
            {
                msg = request.lang == "en"
                    ? "The Category not found"
                    : "الفئة غير موجودة";

                return new BaseResponse<object>(msg, false, 404);
            }

            List<CategoryEducationalEntity> CategoryEducationalEntityToDelete = await _CategoryEducationalEntityRepository
                .Where(x => x.CategoryId == request.CategoryId)
                .ToListAsync();

            TransactionOptions TransactionOptions = new TransactionOptions
            {
                IsolationLevel = IsolationLevel.ReadCommitted,
                Timeout = TimeSpan.FromMinutes(5)
            };

            using (TransactionScope Transaction = new TransactionScope(TransactionScopeOption.Required,
                TransactionOptions, TransactionScopeAsyncFlowOption.Enabled))
            {
                try
                {
                    await _categoryRepository.DeleteAsync(category);

                    if (CategoryEducationalEntityToDelete.Any())
                        await _CategoryEducationalEntityRepository.DeleteListAsync(CategoryEducationalEntityToDelete);

                    Transaction.Complete();
                }
                catch (Exception)
                {
                    Transaction.Dispose();
                    throw;
                }
            }

            return new BaseResponse<object>(msg, true, 200);
        }
    }
}
