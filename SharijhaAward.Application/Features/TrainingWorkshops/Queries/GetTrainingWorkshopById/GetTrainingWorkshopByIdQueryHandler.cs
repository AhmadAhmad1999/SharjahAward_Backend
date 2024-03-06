using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Domain.Entities.TrainingWorkshopModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.TrainingWorkshops.Queries.GetTrainingWorkshopById
{
    public class GetTrainingWorkshopByIdQueryHandler 
        : IRequestHandler<GetTrainingWorkshopByIdQuery, TrainingWorkshopDto>
    {
        private readonly IAsyncRepository<TrainingWorkshop> _trainingWorkshopRepository;
        private readonly IMapper _mapper;

        public GetTrainingWorkshopByIdQueryHandler(IAsyncRepository<TrainingWorkshop> trainingWorkshopRepository, IMapper mapper)
        {
            _trainingWorkshopRepository = trainingWorkshopRepository;
            _mapper = mapper;
        }

        public async Task<TrainingWorkshopDto> Handle(GetTrainingWorkshopByIdQuery request, CancellationToken cancellationToken)
        {
            TrainingWorkshop trainingWorkshop = await _trainingWorkshopRepository.GetByIdAsync(request.Id);
            if (trainingWorkshop == null)
            {
                throw new OpenQA.Selenium.NotFoundException("Training Workshope Not Found");
            }
            TrainingWorkshopDto workshopDto = new()
            {
                Id = trainingWorkshop.Id,
                ArabicTitle = trainingWorkshop.ArabicTitle,
                EnglishTitle = trainingWorkshop.EnglishTitle,
               
                Thumbnail = trainingWorkshop.Thumbnail,
                Title = request.lang == "ar" ? trainingWorkshop.ArabicTitle : trainingWorkshop.EnglishTitle,

            };

            return _mapper.Map<TrainingWorkshopDto>(workshopDto);
        }
    }
}
