using MediatR;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.ProvidedForm.Queries.AcceptOnForm
{
    public class AcceptOnFormQueryHandler
        : IRequestHandler<AcceptOnFormQuery, BaseResponse<object>>
    {
        private readonly IAsyncRepository<Domain.Entities.ProvidedFormModel.ProvidedForm> _formRepository;
        private readonly IUserRepository _userRepository;
        private readonly IJwtProvider _jwtProvider;
        
        public AcceptOnFormQueryHandler(IAsyncRepository<Domain.Entities.ProvidedFormModel.ProvidedForm> formRepository, IUserRepository userRepository, IJwtProvider jwtProvider)
        {
            _formRepository = formRepository;
            _userRepository = userRepository;
            _jwtProvider = jwtProvider;
        }

        public async Task<BaseResponse<object>> Handle(AcceptOnFormQuery request, CancellationToken cancellationToken)
        {
            var AdminId = _jwtProvider.GetUserIdFromToken(request.token!);
            
            var Admin = await _userRepository.GetByIdAsync(int.Parse(AdminId));

            if(Admin == null)
            {
                return new BaseResponse<object>("Un Auth", false, 401);
            }

            var form = await _formRepository.GetByIdAsync(request.formId);
            
            if(form == null)
            {
                return new BaseResponse<object>("Form Not Found", false, 404);
            }

            form.IsAccepted = request.IsAccepted;

            await _formRepository.UpdateAsync(form);

            return new BaseResponse<object>("", true, 200);
        }
    }
}
