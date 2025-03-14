﻿using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.CycleModel;
using SharijhaAward.Domain.Entities.IdentityModels;

namespace SharijhaAward.Application.Features.Cycles.Queries.GetActiveCycle
{
    public class GetActiveCycleHandler : IRequestHandler<GetActiveCycleQuery, BaseResponse<bool>>
    {
        private readonly IAsyncRepository<Cycle> _CycleRepository;
        private readonly IAsyncRepository<UserToken> _UserTokenRepository;
        private readonly IMapper _Mapper;
        public GetActiveCycleHandler(IAsyncRepository<Cycle> CycleRepository, IAsyncRepository<UserToken> UserTokenRepository,
            IMapper Mapper)
        {
            _CycleRepository = CycleRepository;
            _UserTokenRepository = UserTokenRepository;
            _Mapper = Mapper;
        }

        public async Task<BaseResponse<bool>> Handle(GetActiveCycleQuery Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            Cycle? CycleEntity = await _CycleRepository
                .FirstOrDefaultAsync(x => x.Status == Domain.Constants.Common.Status.Active);

            if (CycleEntity is not null)
            {
                if (CycleEntity.RegistrationPortalOpeningDate <= DateTime.UtcNow &&
                    CycleEntity.RegistrationPortalClosingDate > DateTime.UtcNow)
                    return new BaseResponse<bool>(ResponseMessage, true, 200, true);

                return new BaseResponse<bool>(ResponseMessage, true, 200, false);
            }

            var UserTokenEntitiesToDelete = await _UserTokenRepository
                .ListAllAsync();

            await _UserTokenRepository.DeleteListAsync(UserTokenEntitiesToDelete);

            return new BaseResponse<bool>(ResponseMessage, true, 200, false);
        }
    }
}
