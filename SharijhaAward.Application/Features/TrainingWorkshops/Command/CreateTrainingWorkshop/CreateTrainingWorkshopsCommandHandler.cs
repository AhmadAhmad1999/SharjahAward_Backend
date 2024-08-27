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
        : IRequestHandler<CreateTrainingWorkshopsCommand , BaseResponse<int>>
    {
        private readonly IAsyncRepository<TrainingWorkshop> _trainingWorkshopRepository;
        private readonly IAsyncRepository<Category> _categoryRepository;
        private readonly IFileService _fileService;
        private readonly IMapper _mapper;

        public CreateTrainingWorkshopsCommandHandler(
            IFileService fileService,
            IAsyncRepository<TrainingWorkshop> trainingWorkshopRepository,
            IAsyncRepository<Category> categoryRepository,
            IMapper mapper
            )
        {
            _fileService = fileService;
            _trainingWorkshopRepository = trainingWorkshopRepository;
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }

        public async Task<BaseResponse<int>> Handle(CreateTrainingWorkshopsCommand request, CancellationToken cancellationToken)
        {
            Category? category = await _categoryRepository.GetByIdAsync(request.CategoryId);

            if (category == null)
                return new BaseResponse<int>("Category Not Found",false,404);

            TrainingWorkshop workshop = _mapper.Map<TrainingWorkshop>(request);
            string ThumbnailPath = await _fileService.SaveFileAsync(request.Thumbnail, 0);
            workshop.Thumbnail = ThumbnailPath;

            var data = await _trainingWorkshopRepository.AddAsync(workshop);

            return new BaseResponse<int>("", true, 200, data.Id);
        }
    }
}
