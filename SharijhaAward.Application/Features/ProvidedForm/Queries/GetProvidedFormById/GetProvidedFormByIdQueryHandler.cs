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

namespace SharijhaAward.Application.Features.ProvidedForm.Queries.GetProvidedFormById
{
    public class GetProvidedFormByIdQueryHandler
        : IRequestHandler<GetProvidedFormByIdQuery, BaseResponse<ProvidedFormDto>>
    {
        private readonly IAsyncRepository<Domain.Entities.ProvidedFormModel.ProvidedForm> _formRepository;
        private readonly IAsyncRepository<Category> _categoryRepository;       
        private readonly IUserRepository _userRepository;       
        private readonly IMapper _mapper;

        public GetProvidedFormByIdQueryHandler(IAsyncRepository<Category> categoryRepository, IUserRepository userRepository, IAsyncRepository<Domain.Entities.ProvidedFormModel.ProvidedForm> formRepository, IMapper mapper)
        {
            _formRepository = formRepository;
            _categoryRepository = categoryRepository;
            _userRepository = userRepository;
            _mapper = mapper;
        }

        public async Task<BaseResponse<ProvidedFormDto>> Handle(GetProvidedFormByIdQuery request, CancellationToken cancellationToken)
        {

            var User = await _userRepository.GetByIdAsync(request.UserId);

            if (User == null)
            {
                return new BaseResponse<ProvidedFormDto>("User Not Found", false, 404);
            }

            var form = await _formRepository.FirstOrDefaultAsync(f => f.Id == request.Id);

             if (form == null)
             {
                 return new BaseResponse<ProvidedFormDto>("Provided Form Not Found", false, 404);
             }
            var Subcategory = await _categoryRepository.GetByIdAsync(form.categoryId);
            var Maincategory = await _categoryRepository.GetByIdAsync(Subcategory!.ParentId);
            
            var data = _mapper.Map<ProvidedFormDto>(form);
            
            data.MainCategoryName = request.lang == "en" ? Maincategory.EnglishName : Maincategory.ArabicName;
            data.SubCategoryName = request.lang == "en" ? Subcategory.EnglishName : Subcategory.ArabicName;
           
            return new BaseResponse<ProvidedFormDto>("", true, 200, data);

        }
    }
}
