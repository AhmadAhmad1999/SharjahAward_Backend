using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Features.Event.Commands.UpdateEvent;
using SharijhaAward.Domain.Entities.IdentityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.User.Commands.UpdateUser
{
    public class UpdateUserCommandHandler : IRequestHandler<UpdateUserCommand, Unit>
    {
        private readonly IAsyncRepository<Domain.Entities.IdentityModels.User> _userRepository;
        private readonly IMapper _mapper;

        public UpdateUserCommandHandler(IMapper mapper , IAsyncRepository<Domain.Entities.IdentityModels.User> userRepository)
        {
            _mapper = mapper;
            _userRepository = userRepository;
        }
        public async Task<Unit> Handle(UpdateUserCommand request, CancellationToken cancellationToken)
        {
            var userToUpdate = await _userRepository.GetByIdAsync(request.Id);
            if (userToUpdate == null)
            {
                throw new OpenQA.Selenium.NotFoundException("User Not Found");
            }
            _mapper.Map(request, userToUpdate, typeof(UpdateUserCommand), typeof(Domain.Entities.IdentityModels.User));
            await _userRepository.UpdateAsync(userToUpdate);
            return Unit.Value;
        }
    }
}
