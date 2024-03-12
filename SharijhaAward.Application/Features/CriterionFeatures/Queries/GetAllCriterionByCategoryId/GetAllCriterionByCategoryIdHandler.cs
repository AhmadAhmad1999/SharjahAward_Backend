using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Features.DynamicAttributeSectionsFeatures.Queries.GetAllDynamicAttributeSectionsForAdd;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.CategoryModel;
using SharijhaAward.Domain.Entities.CriterionItemModel;
using SharijhaAward.Domain.Entities.CriterionModel;
using SharijhaAward.Domain.Entities.DynamicAttributeModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.CriterionFeatures.Queries.GetAllCriterionByCategoryId
{
    public class GetAllCriterionByCategoryIdHandler : IRequestHandler<GetAllCriterionByCategoryIdQuery,
        BaseResponse<List<MainCriterionListVM>>>
    {
        private readonly IAsyncRepository<Category> _CategoryRepository;
        private readonly IAsyncRepository<Criterion> _CriterionRepository;
        private readonly IAsyncRepository<CriterionItem> _CriterionItemRepository;
        public GetAllCriterionByCategoryIdHandler(IAsyncRepository<Category> CategoryRepository,
            IAsyncRepository<Criterion> CriterionRepository,
            IAsyncRepository<CriterionItem> CriterionItemRepository)
        {
            _CategoryRepository = CategoryRepository;
            _CriterionRepository = CriterionRepository;
            _CriterionItemRepository = CriterionItemRepository;
        }
        public async Task<BaseResponse<List<MainCriterionListVM>>> Handle(GetAllCriterionByCategoryIdQuery Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            string Language = !string.IsNullOrEmpty(Request.lang)
                ? Request.lang.ToLower() : "ar";

            Category? CheckIfCategoryIdIsExist = await _CategoryRepository
                .FirstOrDefaultAsync(x => x.Id == Request.CategoryId);

            if (CheckIfCategoryIdIsExist == null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Category is not Found"
                    : "الفئة غير موجود";

                return new BaseResponse<List<MainCriterionListVM>>(ResponseMessage, false, 404);
            }

            List<MainCriterionListVM> FullObjectResponse = new List<MainCriterionListVM>();

            List<Criterion> AllCriterionsEntities = await _CriterionRepository.Where(x => x.CategoryId == Request.CategoryId).ToListAsync();

            List<MainCriterionListVM> MainCriterionObjects = AllCriterionsEntities.Where(x => x.ParentId == null)
                .Select(x => new MainCriterionListVM()
                {
                    Id = x.Id,
                    Title = Language == "ar" 
                        ? x.ArabicTitle
                        : x.EnglishTitle
                }).ToList();

            foreach (MainCriterionListVM MainCriterionObject in MainCriterionObjects)
            {
                MainCriterionObject.SubCriterionListVM = AllCriterionsEntities
                    .Where(x => x.ParentId == MainCriterionObject.Id)
                    .Select(x => new SubCriterionListVM()
                    {
                        Id = x.Id,
                        Title = Language == "ar"
                            ? x.ArabicTitle
                            : x.EnglishTitle
                    }).ToList();

                foreach (SubCriterionListVM SubCriterionObject in MainCriterionObject.SubCriterionListVM)
                {
                    SubCriterionObject.CriterionItemListVM = _CriterionItemRepository
                        .Where(x => x.CriterionId == SubCriterionObject.Id)
                        .Select(x => new CriterionItemListVM()
                        {
                            Id = x.Id,
                            Name = Language == "ar"
                                ? x.ArabicName
                                : x.EnglishName
                        }).ToList();
                }

                FullObjectResponse.Add(MainCriterionObject);
            }

            return new BaseResponse<List<MainCriterionListVM>>(ResponseMessage, true, 200, FullObjectResponse);
        }
    }
}
