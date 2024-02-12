using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Domain.Entities.TrainingWorkshopModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.TrainingWorkshops.Command.DeleteTrainingWorkshop
{
    public class DeleteTrainingWorkshopCommandHandler 
        :IRequestHandler<DeleteTrainingWorkshopCommand, Unit>
    {
        private readonly IAsyncRepository<TrainingWorkshop> _trainingWorkshopRepository;
        
        public DeleteTrainingWorkshopCommandHandler(
            IAsyncRepository<TrainingWorkshop> trainingWorkshopRepository
            )
        {
            _trainingWorkshopRepository = trainingWorkshopRepository;
        }

        public async Task<Unit> Handle(DeleteTrainingWorkshopCommand request, CancellationToken cancellationToken)
        {
            var workToDelete = await _trainingWorkshopRepository.GetByIdAsync(request.Id );
            if ( workToDelete == null )
            {
                throw new OpenQA.Selenium.NotFoundException("Training Workshop Not Found");
            }
            await _trainingWorkshopRepository.DeleteAsync(workToDelete);

            return Unit.Value;
        }
    }
}
