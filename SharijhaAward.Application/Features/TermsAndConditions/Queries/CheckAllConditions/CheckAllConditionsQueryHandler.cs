using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
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

namespace SharijhaAward.Application.Features.TermsAndConditions.Queries.CheckAllConditions
{
    public class CheckAllConditionsQueryHandler
        : IRequestHandler<CheckAllConditionsQuery, BaseResponse<object>>
    {
        private readonly IAsyncRepository<ConditionAttachment> _conditionAttachmentRepository;
        private readonly IAsyncRepository<Category> _categoryRepository;
        private readonly IAsyncRepository<TermAndCondition> _termRepository;
        private readonly IAsyncRepository<ConditionsProvidedForms> _conditionsProvidedFormsRepository;
        private readonly IAsyncRepository<Domain.Entities.ProvidedFormModel.ProvidedForm> _providedFormRepository;
        private readonly IUserRepository _userRepository;
        private readonly IJwtProvider _jwtProvider;
        private readonly IMapper _mapper;

        public CheckAllConditionsQueryHandler(
            IAsyncRepository<ConditionAttachment> conditionAttachmentRepository,
            IAsyncRepository<ConditionsProvidedForms> conditionsProvidedFormsRepository,
            IAsyncRepository<Category> categoryRepository, 
            IAsyncRepository<TermAndCondition> termRepository,
            IAsyncRepository<Domain.Entities.ProvidedFormModel.ProvidedForm> providedFormRepository,
            IUserRepository userRepository,
            IJwtProvider jwtProvider,
            IMapper mapper
            )
        {
            _conditionAttachmentRepository = conditionAttachmentRepository;
            _conditionsProvidedFormsRepository = conditionsProvidedFormsRepository;
            _categoryRepository = categoryRepository;
            _termRepository = termRepository;
            _userRepository = userRepository;
            _jwtProvider = jwtProvider;
            _mapper = mapper;
            _providedFormRepository = providedFormRepository;
        }

        public async Task<BaseResponse<object>> Handle(CheckAllConditionsQuery request, CancellationToken cancellationToken)
        {
           var category = await _categoryRepository.GetByIdAsync(request.CategoryId);
            if(category == null)
            {
                return new BaseResponse<object>("", false, 404);
            }
         
            var form = _providedFormRepository.Where(p => p.Id == request.formId).FirstOrDefault();

            var terms = _termRepository.WhereThenInclude(t => t.CategoryId == category.Id, t => t.ConditionAttachments).Where(t => t.IsSpecial == false).ToList();

            List<ConditionsProvidedForms> conditionsProvideds = new List<ConditionsProvidedForms>();

            for (int i = 0; i < terms.Count(); i++)
            {
                var conditionsProvidedsobject =
                 _conditionsProvidedFormsRepository.WhereThenInclude(
                     c => c.ProvidedFormId == form!.Id && c.TermAndConditionId == terms[i].Id,
                     c => c.Attachments).FirstOrDefault();

                if (conditionsProvidedsobject != null)
                    conditionsProvideds.Add(conditionsProvidedsobject!);
            }

            //List<AttachmentListVM> Attachmets = _mapper.Map<List<AttachmentListVM>>(await _conditionAttachmentRepository
            //   .Include(x => x.ConditionsProvidedForms).Include(x => x.ConditionsProvidedForms.TermAndCondition)
            //   .Where(x => x.ConditionsProvidedForms.TermAndCondition.CategoryId == category.Id &&
            //       x.ConditionsProvidedForms.TermAndCondition.IsSpecial == false &&
            //       x.ConditionsProvidedForms.ProvidedFormId == form!.Id).ToListAsync());

            string msg;
            if(terms.Count() != 0)
            {
                for(int i=0; i < terms.Count(); i++)
                {
                    //Check on Terms that need Attachments
                    if (terms[i].RequiredAttachmentNumber != conditionsProvideds[i].Attachments.Count() 
                        && terms[i].RequiredAttachmentNumber != 0 )
                    {
                        msg = request.lang == "en"
                            ? "Please Complete Uploading The File "
                            : "الرجاء إكمال رفع الملفات";

                        return new BaseResponse<object>(msg, false, 400);

                    }
                    //Check on Terms that don't need Attachments
                    else if (!terms[i].IsAgree && !terms[i].NeedAttachment)
                    {
                        msg = request.lang == "en"
                            ? "Pleas Agree on All Terms and Conditions"
                            : "الرجاء الموافقة على جميع الشروط و الأحكام";
                        return new BaseResponse<object>(msg, false, 400);

                    }
                }
            }
            return new BaseResponse<object>("", true, 200);
        }
    }
}
