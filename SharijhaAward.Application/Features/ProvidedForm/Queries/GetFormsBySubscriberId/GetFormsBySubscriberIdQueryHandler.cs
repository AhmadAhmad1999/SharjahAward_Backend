using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Features.ProvidedForm.Queries.GetAllProvidedForms;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.CategoryModel;
using SharijhaAward.Domain.Entities.ProvidedFormModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.ProvidedForm.Queries.GetFormsBySubscriberId
{
    public class GetFormsBySubscriberIdQueryHandler
        : IRequestHandler<GetFormsBySubscriberIdQuery, BaseResponse<List<FormsBySubscriberIdListVM>>>
    {
        private readonly IAsyncRepository<Domain.Entities.ProvidedFormModel.ProvidedForm> _formRepository;
        private readonly IAsyncRepository<Category> _categoryRepository;       
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public GetFormsBySubscriberIdQueryHandler(IAsyncRepository<Category> categoryRepository, IAsyncRepository<Domain.Entities.ProvidedFormModel.ProvidedForm> formRepository, IUserRepository userRepository, IMapper mapper)
        {
            _formRepository = formRepository;
            _userRepository = userRepository;
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }

        public async Task<BaseResponse<List<FormsBySubscriberIdListVM>>> Handle(GetFormsBySubscriberIdQuery request, CancellationToken cancellationToken)
        {
            var subscriber = await _userRepository.GetByIdAsync(request.Id);
            
            if (subscriber == null)
            {
                return new BaseResponse<List<FormsBySubscriberIdListVM>>("", false, 404);
            }

            var forms = await _formRepository.GetWhereThenPagedReponseAsync(f => f.userId == subscriber.Id, request.page, request.perPage);

            var data = _mapper.Map<List<FormsBySubscriberIdListVM>>(forms);
            
            for(int i = 0; i < data.Count(); i++)
            {
                var Subcategory = await _categoryRepository.GetByIdAsync(data[i].categoryId);
                var MainCategory = await _categoryRepository.GetByIdAsync(Subcategory!.ParentId);

                data[i].SubCategoryName = request.lang == "en"? Subcategory.EnglishName : Subcategory.ArabicName;
                data[i].MainCategoryName = request.lang == "en" ? MainCategory.EnglishName : MainCategory.ArabicName;
            }
            var count = _formRepository.GetCount(f => f.userId == subscriber.Id);
            
            Pagination pagination = new Pagination(request.page, request.perPage, count);
           
            return new BaseResponse<List<FormsBySubscriberIdListVM>>("", true, 200, data,pagination);
        }
    }
}
