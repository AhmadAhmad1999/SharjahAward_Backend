using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.CategoryModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SharijhaAward.Application.Features.Categories.Queries.ExportToExcel
{
    public class CategoryExportToExcelQueryHandler
        : IRequestHandler<CategoryExportToExcelQuery, BaseResponse<byte[]>>
    {
        private readonly IAsyncRepository<Category> _categoryRepository;
        private readonly IExcelHelper<CategoryExportDto> _excelHelper;
        private readonly IMapper _mapper;

        public CategoryExportToExcelQueryHandler(IMapper mapper, IAsyncRepository<Category> categoryRepository, IExcelHelper<CategoryExportDto> excelHelper)
        {
            _categoryRepository = categoryRepository;
            _excelHelper = excelHelper;
            _mapper = mapper;
        }

        public async Task<BaseResponse<byte[]>> Handle(CategoryExportToExcelQuery request, CancellationToken cancellationToken)
        {
            var categories = await _categoryRepository.ListAllAsync();

            var data = _mapper.Map<List<CategoryExportDto>>(categories);

            var file = _excelHelper.ExportToExcel(data);

            return new BaseResponse<byte[]>("", true, 200, file);
        }
    }
}
