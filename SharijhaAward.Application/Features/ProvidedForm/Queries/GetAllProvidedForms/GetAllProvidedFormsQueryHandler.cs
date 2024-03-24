using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.CategoryModel;
using SharijhaAward.Domain.Entities.IdentityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


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
            var User = await _userRepository.GetByIdAsync(new Guid(UserId));
            if (User == null)
            {
                return new BaseResponse<List<FormListVm>> ("", false, 401);
            }

            var form = request.Type == null
                ? _formRepository.Where(f => f.userId == User.Id).ToList()
                : _formRepository.Where(f => f.userId == User.Id).Where(f=>f.Type==request.Type).ToList();

            var data = _mapper.Map<List<FormListVm>> (form);
            for (int i = 0; i < data.Count(); i++)
            {
                data[i].CategoryName = request.lang=="en"
                    ? (await _categoryRepository.GetByIdAsync(form[i].categoryId)).EnglishName
                    : (await _categoryRepository.GetByIdAsync(form[i].categoryId)).ArabicName;
            }
            return new BaseResponse<List<FormListVm>> ("", true, 200, data);
        }
    }
}
