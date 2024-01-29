using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.Event.Commands.DeleteEvent
{
    public class DeleteEventCommandHandler : IRequestHandler<DeleteEventCommand, Unit>
    {
        private readonly IAsyncRepository<Domain.Entities.EventModel.Event> _eventRepository;
        private readonly IMapper _mapper;

        public DeleteEventCommandHandler(IAsyncRepository<Domain.Entities.EventModel.Event> eventRepository, IMapper mapper)
        {
            _eventRepository = eventRepository;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(DeleteEventCommand request, CancellationToken cancellationToken)
        {
            var EventToDelete = await _eventRepository.GetByIdAsync(request.Id);
            if (EventToDelete == null)
            {
                throw new OpenQA.Selenium.NotFoundException(nameof(Domain.Entities.EventModel.Event));
            }

            await _eventRepository.DeleteAsync(EventToDelete);

            return Unit.Value;
            
        }
    }
}
