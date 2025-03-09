using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Features.CommitteeFeatures.Queries.GetAllChairmanArbitrators;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.ArbitratorModel;

namespace SharijhaAward.Application.Features.CommitteeFeatures.Queries.GetAllOfficerArbitrators
{
    public class GetAllOfficerArbitratorsHandler 
        : IRequestHandler<GetAllOfficerArbitratorsQuery, BaseResponse<List<GetAllChairmanArbitratorsListVM>>>
    {
        private readonly IAsyncRepository<Arbitrator> _ArbitratorRepository;
        public GetAllOfficerArbitratorsHandler(IAsyncRepository<Arbitrator> ArbitratorRepository)
        {
            _ArbitratorRepository = ArbitratorRepository;
        }

        public async Task<BaseResponse<List<GetAllChairmanArbitratorsListVM>>>
            Handle(GetAllOfficerArbitratorsQuery Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            List<GetAllChairmanArbitratorsListVM> Arbitrators = await _ArbitratorRepository
                .Where(x => x.isSubcommitteeOfficer)
                .OrderByDescending(x => x.CreatedAt)
                .Select(x => new GetAllChairmanArbitratorsListVM()
                {
                    Id = x.Id,
                    Name = Request.lang == "en"
                        ? x.EnglishName
                        : x.ArabicName
                }).ToListAsync();

            return new BaseResponse<List<GetAllChairmanArbitratorsListVM>>(ResponseMessage, true, 200, Arbitrators);
        }
    }
}
