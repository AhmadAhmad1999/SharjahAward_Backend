using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Domain.Entities.CategoryModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.Categories.Queries.GetAllCategories
{
    public class GetAllCategoryQueryHandler
        : IRequestHandler<GetAllCategoryQuery, List<CategoryListVM>>
    {
        private readonly IAsyncRepository<Category> _categoryRepository;
        private readonly IMapper _mapper;

        public GetAllCategoryQueryHandler(IAsyncRepository<Category> categoryRepository, IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }
        public async Task<List<CategoryListVM>> Handle(GetAllCategoryQuery request, CancellationToken cancellationToken)
        {
            var AllCategories = await _categoryRepository.ListAllAsync();

            List<CategoryListVM> categories = new List<CategoryListVM>();

            for (int i = 0; i < AllCategories.Count; i++)
            {
                CategoryListVM categoryList = new CategoryListVM();

                categoryList.Id = AllCategories[i].Id;
                categoryList.Name = request.lang == "ar" ? AllCategories[i].ArabicName : AllCategories[i].EnglishName;
                categoryList.Description = request.lang == "ar" ? AllCategories[i].ArabicDescription : AllCategories[i].EnglishDescription;
                categoryList.Icon = AllCategories[i].Icon;
                categoryList.WinningScore = AllCategories[i].WinningScore;
                categoryList.SubscriberPortalClosingDate = AllCategories[i].SubscriberPortalClosingDate;
                categoryList.FinalArbitrationStartDate = AllCategories[i].FinalArbitrationStartDate;
                categoryList.FinalArbitrationEndDate = AllCategories[i].FinalArbitrationEndDate;
                categoryList.CategoryClassification = AllCategories[i].CategoryClassification;
                categoryList.InitialArbitrationStartDate = AllCategories[i].InitialArbitrationStartDate;
                categoryList.InitialArbitrationEndDate = AllCategories[i].InitialArbitrationEndDate;
                categoryList.FinalArbitrationQualificationMark = AllCategories[i].FinalArbitrationQualificationMark;
                categoryList.Status = AllCategories[i].Status;
                categoryList.RelatedToClasses = AllCategories[i].RelatedToClasses;
                categoryList.ExpectedNumberOfWinners = AllCategories[i].ExpectedNumberOfWinners;
                categories.Add(categoryList);
            }
            return _mapper.Map<List<CategoryListVM>>(categories);
        }
    }
}
