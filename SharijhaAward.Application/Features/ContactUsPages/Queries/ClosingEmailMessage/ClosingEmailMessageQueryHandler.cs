using MediatR;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.ContactUsModels;
using SharijhaAward.Domain.Entities.IdentityModels;
using SharijhaAward.Domain.Entities.RoleMessageTypeModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.ContactUsPages.Queries.ClosingEmailMessage
{
    public class ClosingEmailMessageQueryHandler
        : IRequestHandler<ClosingEmailMessageQuery, BaseResponse<object>>
    {
        private readonly IAsyncRepository<EmailMessage> _emailMessageRepository;
        private readonly IUserRepository _userRepository;
        private readonly IAsyncRepository<UserRole> _userRoleRepository;
        private readonly IAsyncRepository<RoleMessageType> _roleMessageTypeRepository;
        private readonly IJwtProvider _jwtProvider;

        public ClosingEmailMessageQueryHandler(IJwtProvider jwtProvider, IAsyncRepository<EmailMessage> emailMessageRepository, IUserRepository userRepository, IAsyncRepository<UserRole> userRoleRepository, IAsyncRepository<RoleMessageType> roleMessageTypeRepository)
        {
            _emailMessageRepository = emailMessageRepository;
            _jwtProvider = jwtProvider;
            _userRepository = userRepository;
            _userRoleRepository = userRoleRepository;
            _roleMessageTypeRepository = roleMessageTypeRepository;
        }

        public async Task<BaseResponse<object>> Handle(ClosingEmailMessageQuery request, CancellationToken cancellationToken)
        {
            var UserId = _jwtProvider.GetUserIdFromToken(request.token);
           
            if(UserId == null)
            {
                return new BaseResponse<object>("Un Auth", false, 401);
            }

            var Role = _userRoleRepository.Where(r => r.UserId == int.Parse(UserId)).ToList();
           
            
            var message = await _emailMessageRepository.GetByIdAsync(request.Id); 
            
            if(message == null)
            {
                return new BaseResponse<object>("", false, 404);
            }
            
            message.Status = Domain.Constants.ContactUsConstants.MessageStatus.Close;

            await _emailMessageRepository.UpdateAsync(message);

            return new BaseResponse<object>("", true, 200);
        }
    }
}
