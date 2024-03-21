using AutoMapper;
using MediatR;
using OpenQA.Selenium.DevTools.V119.Network;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.CategoryModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.Categories.Command.UpdateCategory
{
    public class UpdateCategoryCommandHandler
        : IRequestHandler<UpdateCategoryCommand , BaseResponse<object>>
    {
        private readonly IAsyncRepository<Category> _categoryRepository;
        private readonly IFileService _fileService;
        private readonly IMapper _mapper;

        public UpdateCategoryCommandHandler(IAsyncRepository<Category> categoryRepository, IMapper mapper, IFileService fileService)
        {
            _categoryRepository = categoryRepository;
            _fileService = fileService;
            _mapper = mapper;
        }

        public async Task<BaseResponse<object>> Handle(UpdateCategoryCommand request, CancellationToken cancellationToken)
        {
            var categoryToUpdate = await _categoryRepository.GetByIdAsync(request.Id);
            string msg;
            if (categoryToUpdate == null)
            {
                msg = request.lang == "en"
                    ? "Category not found"
                    : "الفئة غير موجودة";

                return new BaseResponse<object>(msg, false, 404);
            }
            _mapper.Map(request, categoryToUpdate, typeof(UpdateCategoryCommand), typeof(Category));
            if (request.UpdateOnIcon)
                categoryToUpdate.Icon = await _fileService.SaveFileAsync(request.Icon);
            
            await _categoryRepository.UpdateAsync(categoryToUpdate);
           
            msg = request.lang == "en"
                ? "The Category has been Updated"
                : "تم تعديل الفئة بنجاح";

            return new BaseResponse<object>(msg, true, 200);
        }
    }
}
