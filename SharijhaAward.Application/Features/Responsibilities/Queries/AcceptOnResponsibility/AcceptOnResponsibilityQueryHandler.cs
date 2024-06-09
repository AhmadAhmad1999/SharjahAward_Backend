using MediatR;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities;
using SharijhaAward.Domain.Entities.ResponsibilityModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.Responsibilities.Queries.AcceptOnResponsibility
{
    public class AcceptOnResponsibilityQueryHandler
        : IRequestHandler<AcceptOnResponsibilityQuery, BaseResponse<object>>
    {
        private readonly IAsyncRepository<Responsibility> _responsibilityRepository;
        private readonly IAsyncRepository<ResponsibilityUser> _responsibilityUserRepository;
        private readonly IUserRepository _userRepository;
        private readonly IJwtProvider _jwtProvider;

        public AcceptOnResponsibilityQueryHandler(IAsyncRepository<Responsibility> responsibilityRepository, IAsyncRepository<ResponsibilityUser> responsibilityUserRepository, IUserRepository userRepository, IJwtProvider jwtProvider)
        {
            _responsibilityRepository = responsibilityRepository;
            _responsibilityUserRepository = responsibilityUserRepository;
            _userRepository = userRepository;
            _jwtProvider = jwtProvider;
        }

        public Task<BaseResponse<object>> Handle(AcceptOnResponsibilityQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
