using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.ProvidedForm.Command.CreateProvidedForm
{
    public class CreateProvidedFormCommandHandler 
        : IRequestHandler<CreateProvidedFormCommand , Unit>
    {
        private readonly IAsyncRepository<Domain.Entities.ProvidedFormModel.ProvidedForm> _Providedrepository;
        private readonly IMapper _mapper;

        public CreateProvidedFormCommandHandler(IAsyncRepository<Domain.Entities.ProvidedFormModel.ProvidedForm> providedrepository, IMapper mapper)
        {
            _Providedrepository = providedrepository;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(CreateProvidedFormCommand request, CancellationToken cancellationToken)
        {
            var form =  _mapper.Map<Domain.Entities.ProvidedFormModel.ProvidedForm>(request);

            await _Providedrepository.AddAsync(form);

            return Unit.Value;
        }
    }
}
