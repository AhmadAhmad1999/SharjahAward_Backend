using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.ArbitrationModel;
using SharijhaAward.Domain.Entities.ArbitratorModel;
using SharijhaAward.Domain.Entities.DynamicAttributeModel;
using SharijhaAward.Domain.Entities.FinalArbitrationModel;

namespace SharijhaAward.Application.Features.FinalArbitrationFeatures.Queries.GetAllFinalArbitration
{
    public class GetAllFinalArbitrationHandler 
        : IRequestHandler<GetAllFinalArbitrationQuery, BaseResponse<List<GetAllFinalArbitrationListVM>>>
    {
        private readonly IAsyncRepository<Arbitrator> _ArbitratorRepository;
        private readonly IAsyncRepository<Arbitration> _ArbitrationRepository;
        private readonly IAsyncRepository<DynamicAttributeValue> _DynamicAttributeValueRepository;
        private readonly IAsyncRepository<FinalArbitration> _FinalArbitrationRepository;
        private readonly IJwtProvider _JWTProvider;

        public GetAllFinalArbitrationHandler(IAsyncRepository<Arbitrator> ArbitratorRepository,
            IAsyncRepository<Arbitration> ArbitrationRepository,
            IAsyncRepository<DynamicAttributeValue> DynamicAttributeValueRepository,
            IAsyncRepository<FinalArbitration> FinalArbitrationRepository,
            IJwtProvider JWTProvider)
        {
            _ArbitratorRepository = ArbitratorRepository;
            _ArbitrationRepository = ArbitrationRepository;
            _DynamicAttributeValueRepository = DynamicAttributeValueRepository;
            _FinalArbitrationRepository = FinalArbitrationRepository;
            _JWTProvider = JWTProvider;
        }

        public async Task<BaseResponse<List<GetAllFinalArbitrationListVM>>> Handle(GetAllFinalArbitrationQuery Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            int UserId = int.Parse(_JWTProvider.GetUserIdFromToken(Request.Token!));

            if (Request.Type == ArbitrationType.NotBeenArbitrated)
            {

            }
            else
            {

            }

            throw new NotImplementedException();
        }
    }
}
