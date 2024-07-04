using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
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

            List<GetAllDataTypesListVM> DataTypes = await _AttributeDataTypeRepository
                .OrderByDescending(x => x.CreatedAt, 0, -1)
                .Select(x => new GetAllDataTypesListVM()
                {
                    Id = x.Id,
                    Name = Language == "en"
                        ? x.Name
                        : x.ArabicName
                }).ToListAsync();

            string ResponseMessage = string.Empty;

            if (DataTypes.Count <= 0)
            {
                ResponseMessage = Request.lang == "en"
                    ? "There is no field's types"
                    : "لا يوجد أنواع للحقول";

                return new BaseResponse<List<GetAllDataTypesListVM>>(ResponseMessage, true, 204);
            }

            return new BaseResponse<List<GetAllDataTypesListVM>>(ResponseMessage, true, 200, DataTypes);
        }
    }
}
