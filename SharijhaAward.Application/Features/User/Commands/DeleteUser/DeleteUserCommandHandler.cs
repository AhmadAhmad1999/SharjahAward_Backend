using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.User.Commands.DeleteUser
{
    public class DeleteUserCommandHandler : IRequestHandler<DeleteUserCommand , BaseResponse<object>>
    {
        private readonly IAsyncRepository<Domain.Entities.IdentityModels.User> _userRepository;
        private readonly IMapper _mapper;

        public  DeleteUserCommandHandler(IMapper mapper, IAsyncRepository<Domain.Entities.IdentityModels.User> userRepository)
        {
            _mapper = mapper;
            _userRepository = userRepository;
        }

        public async Task<BaseResponse<object>> Handle(DeleteUserCommand request, CancellationToken cancellationToken)
        {
            string msg = request.lang == "en"
                ? "User has been Deleted"
                : "تم حذف المستخدم";

            var userToDelete = await _userRepository.GetByIdAsync(request.Id);
            if (userToDelete == null)
            {
                msg = request.lang == "en"
                ? "User Not found"
                : "المستخدم غير موجود";

                return new BaseResponse<object>(msg, false, 404);
            }
            await _userRepository .DeleteAsync(userToDelete!);
            return new BaseResponse<object>(msg, true, 200);
        }
    }
}
