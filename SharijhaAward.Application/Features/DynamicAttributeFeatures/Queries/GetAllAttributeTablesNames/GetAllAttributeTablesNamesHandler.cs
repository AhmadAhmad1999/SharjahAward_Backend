using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.DynamicAttributeModel;
namespace SharijhaAward.Application.Features.DynamicAttributeFeatures.Queries.GetAllAttributeTablesNames
{
    public class GetAllAttributeTablesNamesHandler : IRequestHandler<GetAllAttributeTablesNamesQuery,
        BaseResponse<List<GetAllAttributeTablesNamesListVM>>>
    {
        private readonly IAsyncRepository<AttributeTableName> _AttributeTableNameRepository;
        private readonly IMapper _Mapper;

        public GetAllAttributeTablesNamesHandler(IAsyncRepository<AttributeTableName> AttributeTableNameRepository,
            IMapper Mapper)
        {
            _AttributeTableNameRepository = AttributeTableNameRepository;
            _Mapper = Mapper;
        }
        public async Task<BaseResponse<List<GetAllAttributeTablesNamesListVM>>> Handle(GetAllAttributeTablesNamesQuery Request,
            CancellationToken cancellationToken)
        {
            string Language = !string.IsNullOrEmpty(Request.lang)
                ? Request.lang.ToLower() : "ar";

            List<GetAllAttributeTablesNamesListVM> AttributeTablesNames = _Mapper.Map<List<GetAllAttributeTablesNamesListVM>>(
                await _AttributeTableNameRepository.OrderByDescending(x => x.CreatedAt, 0, -1).ToListAsync());

            string ResponseMessage = string.Empty;

            if (AttributeTablesNames.Count <= 0)
            {
                ResponseMessage = Request.lang == "en"
                    ? "There is no field's types"
                    : "لا يوجد أنواع للحقول";

                return new BaseResponse<List<GetAllAttributeTablesNamesListVM>>(ResponseMessage, true, 204);
            }

            return new BaseResponse<List<GetAllAttributeTablesNamesListVM>>(ResponseMessage, true, 200, AttributeTablesNames);
        }
    }
}
