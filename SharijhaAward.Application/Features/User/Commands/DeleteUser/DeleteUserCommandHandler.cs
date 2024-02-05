using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.User.Commands.DeleteUser
{
    public class DeleteUserCommandHandler : IRequestHandler<DeleteUserCommand , Unit>
    {
        private readonly IAsyncRepository<Domain.Entities.IdentityModels.User> _userRepository;
        private readonly IMapper _mapper;

        public DeleteUserCommandHandler(IMapper mapper, IAsyncRepository<Domain.Entities.IdentityModels.User> userRepository)
        {
            _mapper = mapper;
            _userRepository = userRepository;
        }

        public async Task<Unit> Handle(DeleteUserCommand request, CancellationToken cancellationToken)
        {
            var userToDelete = await _userRepository.GetByIdAsync(request.Id);
            if (userToDelete == null)
            {
                throw new OpenQA.Selenium.NotFoundException("User Not Found");
            }
            await _userRepository .DeleteAsync(userToDelete);
            return Unit.Value;
        }
    }
}
