using AutoMapper;
using MediatR;
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

namespace SharijhaAward.Application.Features.TermsAndConditions.Attacments.Queries.ReviewSpecialConditionAttachments
{
    public class ReviewSpecialConditionAttachmentsQueryHandler
        : IRequestHandler<ReviewSpecialConditionAttachmentsQuery, BaseResponse<List<SpecialTermAndConditionListVM>>>
    {
        private readonly IAsyncRepository<TermAndCondition> _termRepository;
        private readonly IAsyncRepository<ConditionsProvidedForms> _conditionsProvidedFormsRepository;
        private readonly IAsyncRepository<ConditionAttachment> _conditionAttachmentRepository;
        private readonly IAsyncRepository<Domain.Entities.ProvidedFormModel.ProvidedForm> _providedFormRepository;
        private readonly IUserRepository _userRepository;
        private readonly IJwtProvider _jwtProvider;
        private readonly IMapper _mapper;

        public ReviewSpecialConditionAttachmentsQueryHandler(IAsyncRepository<TermAndCondition> termRepository, IAsyncRepository<ConditionsProvidedForms> conditionsProvidedFormsRepository, IAsyncRepository<ConditionAttachment> conditionAttachmentRepository, IAsyncRepository<Domain.Entities.ProvidedFormModel.ProvidedForm> providedFormRepository, IUserRepository userRepository, IJwtProvider jwtProvider, IMapper mapper)
        {
            _termRepository = termRepository;
            _conditionsProvidedFormsRepository = conditionsProvidedFormsRepository;
            _conditionAttachmentRepository = conditionAttachmentRepository;
            _providedFormRepository = providedFormRepository;
            _userRepository = userRepository;
            _jwtProvider = jwtProvider;
            _mapper = mapper;
        }

        public async Task<BaseResponse<List<SpecialTermAndConditionListVM>>> Handle(ReviewSpecialConditionAttachmentsQuery request, CancellationToken cancellationToken)
        {
           
            string msg;
      
            var UserId = _jwtProvider.GetUserIdFromToken(request.token);
            var user = await _userRepository.GetByIdAsync(int.Parse(UserId));
            var form = await _providedFormRepository.FirstOrDefaultAsync(p => p.Id == request.formId);
            if(form == null)
            {
                msg = request.lang == "en"
                   ? "Provided Form Not Found"
                   : "الإستمارة غير موجودة";

                return new BaseResponse<List<SpecialTermAndConditionListVM>>("Form not Found", false, 404);
            }
            var Terms = _termRepository
                .WhereThenInclude(t => t.CategoryId == form.categoryId && t.NeedAttachment == true, t => t.ConditionAttachments)
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

            var data = _mapper.Map<List<SpecialTermAndConditionListVM>>(Terms);

            for (int i = 0; i < data.Count; i++)
            {
                data[i].Attachments = _mapper.Map<List<AttachmentListVM>>(conditionsProvideds[i].Attachments);

                data[i].Title = request.lang == "en"
                    ? data[i].EnglishTitle
                    : data[i].ArabicTitle;

                data[i].Description = request.lang == "en"
                    ? data[i].EnglishDescription
                    : data[i].ArabicDescription;
            }
            data = data.OrderByDescending(a => a.CreateAt).ToList();

            return new BaseResponse<List<SpecialTermAndConditionListVM>>("", true, 200, data);
        }
    }
}
