using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.CategoryModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.Categories.Queries.GetAllCategories
{
    public class GetAllCategoryQueryHandler
        : IRequestHandler<GetAllCategoryQuery, BaseResponse<List<CategoryListVM>>>
    {
        private readonly IAsyncRepository<Category> _categoryRepository;
        private readonly IMapper _mapper;

        public GetAllCategoryQueryHandler(IAsyncRepository<Category> categoryRepository, IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }
        public async Task<BaseResponse<List<CategoryListVM>>> Handle(GetAllCategoryQuery request, CancellationToken cancellationToken)
        {
            var categories = await _categoryRepository.GetPagedReponseAsync(request.page,request.pageSize);

            var data = _mapper.Map<List<CategoryListVM>>(categories);

            for (int i = 0; i < data.Count; i++)
            {
                data[i].Name = request.lang == "ar" ? data[i].ArabicName : data[i].EnglishName;
                data[i].Description = request.lang == "ar" ? data[i].ArabicDescription : data[i].EnglishDescription;
            }
            int count = _categoryRepository.GetCount(c=>c.isDeleted == false);
            Pagination pagination = new Pagination(request.page,request.pageSize,count);
            return new BaseResponse<List<CategoryListVM>>("", true, 200,data, pagination);
        }
    }
}
