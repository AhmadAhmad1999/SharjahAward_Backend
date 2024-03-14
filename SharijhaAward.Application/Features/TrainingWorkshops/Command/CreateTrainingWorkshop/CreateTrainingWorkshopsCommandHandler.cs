using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.CategoryModel;
using SharijhaAward.Domain.Entities.TrainingWorkshopModel;


namespace SharijhaAward.Application.Features.TrainingWorkshops.Command.CreateTrainingWorkshop
{
    public class CreateTrainingWorkshopsCommandHandler
        : IRequestHandler<CreateTrainingWorkshopsCommand , BaseResponse<Guid>>
    {
        private readonly IAsyncRepository<TrainingWorkshop> _trainingWorkshopRepository;
        private readonly IAsyncRepository<Category> _categoryRepository;
      //  private readonly IFileService<>
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

        public async Task<BaseResponse<Guid>> Handle(CreateTrainingWorkshopsCommand request, CancellationToken cancellationToken)
        {
            TrainingWorkshop workshop = _mapper.Map<TrainingWorkshop>(request);
            Category category = await _categoryRepository.GetByIdAsync(workshop.CategoryId);
            if (category == null)
            {
                return new BaseResponse<Guid>("Category Not Found",false,404);
            }

            var data = await _trainingWorkshopRepository.AddAsync(workshop);

            category.TrainingWorkshops.Add(workshop);

            await _categoryRepository.UpdateAsync(category);

            return new BaseResponse<Guid>("", true, 200, data.Id);
        }
    }
}
