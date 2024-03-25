using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.CategoryModel;
using SharijhaAward.Domain.Entities.CriterionModel;

namespace SharijhaAward.Application.Features.CriterionFeatures.Queries.GetAllCriterionsForDashBoardByCategoryId
{
    public class GetAllCriterionsForDashBoardByCategoryIdHandler : IRequestHandler<GetAllCriterionsForDashBoardCategoryIdQuery,
        BaseResponse<List<GetAllCriterionsForDashBoardCategoryIdDto>>>
    {
        private readonly IAsyncRepository<Criterion> _CriterionRepository;
        private readonly IAsyncRepository<Category> _CategoryRepository;

        public GetAllCriterionsForDashBoardByCategoryIdHandler(IAsyncRepository<Criterion> CriterionRepository,
            IAsyncRepository<Category> CategoryRepository)
        {
            _CriterionRepository = CriterionRepository;
            _CategoryRepository = CategoryRepository;
        }
        public async Task<BaseResponse<List<GetAllCriterionsForDashBoardCategoryIdDto>>> Handle(GetAllCriterionsForDashBoardCategoryIdQuery Request, 
            CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            Category? CheckIfCategoryIdIsExist = await _CategoryRepository
                .FirstOrDefaultAsync(x => x.Id == Request.CategoryId);

            if (CheckIfCategoryIdIsExist == null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Category is not found"
                    : "الفئة غير موجود";

                return new BaseResponse<List<GetAllCriterionsForDashBoardCategoryIdDto>>(ResponseMessage, false, 404);
            }

            List<GetAllCriterionsForDashBoardCategoryIdDto> MainCriterions = await _CriterionRepository
                .Where(x => x.CategoryId == Request.CategoryId)
                .Select(x => new GetAllCriterionsForDashBoardCategoryIdDto()
                {
                    Id = x.Id,
                    Score = x.Score,
                    Title = Request.lang == "en"
                        ? x.EnglishTitle
                        : x.ArabicTitle
                }).ToListAsync();

            foreach (GetAllCriterionsForDashBoardCategoryIdDto MainCriterion in MainCriterions)
            {
                List<GetAllSubCriterion> SubCriterions = await _CriterionRepository
                    .Where(x => x.ParentId == MainCriterion.Id)
                    .Select(x => new GetAllSubCriterion()
                    {
                        Id = x.Id,
                        Score = x.Score,
                        Title = Request.lang == "en"
                            ? x.EnglishTitle
                            : x.ArabicTitle
                    }).ToListAsync();
            }

            int TotalCount = await _CriterionRepository
                .GetCountAsync(x => x.CategoryId == Request.CategoryId);

            Pagination PaginationParameter = new Pagination(Request.page,
                Request.pageSize, TotalCount);

            return new BaseResponse<List<GetAllCriterionsForDashBoardCategoryIdDto>>(ResponseMessage, true, 200, MainCriterions, PaginationParameter);
        }
    }
}
