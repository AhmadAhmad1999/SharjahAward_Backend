using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.CategoryModel;
using SharijhaAward.Domain.Entities.CriterionItemModel;
using SharijhaAward.Domain.Entities.CriterionModel;

namespace SharijhaAward.Application.Features.CriterionFeatures.Queries.GetAllCriterionsForDashBoardByCategoryId
{
    public class GetAllCriterionsForDashBoardByCategoryIdHandler : IRequestHandler<GetAllCriterionsForDashBoardCategoryIdQuery,
        BaseResponse<List<GetAllCriterionsForDashBoardCategoryIdDto>>>
    {
        private readonly IAsyncRepository<Criterion> _CriterionRepository;
        private readonly IAsyncRepository<Category> _CategoryRepository;
        private readonly IAsyncRepository<CriterionItem> _CriterionItemRepository;

        public GetAllCriterionsForDashBoardByCategoryIdHandler(IAsyncRepository<Criterion> CriterionRepository,
            IAsyncRepository<Category> CategoryRepository,
            IAsyncRepository<CriterionItem> CriterionItemRepository)
        {
            _CriterionRepository = CriterionRepository;
            _CategoryRepository = CategoryRepository;
            _CriterionItemRepository = CriterionItemRepository;
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

            List<GetAllCriterionsForDashBoardCategoryIdDto> MainCriterions = new List<GetAllCriterionsForDashBoardCategoryIdDto>();

            if (Request.page != 0 && Request.pageSize != -1)
                MainCriterions = await _CriterionRepository
                    .Where(x => x.CategoryId == Request.CategoryId && x.ParentId == null)
                    .OrderBy(x => x.OrderId)
                    .Skip((Request.page - 1) * Request.pageSize)
                    .Take(Request.pageSize)
                    .Select(x => new GetAllCriterionsForDashBoardCategoryIdDto()
                    {
                        Id = x.Id,
                        Score = x.Score,
                        ArabicTitle = x.ArabicTitle,
                        EnglishTitle = x.EnglishTitle
                    }).ToListAsync();

            else
                MainCriterions = await _CriterionRepository
                    .Where(x => x.CategoryId == Request.CategoryId && x.ParentId == null)
                    .OrderBy(x => x.OrderId)
                    .Select(x => new GetAllCriterionsForDashBoardCategoryIdDto()
                    {
                        Id = x.Id,
                        Score = x.Score,
                        ArabicTitle = x.ArabicTitle,
                        EnglishTitle = x.EnglishTitle
                    }).ToListAsync();

            foreach (GetAllCriterionsForDashBoardCategoryIdDto MainCriterion in MainCriterions)
            {
                List<GetAllSubCriterion> SubCriterions = await _CriterionRepository
                    .Where(x => x.ParentId != null 
                        ? x.ParentId == MainCriterion.Id
                        : false)
                    .OrderBy(x => x.OrderId)
                    .Select(x => new GetAllSubCriterion()
                    {
                        Id = x.Id,
                        Score = x.Score,
                        ArabicTitle = x.ArabicTitle,
                        EnglishTitle = x.EnglishTitle,
                        SizeOfAttachmentInKB = x.SizeOfAttachmentInKB,
                        MaxAttachmentNumber = x.MaxAttachmentNumber != null
                            ? x.MaxAttachmentNumber.Value
                            : null
                    }).ToListAsync();

                MainCriterion.SubCriterions = SubCriterions;

                foreach (GetAllSubCriterion SubCriterion in MainCriterion.SubCriterions)
                {
                    List<GetAllSubCriterionItems> CriterionItems = await _CriterionItemRepository
                        .Where(x => x.CriterionId == SubCriterion.Id)
                        .OrderBy(x => x.OrderId)
                        .Select(x => new GetAllSubCriterionItems()
                        {
                            Id = x.Id,
                            ArabicName = x.ArabicName,
                            EnglishName = x.EnglishName,
                            Score = x.Score,
                            SizeOfAttachmentInKB = x.SizeOfAttachmentInKB != null
                                ? x.SizeOfAttachmentInKB.Value
                                : 0,
                            MaxAttachmentNumber = x.MaxAttachmentNumber
                        }).ToListAsync();

                    SubCriterion.CriterionItems = CriterionItems;
                }
            }

            int TotalCount = await _CriterionRepository
                .GetCountAsync(x => x.CategoryId == Request.CategoryId && x.ParentId != null);

            Pagination PaginationParameter = new Pagination(Request.page,
                Request.pageSize, TotalCount);

            return new BaseResponse<List<GetAllCriterionsForDashBoardCategoryIdDto>>(ResponseMessage, true, 200, MainCriterions, PaginationParameter);
        }
    }
}
