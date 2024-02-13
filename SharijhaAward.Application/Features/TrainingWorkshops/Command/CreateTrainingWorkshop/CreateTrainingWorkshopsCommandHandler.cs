using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Domain.Entities.CategoryModel;
using SharijhaAward.Domain.Entities.TrainingWorkshopModel;


namespace SharijhaAward.Application.Features.TrainingWorkshops.Command.CreateTrainingWorkshop
{
    public class CreateTrainingWorkshopsCommandHandler
        : IRequestHandler<CreateTrainingWorkshopsCommand , Unit>
    {
        private readonly IAsyncRepository<TrainingWorkshop> _trainingWorkshopRepository;
        private readonly IAsyncRepository<Category> _categoryRepository;
        private readonly IMapper _mapper;

        public CreateTrainingWorkshopsCommandHandler(
            IAsyncRepository<TrainingWorkshop> trainingWorkshopRepository,
            IAsyncRepository<Category> categoryRepository,
            IMapper mapper
            )
        {
            _trainingWorkshopRepository = trainingWorkshopRepository;
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(CreateTrainingWorkshopsCommand request, CancellationToken cancellationToken)
        {
            TrainingWorkshop workshop = _mapper.Map<TrainingWorkshop>(request);
            Category category = await _categoryRepository.GetByIdAsync(workshop.CategoryId);
            if (category == null)
            {
                throw new OpenQA.Selenium.NotFoundException("Category Not Found");
            }
            await _trainingWorkshopRepository.AddAsync(workshop);

            category.TrainingWorkshops.Add(workshop);

            await _categoryRepository.UpdateAsync(category);
            
            return Unit.Value;
        }
    }
}
