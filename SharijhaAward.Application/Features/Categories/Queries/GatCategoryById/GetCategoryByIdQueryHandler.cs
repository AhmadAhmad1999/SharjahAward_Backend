using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Domain.Entities.CategoryModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.Categories.Queries.GatCategoryById
{
    public class GetCategoryByIdQueryHandler 
        : IRequestHandler<GetCategoryByIdQuery , CategoryDto>
    {
        private readonly IAsyncRepository<Category> _categoryRepository;
        private readonly IMapper _mapper;

        public GetCategoryByIdQueryHandler(IAsyncRepository<Category> categoryRepository, IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }

        public async Task<CategoryDto> Handle(GetCategoryByIdQuery request, CancellationToken cancellationToken)
        {
            var category = await _categoryRepository.GetByIdAsync(request.Id);

            if (category == null)
            {
                throw new OpenQA.Selenium.NotFoundException("Not Found Category");
            }
            CategoryDto categoryDto = new CategoryDto() 
            {
                  Id = category.Id,
                  Name=request.lang=="ar"? category.ArabicName: category.EnglishName,
                  Description=request.lang=="ar" ? category.ArabicDescription : category.EnglishDescription,
                  Icon=category.Icon,
                  CategoryClassification=category.CategoryClassification,
                  ExpectedNumberOfWinners=category.ExpectedNumberOfWinners,
                  FinalArbitrationEndDate = category.FinalArbitrationEndDate,
                  FinalArbitrationQualificationMark= category.FinalArbitrationQualificationMark,
                  FinalArbitrationStartDate=category.FinalArbitrationStartDate,
                  InitialArbitrationEndDate=category.InitialArbitrationEndDate,
                  InitialArbitrationStartDate= category.InitialArbitrationStartDate,
                  RelatedToClasses=category.RelatedToClasses,
                  Status=category.Status,
                  SubscriberPortalClosingDate=category.SubscriberPortalClosingDate,
                  WinningScore = category.WinningScore
            };
            return _mapper.Map<CategoryDto>(categoryDto);

        }
    }
}
