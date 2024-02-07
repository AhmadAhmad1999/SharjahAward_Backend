using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharijhaAward.Domain.Entities.EventModel;
using AutoMapper;
using SharijhaAward.Domain.Entities.CategoryModel;
using System.Security.Cryptography;
using static Org.BouncyCastle.Asn1.Cmp.Challenge;

namespace SharijhaAward.Application.Features.Event.Commands.CreateEvent
{
    public class CreateEventCommandHandler : IRequestHandler<CreateEventCommand, CreateEventCommandResponse>
    {
        private readonly IAsyncRepository<Domain.Entities.EventModel.Event> _EventRepository;
        private readonly IMapper _Mapper;
        public CreateEventCommandHandler(IAsyncRepository<Domain.Entities.EventModel.Event> EventRepository, IMapper Mapper)
        {
            _EventRepository = EventRepository;
            _Mapper = Mapper;
        }
        public async Task<CreateEventCommandResponse> Handle(CreateEventCommand Request, CancellationToken cancellationToken)
        {
            CreateEventCommandResponse CreateEventCommandResponse = new CreateEventCommandResponse();

            var validator = new CreateEventCommandValidator();
            var validationResult = await validator.ValidateAsync(Request, cancellationToken);

            if (validationResult.Errors.Count > 0)
            {
                CreateEventCommandResponse.Success = false;
                CreateEventCommandResponse.ValidationErrors = new List<string>();
                foreach (var error in validationResult.Errors)
                {
                    CreateEventCommandResponse.ValidationErrors.Add(error.ErrorMessage);
                }
            }
            if (CreateEventCommandResponse.Success)
            {
                Domain.Entities.EventModel.Event NewEvent =
                    _Mapper.Map<Domain.Entities.EventModel.Event>(Request);

                Random Random = new Random();
                IEnumerable<int> ListOfUniqueIntegerId = _EventRepository.ListAllAsync()
                    .Result.Select(x => x.UniqueIntegerId);

                int UniqueIntegerId;
                do
                {
                    UniqueIntegerId = Random.Next();
                } while (ListOfUniqueIntegerId.Contains(UniqueIntegerId));

                NewEvent.UniqueIntegerId = UniqueIntegerId;

                await _EventRepository.AddAsync(NewEvent);
                CreateEventCommandResponse.CreateEventDto = _Mapper.Map<CreateEventDto>(NewEvent);
            }
            return CreateEventCommandResponse;
        }
    }
}
