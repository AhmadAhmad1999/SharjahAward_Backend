using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Common;
using SharijhaAward.Domain.Entities.CategoryModel;

namespace SharijhaAward.Application.Features.ProvidedForm.Queries.GetAllProvidedForms
{
    public class GetAllProvidedFormsQueryHandler
        : IRequestHandler<GetAllProvidedFormsQuery, BaseResponse<List<FormListVm>>>
    {
        private readonly IAsyncRepository<Domain.Entities.ProvidedFormModel.ProvidedForm> _formRepository;
        private readonly IAsyncRepository<Domain.Entities.IdentityModels.User> _userRepository;
        private readonly IAsyncRepository<Category> _categoryRepository;
        private readonly IJwtProvider _jwtProvider;
        private readonly IMapper _mapper;

        public GetAllProvidedFormsQueryHandler(IAsyncRepository<Domain.Entities.ProvidedFormModel.ProvidedForm> formRepository, IAsyncRepository<Domain.Entities.IdentityModels.User> userRepository, IAsyncRepository<Category> categoryRepository, IJwtProvider jwtProvider, IMapper mapper)
        {
            _formRepository = formRepository;
            _userRepository = userRepository;
            _categoryRepository = categoryRepository;
            _jwtProvider = jwtProvider;
            _mapper = mapper;
        }

        public async Task<BaseResponse<List<FormListVm>>> Handle(GetAllProvidedFormsQuery request, CancellationToken cancellationToken)
        {
            var UserId = _jwtProvider.GetUserIdFromToken(request.token);
            var User = await _userRepository.GetByIdAsync(int.Parse(UserId));
            if (User == null)
            {
                return new BaseResponse<List<FormListVm>> ("", false, 401);
            }
           
            FilterObject filterObject = new FilterObject() { Filters= request.filters };

            var form = request.Type == null
                ? await _formRepository.WhereThenFilter(f => f.userId == User.Id, filterObject).OrderByDescending(x => x.CreatedAt).ToListAsync()
                : await _formRepository.WhereThenFilter(f => f.userId == User.Id, filterObject).Where(f=>f.Type==request.Type)
                    .OrderByDescending(x => x.CreatedAt).ToListAsync();
           
            var data = _mapper.Map<List<FormListVm>> (form);
            for (int i = 0; i < data.Count(); i++)
            {
                var SubCategory = await _categoryRepository.GetByIdAsync(form[i].categoryId);
                var Category = await _categoryRepository.GetByIdAsync(SubCategory!.ParentId);
                
                if(SubCategory == null)
                {
                    return new BaseResponse<List<FormListVm>>("", false, 400);
                }

                data[i].SubCategoryName = request.lang=="en"
                    ? SubCategory.EnglishName
                    : SubCategory.ArabicName;

                data[i].CategoryName = request.lang == "en"
                    ? Category.EnglishName
                    : Category.ArabicName;
            }
            return new BaseResponse<List<FormListVm>> ("", true, 200, data);
        }
    }
}
