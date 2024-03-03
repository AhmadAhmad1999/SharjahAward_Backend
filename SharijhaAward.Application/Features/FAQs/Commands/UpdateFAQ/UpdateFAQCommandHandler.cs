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

namespace SharijhaAward.Application.Features.FAQs.Commands.UpdateFAQ
{
    public class UpdateFAQCommandHandler 
        : IRequestHandler<UpdateFAQCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<FrequentlyAskedQuestion> _faqRepository;
        private readonly IMapper _mapper;

        public UpdateFAQCommandHandler(IAsyncRepository<FrequentlyAskedQuestion> faqRepository, IMapper mapper)
        {
            _faqRepository = faqRepository;
            _mapper = mapper;
        }

        public async Task<BaseResponse<object>> Handle(UpdateFAQCommand request, CancellationToken cancellationToken)
        {
            FrequentlyAskedQuestion faqToUpdate =await _faqRepository.GetByIdAsync(request.Id);
            string msg;
            if (faqToUpdate == null)
            {
                msg = request.lang == "en"
                    ? "The FAQ Not Found"
                    : "السؤال الشائع غير موجوع";
                return new BaseResponse<object>(msg, false, 404);
            }

            _mapper.Map(request, faqToUpdate, typeof(UpdateFAQCommand), typeof(FrequentlyAskedQuestion));
            
            await _faqRepository.UpdateAsync(faqToUpdate);

            msg = request.lang == "en"
                ? "FAQ has been Updated"
                : "تم تعديل السؤال الشائع";

            return new BaseResponse<object>(msg, true, 200);
        }
    }
}
