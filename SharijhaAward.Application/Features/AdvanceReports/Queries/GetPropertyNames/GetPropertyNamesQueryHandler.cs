using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.ArbitratorModel;
using SharijhaAward.Domain.Entities.CategoryModel;
using SharijhaAward.Domain.Entities.CoordinatorModel;
using SharijhaAward.Domain.Entities.CycleModel;

namespace SharijhaAward.Application.Features.AdvanceReports.Queries.GetPropertyNames
{
    public class GetPropertyNamesQueryHandler
        : IRequestHandler<GetPropertyNamesQuery, BaseResponse<CyclePropertyDto>>
    {
        private readonly IAsyncRepository<Cycle> _CycleRepository;
        private readonly IAsyncRepository<Category> _CategoryRepository;
        private readonly IAsyncRepository<Domain.Entities.ProvidedFormModel.ProvidedForm> _ProvidedFormRepository;
        private readonly IAsyncRepository<Arbitrator> _ArbitratorRepository;
        private readonly IAsyncRepository<Coordinator> _CoordinatorRepository;
        private readonly IAsyncRepository<Domain.Entities.IdentityModels.User> _UserRepository;

        public GetPropertyNamesQueryHandler(IAsyncRepository<Cycle> _CycleRepository, 
            IAsyncRepository<Category> _CategoryRepository, 
            IAsyncRepository<Domain.Entities.ProvidedFormModel.ProvidedForm> _ProvidedFormRepository, 
            IAsyncRepository<Arbitrator> _ArbitratorRepository,
            IAsyncRepository<Coordinator> _CoordinatorRepository,
            IAsyncRepository<Domain.Entities.IdentityModels.User> _UserRepository)
        {
            this._CycleRepository = _CycleRepository;
            this._CategoryRepository = _CategoryRepository;
            this._ProvidedFormRepository = _ProvidedFormRepository;
            this._ArbitratorRepository = _ArbitratorRepository;
            this._CoordinatorRepository = _CoordinatorRepository;
            this._UserRepository = _UserRepository;
        }

        public async Task<BaseResponse<CyclePropertyDto>> Handle(GetPropertyNamesQuery Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            CyclePropertyDto CyclePropertyDto = new CyclePropertyDto()
            {
                CycleProperties = await _CycleRepository.GetPropertyNames(),
                Category = new CategoryPropertyDto()
                {
                    CatgegoryProperties = await _CycleRepository.GetPropertyNames(),
                    ProvidedForms = new ProvidedFormPropertyDto()
                    {
                        ProvidedFormProperties = await _CycleRepository.GetPropertyNames()
                    }
                }
            };

            return new BaseResponse<CyclePropertyDto>(ResponseMessage, true, 200, CyclePropertyDto);
        }
    }
}
