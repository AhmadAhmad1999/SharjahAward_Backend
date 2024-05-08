using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Features.ProvidedForm.Queries.GetAllProvidedForms;
using SharijhaAward.Application.Features.ProvidedForm.Queries.GetAllProvidedFormsForAllSubscriber;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.CategoryModel;
using SharijhaAward.Domain.Entities.ProvidedFormModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.ProvidedForm.Queries.GetAllFormsForAllSubscriber
{
    public class GetAllFormsForAllSubscriberQueryHandler
        : IRequestHandler<GetAllFormsForAllSubscriberQuery, BaseResponse<List<FormListVm>>>
    {
        private readonly IAsyncRepository<Domain.Entities.ProvidedFormModel.ProvidedForm> _formRepository;
        private readonly IAsyncRepository<Category> _categoryRepository;
        private readonly IMapper _mapper;

        public GetAllFormsForAllSubscriberQueryHandler(IAsyncRepository<Category> categoryRepository, IAsyncRepository<Domain.Entities.ProvidedFormModel.ProvidedForm> formRepository, IMapper mapper)
        {
            _formRepository = formRepository;
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }

        public async Task<BaseResponse<List<FormListVm>>> Handle(GetAllFormsForAllSubscriberQuery request, CancellationToken cancellationToken)
        {
            var forms = await _formRepository.GetPagedReponseAsync(request.page, request.pageSize);
            
            var data = _mapper.Map<List<FormListVm>>(forms);

            foreach(var form in data)
            {
                var Category = await _categoryRepository.GetByIdAsync(form.categoryId);
              
                if(Category != null)
                     form.CategoryName = request.lang == "en"? Category.EnglishName : Category.ArabicName;
            }

            int count = _formRepository.GetCount(f => !f.isDeleted);

            Pagination pagination = new Pagination(request.page, request.pageSize, count);

            return new BaseResponse<List<FormListVm>>("", true, 200, data, pagination);

        
        }
    }
}
