using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.DynamicAttributeModel;
namespace SharijhaAward.Application.Features.DynamicAttributeFeatures.Queries.GetAllAttributeOperations
{
    public class GetAllAttributeOperationsHandler : IRequestHandler<GetAllAttributeOperationsQuery,
        BaseResponse<List<GetAllAttributeOperationsListVM>>>
    {
        private readonly IAsyncRepository<AttributeOperation> _AttributeOperationRepository;
        private readonly IMapper _Mapper;

        public GetAllAttributeOperationsHandler(IAsyncRepository<AttributeOperation> AttributeOperationRepository,
            IMapper Mapper)
        {
            _AttributeOperationRepository = AttributeOperationRepository;
            _Mapper = Mapper;
        }
        public async Task<BaseResponse<List<GetAllAttributeOperationsListVM>>> Handle(GetAllAttributeOperationsQuery Request,
            CancellationToken cancellationToken)
        {
            string Language = !string.IsNullOrEmpty(Request.lang)
                ? Request.lang.ToLower() : "ar";

            List<GetAllAttributeOperationsListVM> AttributeOperations = _Mapper.Map<List<GetAllAttributeOperationsListVM>>(
                await _AttributeOperationRepository.ListAllAsync());

            string ResponseMessage = string.Empty;

            if (AttributeOperations.Count <= 0)
            {
                ResponseMessage = Request.lang == "en"
                    ? "There is no field's types"
                    : "لا يوجد أنواع للحقول";

                return new BaseResponse<List<GetAllAttributeOperationsListVM>>(ResponseMessage, true, 204);
            }

            int TotalCount = await _AttributeOperationRepository.GetCountAsync(null);

            Pagination PaginationParameter = new Pagination(Request.page,
                Request.pageSize, TotalCount);

            return new BaseResponse<List<GetAllAttributeOperationsListVM>>(ResponseMessage, true, 200, AttributeOperations, PaginationParameter);
        }
    }
}
