using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;

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
            await _seedDatabase.Initialize(_serviceProvider);

            return new BaseResponse<object>("", true, 200);
        }
    }
}
