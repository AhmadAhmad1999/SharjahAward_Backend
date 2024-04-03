﻿using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.CategoryEducationalClassModel;
using SharijhaAward.Domain.Entities.CategoryModel;

namespace SharijhaAward.Application.Features.Classes.Queries.GetAllCategoryClassesByCategoryId
{
    public class GetAllCategoryClassesByCategoryIdHandler : IRequestHandler<GetAllCategoryClassesByCategoryIdQuery,
        BaseResponse<List<GetAllCategoryClassesByCategoryIdDto>>>
    {
        private readonly IAsyncRepository<CategoryEducationalClass> _CategoryEducationalClassRepository;
        private readonly IAsyncRepository<Category> _CategoryRepository;
        private readonly IMapper _Mapper;
        public GetAllCategoryClassesByCategoryIdHandler(IAsyncRepository<CategoryEducationalClass> CategoryEducationalClassRepository,
            IAsyncRepository<Category> CategoryRepository,
            IMapper Mapper)
        {
            _CategoryEducationalClassRepository = CategoryEducationalClassRepository;
            _CategoryRepository = CategoryRepository;
            _Mapper = Mapper;
        }
        public async Task<BaseResponse<List<GetAllCategoryClassesByCategoryIdDto>>> Handle(GetAllCategoryClassesByCategoryIdQuery Request, 
            CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            Category? CategoryEntity = await _CategoryRepository
                .FirstOrDefaultAsync(x => x.Id == Request.CategoryId);

            if (CategoryEntity == null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Category is not Found"
                    : "الفئة غير موجودة";

                return new BaseResponse<List<GetAllCategoryClassesByCategoryIdDto>>(ResponseMessage, false, 404);
            }

            List<GetAllCategoryClassesByCategoryIdDto> CategoryClasses = await _CategoryEducationalClassRepository
                .Where(x => x.CategoryId == CategoryEntity.Id)
                .Include(x => x.EducationalClass!)
                .Select(x => new GetAllCategoryClassesByCategoryIdDto()
                {
                    Id = x.EducationalClass!.Id,
                    Name = Request.lang == "en"
                        ? x.EducationalClass!.EnglishName
                        : x.EducationalClass!.ArabicName
                }).ToListAsync();

            return new BaseResponse<List<GetAllCategoryClassesByCategoryIdDto>>(ResponseMessage, true, 200, CategoryClasses);
        }
    }
}
