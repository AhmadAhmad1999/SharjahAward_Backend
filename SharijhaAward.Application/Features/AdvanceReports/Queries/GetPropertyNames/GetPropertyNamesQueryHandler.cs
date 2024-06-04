﻿using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.ArbitratorModel;
using SharijhaAward.Domain.Entities.CategoryModel;
using SharijhaAward.Domain.Entities.CoordinatorModel;
using SharijhaAward.Domain.Entities.CycleModel;
using SharijhaAward.Domain.Entities.IdentityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.AdvanceReports.Queries.GetPropertyNames
{
    public class GetPropertyNamesQueryHandler
        : IRequestHandler<GetPropertyNamesQuery, BaseResponse<List<string>>>
    {
        private readonly IAsyncRepository<Cycle> _cycleRepository;
        private readonly IAsyncRepository<Category> _categoryRepository;
        private readonly IAsyncRepository<Domain.Entities.ProvidedFormModel.ProvidedForm>_providedFormRepository;
        private readonly IAsyncRepository<Arbitrator> _arbitratorRepository;
        private readonly IAsyncRepository<Coordinator> _coordinatorRepository;
        private readonly IAsyncRepository<Domain.Entities.IdentityModels.User> _userRepository;

        public GetPropertyNamesQueryHandler(IAsyncRepository<Cycle> cycleRepository, IAsyncRepository<Category> categoryRepository, IAsyncRepository<Domain.Entities.ProvidedFormModel.ProvidedForm> providedFormRepository, IAsyncRepository<Arbitrator> arbitratorRepository, IAsyncRepository<Coordinator> coordinatorRepository, IAsyncRepository<Domain.Entities.IdentityModels.User> userRepository)
        {
            _cycleRepository = cycleRepository;
            _categoryRepository = categoryRepository;
            _providedFormRepository = providedFormRepository;
            _arbitratorRepository = arbitratorRepository;
            _coordinatorRepository = coordinatorRepository;
            _userRepository = userRepository;
        }

        public async Task<BaseResponse<List<string>>> Handle(GetPropertyNamesQuery request, CancellationToken cancellationToken)
        {
            var cyclePropertyNames = await _cycleRepository.GetPropertyNames();

            return new BaseResponse<List<string>>("", true, 200, cyclePropertyNames);
        }
    }
}
