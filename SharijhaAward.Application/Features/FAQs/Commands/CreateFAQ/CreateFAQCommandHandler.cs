using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Domain.Entities.CategoryModel;
using SharijhaAward.Domain.Entities.FAQModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.FAQs.Commands.CreateFAQ
{
    public class CreateFAQCommandHandler 
        :IRequestHandler<CreateFAQCommand, Unit>
    {
        private readonly IAsyncRepository<FrequentlyAskedQuestion> _faQRepository;
        private readonly IAsyncRepository<Category> _categoryRepository;
        private readonly IMapper _mapper;

        public CreateFAQCommandHandler(
            IAsyncRepository<FrequentlyAskedQuestion> faQRepository, 
            IAsyncRepository<Category> categoryRepository,
            IMapper mapper
            )
        {
            _faQRepository = faQRepository;
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(CreateFAQCommand request, CancellationToken cancellationToken)
        {
            FrequentlyAskedQuestion faq = _mapper.Map<FrequentlyAskedQuestion>(request );
            Category category = await _categoryRepository.GetByIdAsync(faq.CategoryId);
            if (category == null)
            {
                throw new OpenQA.Selenium.NotFoundException("Category Not Found");
            }
            await _faQRepository.AddAsync(faq);

            category.FrequentlyAskedQuestions.Add(faq);

            await _categoryRepository.UpdateAsync(category);

            return Unit.Value;
         
        }
    }
}
