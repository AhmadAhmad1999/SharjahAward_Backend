﻿using MediatR;
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
        private readonly IAsyncRepository<CriterionAttachmentType> _CriterionAttachmentTypeRepository;
        private readonly IAsyncRepository<CriterionItemAttachmentType> _CriterionItemAttachmentTypeRepository;

        public GetAllCriterionsForDashBoardByCategoryIdHandler(IAsyncRepository<Criterion> CriterionRepository,
            IAsyncRepository<Category> CategoryRepository,
            IAsyncRepository<CriterionItem> CriterionItemRepository,
            IAsyncRepository<CriterionAttachmentType> _CriterionAttachmentTypeRepository,
            IAsyncRepository<CriterionItemAttachmentType> _CriterionItemAttachmentTypeRepository)
        {
            _CriterionRepository = CriterionRepository;
            _CategoryRepository = CategoryRepository;
            _CriterionItemRepository = CriterionItemRepository;
            this._CriterionAttachmentTypeRepository = _CriterionAttachmentTypeRepository;
            this._CriterionItemAttachmentTypeRepository = _CriterionItemAttachmentTypeRepository;
        }
        public async Task<BaseResponse<List<GetAllCriterionsForDashBoardCategoryIdDto>>> Handle(GetAllCriterionsForDashBoardCategoryIdQuery Request, 
            CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            Category? CheckIfCategoryIdIsExist = await _CategoryRepository
                .IncludeThenFirstOrDefaultAsync(x => x.Parent!, x => x.Id == Request.CategoryId);

            if (CheckIfCategoryIdIsExist == null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Category is not found"
                    : "الفئة غير موجود";

                return new BaseResponse<List<GetAllCriterionsForDashBoardCategoryIdDto>>(ResponseMessage, false, 404);
            }

            List<Criterion> AllCriterionEntities = await _CriterionRepository
                .Where(x => x.CategoryId == Request.CategoryId)
                .ToListAsync();

            List<CriterionAttachmentType> CriterionAttachmentTypeEntities = _CriterionAttachmentTypeRepository
                .Where(x => AllCriterionEntities
                    .Select(y => y.Id).Contains(x.CriterionId) && x.AttachmentType != null)
                .ToList();

            List<CriterionItem> AllCriterionItemEntities = await _CriterionItemRepository
                .Where(x => AllCriterionEntities
                    .Select(y => y.Id).Contains(x.CriterionId))
                .ToListAsync();

            List<CriterionItemAttachmentType> CriterionItemAttachmentTypeEntities = _CriterionItemAttachmentTypeRepository
                .Where(x => AllCriterionItemEntities
                    .Select(y => y.Id).Contains(x.CriterionItemId))
                .ToList();

            List<GetAllCriterionsForDashBoardCategoryIdDto> MainCriterions = new List<GetAllCriterionsForDashBoardCategoryIdDto>();

            if (Request.page != 0 && Request.perPage != -1)
                MainCriterions = AllCriterionEntities
                    .Where(x => x.ParentId == null)
                    .OrderBy(x => x.OrderId)
                    .Skip((Request.page - 1) * Request.perPage)
                    .Take(Request.perPage)
                    .Select(x => new GetAllCriterionsForDashBoardCategoryIdDto()
                    {
                        Id = x.Id,
                        Score = x.Score,
                        ArabicTitle = x.ArabicTitle,
                        EnglishTitle = x.EnglishTitle
                    }).ToList();

            else
                MainCriterions = AllCriterionEntities
                    .Where(x => x.ParentId == null)
                    .OrderBy(x => x.OrderId)
                    .Select(x => new GetAllCriterionsForDashBoardCategoryIdDto()
                    {
                        Id = x.Id,
                        Score = x.Score,
                        ArabicTitle = x.ArabicTitle,
                        EnglishTitle = x.EnglishTitle
                    }).ToList();

            foreach (GetAllCriterionsForDashBoardCategoryIdDto MainCriterion in MainCriterions)
            {
                List<GetAllSubCriterion> SubCriterions = AllCriterionEntities
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
                            : null,
                        AttachmentType = CriterionAttachmentTypeEntities
                            .Where(y => y.CriterionId == x.Id)
                            .Select(y => y.AttachmentType!.Value)
                            .ToList(),
                        AttachFilesOnSubCriterion = (x.AttachFilesOnSubCriterion != null
                            ? x.AttachFilesOnSubCriterion.Value
                            : false)
                    }).ToList();

                MainCriterion.SubCriterions = SubCriterions;

                foreach (GetAllSubCriterion SubCriterion in MainCriterion.SubCriterions)
                {
                    List<GetAllSubCriterionItems> CriterionItems = AllCriterionItemEntities
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
                            MaxAttachmentNumber = x.MaxAttachmentNumber,
                            AttachmentType = CriterionItemAttachmentTypeEntities
                                .Where(y => y.CriterionItemId == x.Id)
                                .Select(y => y.AttachmentType)
                                .ToList(),
                        }).ToList();

                    SubCriterion.CriterionItems = CriterionItems;
                }
            }

            int TotalCount = await _CriterionRepository
                .GetCountAsync(x => x.CategoryId == Request.CategoryId && x.ParentId != null);

            Pagination PaginationParameter = new Pagination(Request.page,
                Request.perPage, TotalCount);

            return new BaseResponse<List<GetAllCriterionsForDashBoardCategoryIdDto>>(ResponseMessage, true, 200, MainCriterions, PaginationParameter);
        }
    }
}
