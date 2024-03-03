using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.DynamicAttributeModel;
namespace SharijhaAward.Application.Features.DynamicAttributeFeatures.Queries.GetAllDataTypes
{
    public class GetAllDataTypesHandler : IRequestHandler<GetAllDataTypesQuery,
        BaseResponse<List<GetAllDataTypesListVM>>>
    {
        private readonly IAsyncRepository<AttributeDataType> _AttributeDataTypeRepository;
        private readonly IMapper _Mapper;

        public GetAllDataTypesHandler(IAsyncRepository<AttributeDataType> AttributeDataTypeRepository,
            IMapper Mapper)
        {
            _AttributeDataTypeRepository = AttributeDataTypeRepository;
            _Mapper = Mapper;
        }
        public async Task<BaseResponse<List<GetAllDataTypesListVM>>> Handle(GetAllDataTypesQuery Request, CancellationToken cancellationToken)
        {
            string Language = !string.IsNullOrEmpty(Request.lang)
                ? Request.lang.ToLower() : "ar";

            List<GetAllDataTypesListVM> DataTypes = _Mapper.Map<List<GetAllDataTypesListVM>>(await _AttributeDataTypeRepository
                .ListAllAsync());

            string ResponseMessage = string.Empty;

            if (DataTypes.Count <= 0)
            {
                ResponseMessage = Request.lang == "en"
                    ? "There is no field's types"
                    : "لا يوجد أنواع للحقول";

                return new BaseResponse<List<GetAllDataTypesListVM>>(ResponseMessage, true, 204);
            }

            int TotalCount = await _AttributeDataTypeRepository.GetCountAsync(null);

            Pagination PaginationParameter = new Pagination(Request.page,
                Request.pageSize, TotalCount);

            return new BaseResponse<List<GetAllDataTypesListVM>>(ResponseMessage, true, 200, DataTypes, PaginationParameter);
        }
    }
}
