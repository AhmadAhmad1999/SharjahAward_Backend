using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.ArbitratorModel;

namespace SharijhaAward.Application.Features.CommitteeFeatures.Queries.GetAllChairmanArbitrators
{
    public class GetAllChairmanArbitratorsHandler 
        : IRequestHandler<GetAllChairmanArbitratorsQuery, BaseResponse<List<GetAllChairmanArbitratorsListVM>>>
    {
        private readonly IAsyncRepository<Arbitrator> _ArbitratorRepository;
        public GetAllChairmanArbitratorsHandler(IAsyncRepository<Arbitrator> ArbitratorRepository)
        {
            _ArbitratorRepository = ArbitratorRepository;
        }

        public async Task<BaseResponse<List<GetAllChairmanArbitratorsListVM>>> 
            Handle(GetAllChairmanArbitratorsQuery Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            List<GetAllChairmanArbitratorsListVM> Arbitrators = await _ArbitratorRepository
                .Where(x => x.isChairman)
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
