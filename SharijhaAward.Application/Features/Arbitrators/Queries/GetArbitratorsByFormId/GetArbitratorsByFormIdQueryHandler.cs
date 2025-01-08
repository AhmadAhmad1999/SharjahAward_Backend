using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Features.Arbitrators.Queries.GetAllArbitrators;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.ArbitrationModel;

namespace SharijhaAward.Application.Features.Arbitrators.Queries.GetArbitratorsByFormId
{
    public class GetArbitratorsByFormIdQueryHandler
        : IRequestHandler<GetArbitratorsByFormIdQuery, BaseResponse<List<ArbitratorsListVM>>>
    {
        private readonly IAsyncRepository<Arbitration> _ArbitrationRepository;
        private readonly IAsyncRepository<Domain.Entities.ProvidedFormModel.ProvidedForm> _ProvidedFormRepository;
        private readonly IMapper _Mapper;

        public GetArbitratorsByFormIdQueryHandler(IAsyncRepository<Arbitration> _ArbitrationRepository,
            IAsyncRepository<Domain.Entities.ProvidedFormModel.ProvidedForm> _ProvidedFormRepository,
            IMapper _Mapper)
        {
            this._ArbitrationRepository = _ArbitrationRepository;
            this._ProvidedFormRepository = _ProvidedFormRepository;
            this._Mapper = _Mapper;
        }

        public async Task<BaseResponse<List<ArbitratorsListVM>>> Handle(GetArbitratorsByFormIdQuery Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            Domain.Entities.ProvidedFormModel.ProvidedForm? ProvidedFormEntity = await _ProvidedFormRepository
                .FirstOrDefaultAsync(x => x.Id == Request.formId);

            if (ProvidedFormEntity is null)
            {
                return new BaseResponse<List<ArbitratorsListVM>>("Form Not Found", false, 404);
            }

            List<ArbitratorsListVM> ArbitratorsListVM = _Mapper.Map<List<ArbitratorsListVM>>(await _ArbitrationRepository
                .Where(x => x.ProvidedFormId == ProvidedFormEntity.Id)
                .Skip((Request.page - 1) * Request.perPage)
                .Take(Request.perPage)
                .Select(x => x.Arbitrator!)
                .ToListAsync());

            int TotalCount = await _ArbitrationRepository
                .GetCountAsync(x => x.ProvidedFormId == ProvidedFormEntity.Id);

            Pagination PaginationParameter = new Pagination(Request.page,
                Request.perPage, TotalCount);

            return new BaseResponse<List<ArbitratorsListVM>>(ResponseMessage, true, 200, ArbitratorsListVM, PaginationParameter);
        }
    }
}
