using FirebaseAdmin.Messaging;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.Settings.Commands.ApplySeeder
{
    public class ApplySeederQueryHandler : IRequestHandler<ApplySeederQuery, BaseResponse<object>>
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly ISeedDatabase _seedDatabase;

        public ApplySeederQueryHandler(IServiceProvider serviceProvider, ISeedDatabase seedDatabase)
        {
            _serviceProvider = serviceProvider;
            _seedDatabase = seedDatabase;
        }
        public async Task<BaseResponse<object>> Handle(ApplySeederQuery request, CancellationToken cancellationToken)
        {
            _seedDatabase.Initialize(_serviceProvider);

            return new BaseResponse<object>("", true, 200);
        }
    }
}
