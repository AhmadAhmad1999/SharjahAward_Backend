using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.FAQModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.FAQs.Commands.DeleteFAQ
{
    public class DeleteFAQCommandHandler
        : IRequestHandler<DeleteFAQCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<FrequentlyAskedQuestion> _faqRepository;
      

        public DeleteFAQCommandHandler(IAsyncRepository<FrequentlyAskedQuestion> faqRepository)
        {
            _faqRepository = faqRepository;
           
        }

        public async Task<BaseResponse<object>> Handle(DeleteFAQCommand request, CancellationToken cancellationToken)
        {
            var faqToDelete = await _faqRepository.GetByIdAsync(request.Id);
            string msg;

            if (faqToDelete == null) 
            {
                msg = request.lang == "en"
                    ? "FAQ Not Found"
                    : "السؤال الشائع غير موجود";

                return new BaseResponse<object>(msg,false,404);
            }
            await _faqRepository.DeleteAsync(faqToDelete);

            msg = request.lang == "en"
                   ? "FAQ has been Deleted"
                   : "تم حذف السؤال الشائع";

            return new BaseResponse<object>(msg, false, 404);
        }
    }
}
