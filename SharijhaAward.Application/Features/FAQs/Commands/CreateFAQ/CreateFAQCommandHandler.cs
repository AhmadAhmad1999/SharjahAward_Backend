using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.CategoryModel;
using SharijhaAward.Domain.Entities.CycleModel;
using SharijhaAward.Domain.Entities.FAQModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.FAQs.Commands.CreateFAQ
{
    public class CreateFAQCommandHandler 
        :IRequestHandler<CreateFAQCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<FrequentlyAskedQuestion> _faQRepository;
        private readonly IAsyncRepository<Cycle> _cycleRepository;
        private readonly IMapper _mapper;

        public CreateFAQCommandHandler(
            IAsyncRepository<FrequentlyAskedQuestion> faQRepository, 
            IAsyncRepository<Cycle> cycleRepository,
            IMapper mapper
            )
        {
            _faQRepository = faQRepository;
            _cycleRepository = cycleRepository;
            _mapper = mapper;
        }

        public async Task<BaseResponse<object>> Handle(CreateFAQCommand request, CancellationToken cancellationToken)
        {
            FrequentlyAskedQuestion faq = _mapper.Map<FrequentlyAskedQuestion>(request);
            Cycle cycle = await _cycleRepository.GetByIdAsync(faq.CycleId);
            string msg;
            if (cycle == null)
            {
                msg = request.lang.ToLower() == "en"
                    ? "Cycle not Found"
                    : "الدورة غير موجودة";

                return new BaseResponse<object>(msg, false, 404);
            }
            await _faQRepository.AddAsync(faq);

            msg = request.lang == "en"
                ? "FAQ has been Created"
                : "تم إضافة السؤال الشائع";

            return new BaseResponse<object>(msg, true, 200);
         
        }
    }
}
