using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Features.TermsAndConditions.Queries.GetAllTermAndCondition;
using SharijhaAward.Application.Features.TermsAndConditions.Queries.GetAllTermsByCategoryId;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.AttachmentModel;
using SharijhaAward.Domain.Entities.CategoryModel;
using SharijhaAward.Domain.Entities.ConditionsProvidedFormsModel;
using SharijhaAward.Domain.Entities.TermsAndConditionsModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.TermsAndConditions.Queries.GetAllSpecialConditionsByCategoryId
{
    public class GetAllSpecialConditionsByCategoryIdQueryHandler
        : IRequestHandler<GetAllSpecialConditionsByCategoryIdQuery, BaseResponse<List<TermAndConditionListVM>>>
    {
        private readonly IAsyncRepository<Category> _categoryRepository;
        private readonly IAsyncRepository<TermAndCondition> _termRepository;
        private readonly IAsyncRepository<ConditionsProvidedForms> _conditionsProvidedFormsRepository;
        private readonly IAsyncRepository<ConditionAttachment> _conditionAttachmentRepository;
        private readonly IAsyncRepository<Domain.Entities.ProvidedFormModel.ProvidedForm> _providedFormRepository;
        private readonly IUserRepository _userRepository;
        private readonly IJwtProvider _jwtProvider;
        private readonly IMapper _mapper;

        public GetAllSpecialConditionsByCategoryIdQueryHandler(
            IAsyncRepository<Category> categoryRepository,
            IAsyncRepository<TermAndCondition> termRepository,
            IAsyncRepository<ConditionsProvidedForms> conditionsProvidedFormsRepository,
            IAsyncRepository<ConditionAttachment> conditionAttachmentRepository,
            IAsyncRepository<Domain.Entities.ProvidedFormModel.ProvidedForm> providedFormRepository,
            IUserRepository userRepository,
            IJwtProvider jwtProvider,
            IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _providedFormRepository = providedFormRepository;
            _conditionAttachmentRepository = conditionAttachmentRepository;
            _termRepository = termRepository;
            _conditionsProvidedFormsRepository = conditionsProvidedFormsRepository;
            _userRepository = userRepository;
            _jwtProvider = jwtProvider;
            _mapper = mapper;
        }

        public async Task<BaseResponse<List<TermAndConditionListVM>>> Handle(GetAllSpecialConditionsByCategoryIdQuery request, CancellationToken cancellationToken)
        {
            var category = await _categoryRepository.GetByIdAsync(request.CategoryId);
            string msg;
            if (category == null)
            {
                msg = request.lang == "en"
                    ? "Category Not Found"
                    : "الفئة غير موجودة";

                return new BaseResponse<List<TermAndConditionListVM>>(msg, false, 404);
            }
            var UserId = _jwtProvider.GetUserIdFromToken(request.token);
            var user = await _userRepository.GetByIdAsync(int.Parse(UserId));
            var form = await _providedFormRepository.FirstOrDefaultAsync(p => p.Id == request.formId);

            var Terms = _termRepository
                .WhereThenInclude(t => t.CategoryId == category.Id, t => t.ConditionAttachments)
                .Where(t => t.IsSpecial == true)
                .OrderByDescending(x => x.CreatedAt).ToList();

            List<ConditionsProvidedForms> conditionsProvideds = new List<ConditionsProvidedForms>();

            for (int i = 0; i < Terms.Count(); i++)
            {
                var conditionsProvidedsobject =
                 _conditionsProvidedFormsRepository.WhereThenInclude(
                     c => c.ProvidedFormId == form!.Id && c.TermAndConditionId == Terms[i].Id,
                     c => c.Attachments).FirstOrDefault();

                if (conditionsProvidedsobject != null)
                    conditionsProvideds.Add(conditionsProvidedsobject!);
            }

            var data = _mapper.Map<List<TermAndConditionListVM>>(Terms);
            
            for (int i = 0; i < data.Count; i++)
            {
                data[i].ConditionsAttachments = _mapper.Map<ConditionProvidedFormListVm>(conditionsProvideds[i]);

                if (data[i].NeedAttachment)
                {

                    data[i].ConditionsAttachments!.Attachments = _mapper.Map<List<AttachmentListVM>>(conditionsProvideds[i].Attachments);

                }


                data[i].Title = request.lang == "en"
                    ? data[i].EnglishTitle
                    : data[i].ArabicTitle;

                data[i].Description = request.lang == "en"
                    ? data[i].EnglishDescription
                    : data[i].ArabicDescription;
            }
            data = data.OrderByDescending(a => a.CreateAt).ToList();

            return new BaseResponse<List<TermAndConditionListVM>>("", true, 200, data);
        }
    }
}
