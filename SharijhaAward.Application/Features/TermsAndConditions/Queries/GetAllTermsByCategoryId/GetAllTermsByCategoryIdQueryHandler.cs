using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Features.TermsAndConditions.Queries.GetAllTermAndCondition;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.CategoryModel;
using SharijhaAward.Domain.Entities.TermsAndConditionsModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.TermsAndConditions.Queries.GetAllTermsByCategoryId
{
    public class GetAllTermsByCategoryIdQueryHandler
        : IRequestHandler<GetAllTermsByCategoryIdQuery, BaseResponse<List<TermAndConditionListVM>>>
    {
        private readonly IAsyncRepository<Category> _categoryRepository;
        private readonly IAsyncRepository<TermAndCondition> _termRepository;
        private readonly IMapper _mapper;

        public GetAllTermsByCategoryIdQueryHandler(
            IAsyncRepository<Category> categoryRepository,
            IAsyncRepository<TermAndCondition> termRepository,
            IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _termRepository = termRepository;
            _mapper = mapper;
        }
        public async Task<BaseResponse<List<TermAndConditionListVM>>> Handle(GetAllTermsByCategoryIdQuery request, CancellationToken cancellationToken)
        {
            var category = await _categoryRepository.GetByIdAsync(request.CategoryId);
            string msg;
            if(category == null)
            {
                msg = request.lang == "en"
                    ? "Category Not Found"
                    : "الفئة غير موجودة";
                return new BaseResponse<List<TermAndConditionListVM>>(msg, false, 404);
            }
            var Terms = _termRepository.WhereThenInclude(t => t.CategoryId == category.Id, t => t.Attachments!).Where(t=>t.IsSpecial==false).ToList();
            
            var data = _mapper.Map<List<TermAndConditionListVM>>(Terms);
            for (int i = 0; i<data.Count; i++)
            {
                data[i].ConditionAttachments = _mapper.Map<List<AttachmentListVM>>(Terms[i].Attachments);
                data[i].Title = request.lang == "en"
                    ? data[i].EnglishTitle
                    : data[i].ArabicTitle;

                data[i].Description = request.lang == "en"
                    ? data[i].EnglishDescription
                    : data[i].ArabicDescription;
            }
            return new BaseResponse<List<TermAndConditionListVM>>("", true, 200, data);
        }
    }
}
