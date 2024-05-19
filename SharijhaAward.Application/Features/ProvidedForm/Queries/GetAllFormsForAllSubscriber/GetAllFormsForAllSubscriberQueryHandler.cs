using AutoMapper;
using ErrorOr;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Features.ProvidedForm.Queries.GetAllProvidedForms;
using SharijhaAward.Application.Features.ProvidedForm.Queries.GetAllProvidedFormsForAllSubscriber;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Constants.Common;
using SharijhaAward.Domain.Constants.ProvidedFromConstants;
using SharijhaAward.Domain.Entities.CategoryModel;
using SharijhaAward.Domain.Entities.DynamicAttributeModel;
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
        private readonly IAsyncRepository<DynamicAttributeValue> _DynamicAttributeValueRepository;
        private readonly IMapper _mapper;

        public GetAllFormsForAllSubscriberQueryHandler(IAsyncRepository<Category> categoryRepository, IAsyncRepository<Domain.Entities.ProvidedFormModel.ProvidedForm> formRepository, IMapper mapper,
            IAsyncRepository<DynamicAttributeValue> DynamicAttributeValueRepository)
        {
            _formRepository = formRepository;
            _categoryRepository = categoryRepository;
            _mapper = mapper;
            _DynamicAttributeValueRepository = DynamicAttributeValueRepository;
        }

        public async Task<BaseResponse<List<FormListVm>>> Handle(GetAllFormsForAllSubscriberQuery request, CancellationToken cancellationToken)
        {
            var forms = await _formRepository.GetPagedReponseAsync(request.page, request.pageSize);
            
            var SubscribersNames = await _DynamicAttributeValueRepository
                .Include(x => x.DynamicAttribute!)
                .Include(x => x.DynamicAttribute!.DynamicAttributeSection!)
                .Where(x => forms.Select(y => y.Id).Any(y => y == x.RecordId) &&
                    x.DynamicAttribute!.DynamicAttributeSection!.EnglishName == "Main Information" &&
                    x.DynamicAttribute!.EnglishTitle == "Full name (identical to Emirates ID)")
                .Select(x => new
                {
                    x.RecordId,
                    x.Value
                }).ToListAsync();

            var Categories = await _categoryRepository
                .Where(x => forms.Select(y => y.categoryId).Contains(x.Id))
                .Include(x => x.Parent!).ToListAsync();

            var data = forms.Select(x => new FormListVm()
            {
                Id = x.Id,
                SubscriberName = SubscribersNames.FirstOrDefault(y => y.RecordId == x.Id)!.Value,
                PercentCompletion = x.PercentCompletion,
                CycleNumber = x.CycleNumber,
                CycleYear = x.CycleYear,
                Type = x.Type,
                Status = x.Status,
                SubscriberType = x.SubscriberType,
                CurrentStep = x.CurrentStep,
                TotalStep = x.TotalStep,
                FinalScore = x.FinalScore,
                IsAccepted = x.IsAccepted,
                categoryId = x.categoryId,
                CreatedAt = x.CreatedAt,
                CategoryName = request.lang == "en"
                    ? Categories.FirstOrDefault(y => y.Id == x.categoryId)!.Parent!.EnglishName
                    : Categories.FirstOrDefault(y => y.Id == x.categoryId)!.Parent!.ArabicName,
                SubCategoryName = request.lang == "en"
                    ? Categories.FirstOrDefault(y => y.Id == x.categoryId)!.EnglishName
                    : Categories.FirstOrDefault(y => y.Id == x.categoryId)!.ArabicName
            }).ToList();

            //foreach (var form in data)
            //{
            //    var SubCategory = await _categoryRepository.GetByIdAsync(form.categoryId);
            //    var Category = await _categoryRepository.GetByIdAsync(SubCategory!.ParentId);
              
            //    if(Category != null)
            //         form.CategoryName = request.lang == "en"
            //            ? Category.EnglishName 
            //            : Category.ArabicName;

            //    form.SubCategoryName = request.lang == "en"
            //            ? SubCategory.EnglishName 
            //            : SubCategory.ArabicName;
            //}

            int count = _formRepository.GetCount(f => !f.isDeleted);

            Pagination pagination = new Pagination(request.page, request.pageSize, count);

            return new BaseResponse<List<FormListVm>>("", true, 200, data, pagination);

        
        }
    }
}
