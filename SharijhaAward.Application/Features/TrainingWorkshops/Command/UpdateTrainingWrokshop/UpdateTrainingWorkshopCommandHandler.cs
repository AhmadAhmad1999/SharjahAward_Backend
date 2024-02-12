using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Domain.Entities.TrainingWorkshopModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.TrainingWorkshops.Command.UpdateTrainingWrokshop
{
    public class UpdateTrainingWorkshopCommandHandler 
        : IRequestHandler<UpdateTrainingWorkshopCommand, Unit>
    {
        private readonly IAsyncRepository<TrainingWorkshop> _trainingWorkshopRepository;
        private readonly IMapper _mapper;

        public UpdateTrainingWorkshopCommandHandler(IAsyncRepository<TrainingWorkshop> trainingWorkshopRepository, IMapper mapper)
        {
            _trainingWorkshopRepository = trainingWorkshopRepository;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(UpdateTrainingWorkshopCommand request, CancellationToken cancellationToken)
        {
            var worksopToUpdate = await _trainingWorkshopRepository.GetByIdAsync(request.Id);
            if(worksopToUpdate == null)
            {
                throw new OpenQA.Selenium.NotFoundException("Training Workshop Not Found");
            }
            _mapper.Map(request, worksopToUpdate, typeof(UpdateTrainingWorkshopCommand), typeof(TrainingWorkshop));
            await _trainingWorkshopRepository.UpdateAsync(worksopToUpdate);
            return Unit.Value;
        }
    }
}
