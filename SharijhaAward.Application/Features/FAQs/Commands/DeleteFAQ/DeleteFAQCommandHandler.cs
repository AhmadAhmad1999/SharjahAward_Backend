using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Domain.Entities.FAQModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.FAQs.Commands.DeleteFAQ
{
    public class DeleteFAQCommandHandler
        : IRequestHandler<DeleteFAQCommand, Unit>
    {
        private readonly IAsyncRepository<FrequentlyAskedQuestion> _faqRepository;
      

        public DeleteFAQCommandHandler(IAsyncRepository<FrequentlyAskedQuestion> faqRepository)
        {
            _faqRepository = faqRepository;
           
        }

        public async Task<Unit> Handle(DeleteFAQCommand request, CancellationToken cancellationToken)
        {
            var faqToDelete = await  _faqRepository.GetByIdAsync(request.Id);
            if (faqToDelete == null) 
            {
                throw new OpenQA.Selenium.NotFoundException("Frequently Asked Question Not Found");
            }

            await _faqRepository.DeleteAsync(faqToDelete);

            return Unit.Value;

        }
    }
}
