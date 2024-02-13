using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Domain.Entities.FAQModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.FAQs.Commands.UpdateFAQ
{
    public class UpdateFAQCommandHandler 
        : IRequestHandler<UpdateFAQCommand, Unit>
    {
        private readonly IAsyncRepository<FrequentlyAskedQuestion> _faqRepository;
        private readonly IMapper _mapper;

        public UpdateFAQCommandHandler(IAsyncRepository<FrequentlyAskedQuestion> faqRepository, IMapper mapper)
        {
            _faqRepository = faqRepository;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(UpdateFAQCommand request, CancellationToken cancellationToken)
        {
            FrequentlyAskedQuestion faqToUpdate =await _faqRepository.GetByIdAsync(request.Id);
            if (faqToUpdate == null)
            {
                throw new OpenQA.Selenium.NotFoundException("Frequently Asked Question Not Found");
            }

            _mapper.Map(request, faqToUpdate, typeof(UpdateFAQCommand), typeof(FrequentlyAskedQuestion));
            
            await _faqRepository.UpdateAsync(faqToUpdate);
            
            return Unit.Value;
        }
    }
}
