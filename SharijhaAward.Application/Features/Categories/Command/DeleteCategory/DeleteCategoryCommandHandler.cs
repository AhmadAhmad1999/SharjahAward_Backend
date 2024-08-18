using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.CategoryModel;
using SharijhaAward.Domain.Entities.ExplanatoryGuideModel;
using SharijhaAward.Domain.Entities.FAQModel;
using SharijhaAward.Domain.Entities.InterviewModel;
using SharijhaAward.Domain.Entities.MeetingCategoryModel;
using SharijhaAward.Domain.Entities.RewardModel;
using System.Transactions;

namespace SharijhaAward.Application.Features.Categories.Command.DeleteCategory
{
    public class DeleteCategoryCommandHandler
        : IRequestHandler<DeleteCategoryCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<Category> _CategoryRepository;
        private readonly IAsyncRepository<CategoryEducationalEntity> _CategoryEducationalEntityRepository;
        private readonly IAsyncRepository<InterviewCategory> _InterviewCategoryRepository;
        private readonly IAsyncRepository<ExplanatoryGuide> _ExplanatoryGuideRepository;
        private readonly IAsyncRepository<FrequentlyAskedQuestion> _FrequentlyAskedQuestionRepository;
        private readonly IAsyncRepository<MeetingCategory> _MeetingCategoryRepository;
        private readonly IAsyncRepository<Reward> _RewardRepository;

        public DeleteCategoryCommandHandler(IAsyncRepository<Category> categoryRepository,
            IAsyncRepository<CategoryEducationalEntity> CategoryEducationalEntityRepository,
            IAsyncRepository<InterviewCategory> InterviewCategoryRepository,
            IAsyncRepository<ExplanatoryGuide> ExplanatoryGuideRepository,
            IAsyncRepository<FrequentlyAskedQuestion> FrequentlyAskedQuestionRepository,
            IAsyncRepository<MeetingCategory> MeetingCategoryRepository,
            IAsyncRepository<Reward> RewardRepository)
        {
            _CategoryRepository = categoryRepository;
            _CategoryEducationalEntityRepository = CategoryEducationalEntityRepository;
            _InterviewCategoryRepository = InterviewCategoryRepository;
            _ExplanatoryGuideRepository = ExplanatoryGuideRepository;
            _FrequentlyAskedQuestionRepository = FrequentlyAskedQuestionRepository;
            _MeetingCategoryRepository = MeetingCategoryRepository;
            _RewardRepository = RewardRepository;
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

            List<CategoryEducationalEntity> CategoryEducationalEntityToDelete = await _CategoryEducationalEntityRepository
                .Where(x => x.CategoryId == request.CategoryId)
                .ToListAsync();

            List<InterviewCategory> InterviewCategoryToDelete = await _InterviewCategoryRepository
                .Where(x => x.CategoryId == request.CategoryId)
                .ToListAsync();

            List<ExplanatoryGuide> ExplanatoryGuideToDelete = await _ExplanatoryGuideRepository
                .Where(x => x.CategoryId == request.CategoryId)
                .ToListAsync();

            List<FrequentlyAskedQuestion> FrequentlyAskedQuestionToDelete = await _FrequentlyAskedQuestionRepository
                .Where(x => x.CategoryId == request.CategoryId)
                .ToListAsync();

            List<MeetingCategory> MeetingCategoryToDelete = await _MeetingCategoryRepository
                .Where(x => x.CategoryId == request.CategoryId)
                .ToListAsync();

            List<Reward> RewardToDelete = await _RewardRepository
                .Where(x => x.CategoryId == request.CategoryId)
                .ToListAsync();

            List<Category> CategoryToDelete = new List<Category>();

            if (category.ParentId == null)
                CategoryToDelete = await _CategoryRepository
                    .Where(x => x.ParentId == request.CategoryId)
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
                    await _CategoryRepository.DeleteAsync(category);

                    if (CategoryEducationalEntityToDelete.Any())
                        await _CategoryEducationalEntityRepository.DeleteListAsync(CategoryEducationalEntityToDelete);

                    if (InterviewCategoryToDelete.Any())
                        await _InterviewCategoryRepository.DeleteListAsync(InterviewCategoryToDelete);

                    if (ExplanatoryGuideToDelete.Any())
                        await _ExplanatoryGuideRepository.DeleteListAsync(ExplanatoryGuideToDelete);

                    if (FrequentlyAskedQuestionToDelete.Any())
                        await _FrequentlyAskedQuestionRepository.DeleteListAsync(FrequentlyAskedQuestionToDelete);

                    if (MeetingCategoryToDelete.Any())
                        await _MeetingCategoryRepository.DeleteListAsync(MeetingCategoryToDelete);

                    if (RewardToDelete.Any())
                        await _RewardRepository.DeleteListAsync(RewardToDelete);

                    if (CategoryToDelete.Any())
                        await _CategoryRepository.DeleteListAsync(CategoryToDelete);

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
