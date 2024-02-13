using AutoMapper;
using FluentValidation;
using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.Event.Commands.UpdateEvent
{
    public class UpdateEventCommandHandler : IRequestHandler<UpdateEventCommand, Unit>
    {
        private readonly IAsyncRepository<Domain.Entities.EventModel.Event> _eventRepository;
        private readonly IMapper _mapper;

        public UpdateEventCommandHandler(IAsyncRepository<Domain.Entities.EventModel.Event> eventRepository, IMapper mapper)
        {
            _eventRepository = eventRepository;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(UpdateEventCommand request, CancellationToken cancellationToken)
        {
            var eventForUpdate = await _eventRepository.GetByIdAsync(request.Id);
            if (eventForUpdate == null)
            {
                throw new OpenQA.Selenium.NotFoundException("Event Not found");
            }
            else
            {
                var validator = new UpdateEventCommandValidator();
                var validationResult = await validator.ValidateAsync(request);

                if (validationResult.Errors.Count > 0)
                {
                    throw new ValidationException(validationResult.Errors);
                }
                else
                {
                    _mapper.Map(request, eventForUpdate, typeof(UpdateEventCommand), typeof(Domain.Entities.EventModel.Event));

                    await _eventRepository.UpdateAsync(eventForUpdate);
                }
                return Unit.Value;
            }
        }
    }
}
