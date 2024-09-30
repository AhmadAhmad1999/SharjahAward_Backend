using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Features.Event.Commands.UpdateEvent;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.IdentityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.User.Commands.UpdateUser
{
    public class UpdateUserCommandHandler : IRequestHandler<UpdateUserCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<Domain.Entities.IdentityModels.User> _userRepository;
        private readonly IMapper _mapper;

        public UpdateUserCommandHandler(IMapper mapper , IAsyncRepository<Domain.Entities.IdentityModels.User> userRepository)
        {
            _mapper = mapper;
            _userRepository = userRepository;
        }
        public async Task<BaseResponse<object>> Handle(UpdateUserCommand request, CancellationToken cancellationToken)
        {
            string msg = request.lang == "en"
                ? "User has been Updated"
                : "تم تعديل المستخدم";

            var userToUpdate = await _userRepository.GetByIdAsync(request.Id);
            if (userToUpdate == null)
            {
                msg = request.lang == "en"
                    ? "User Not found"
                    : "المستخدم غير موجود";

                return new BaseResponse<object>(msg, false, 404);
            }

            var CheckIfEmailIsAlreadyUsed = await _userRepository
                .FirstOrDefaultAsync(x => x.Email.ToLower() == request.Email.ToLower() &&
                    x.Id != request.Id);

            if (CheckIfEmailIsAlreadyUsed is not null)
            {
                msg = request.lang == "en"
                    ? "This email is already used"
                    : "البريد الإلكتروني مستخدم بالفعل";

                return new BaseResponse<object>(msg, false, 400);
            }

            _mapper.Map(request, userToUpdate, typeof(UpdateUserCommand), typeof(Domain.Entities.IdentityModels.User));
            
            await _userRepository.UpdateAsync(userToUpdate);

            return new BaseResponse<object>(msg, true, 200);
        }
    }
}
