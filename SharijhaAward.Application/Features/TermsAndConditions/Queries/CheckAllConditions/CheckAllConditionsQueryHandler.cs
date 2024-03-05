using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.CategoryModel;
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
        private readonly IAsyncRepository<Category> _categoryRepository;
        private readonly IAsyncRepository<TermAndCondition> _termRepository;

        public CheckAllConditionsQueryHandler(IAsyncRepository<Category> categoryRepository, IAsyncRepository<TermAndCondition> termRepository)
        {
            _categoryRepository = categoryRepository;
            _termRepository = termRepository;
        }

        public async Task<BaseResponse<object>> Handle(CheckAllConditionsQuery request, CancellationToken cancellationToken)
        {
           var category = await _categoryRepository.GetByIdAsync(request.CategoryId);
            if(category == null)
            {
                return new BaseResponse<object>("", false, 404);
            }
            var terms = _termRepository.WhereThenInclude(t => t.CategoryId == category.Id, t => t.Attachments).ToList();
            string msg;
            if(terms.Count() != 0)
            {
                for(int i=0; i < terms.Count(); i++)
                {
                    //Check on Terms that need Attachments
                    if (terms[i].RequiredAttachmentNumber != terms[i].Attachments.Count)
                    {
                        msg = request.lang == "en"
                            ? "Pleas Complete Uploading The File "
                            : "الرجاء إكمال رفع الملفات";

                        return new BaseResponse<object>(msg, false, 400);

                    }
                    //Check on Terms that don't need Attachments
                    if (!terms[i].IsAgree)
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
