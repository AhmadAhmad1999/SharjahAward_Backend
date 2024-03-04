using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.DynamicAttributeModel;
using static Microsoft.AspNetCore.Hosting.Internal.HostingApplication;

namespace SharijhaAward.Application.Features.DynamicAttributeFeatures.Queries.GetAllDynamicAttributesBySectionId
{
    public class GetAllDynamicAttributesBySectionIdHandler : IRequestHandler<GetAllDynamicAttributesBySectionIdQuery,
        BaseResponse<List<DynamicAttributeListVM>>>
    {
        private readonly IAsyncRepository<DynamicAttribute> _DynamicAttributeRepository;

        public GetAllDynamicAttributesBySectionIdHandler(IAsyncRepository<DynamicAttribute> DynamicAttributeRepository)
        {
            _DynamicAttributeRepository = DynamicAttributeRepository;
        }
        public async Task<BaseResponse<List<DynamicAttributeListVM>>> Handle(GetAllDynamicAttributesBySectionIdQuery Request, CancellationToken cancellationToken)
        {
            string Language = !string.IsNullOrEmpty(Request.lang)
                ? Request.lang.ToLower() : "ar";

            List<DynamicAttributeListVM> DynamicAttributes = await _DynamicAttributeRepository
                .WhereThenIncludeThenPagination(x => x.DynamicAttributeSectionId == Request.SectionId,
                    Request.page, Request.pageSize,
                    navigationProperties: x => x.AttributeDataType!)
                .Select(x => new DynamicAttributeListVM()
                {
                    Id = x.Id,
                    Key = x.Key,
                    AttributeDataTypeName = x.AttributeDataType!.Name,
                    Label = Language == "ar"
                        ? x.ArabicLabel
                        : x.EnglishLabel,
                    PlaceHolder = Language == "ar"
                        ? x.ArabicPlaceHolder
                        : x.EnglishPlaceHolder,
                    Status = x.Status.ToString()
                }).ToListAsync();

            string ResponseMessage = string.Empty;

            if (DynamicAttributes.Count <= 0)
            {
                ResponseMessage = Request.lang == "en"
                    ? "There is no fields"
                    : "لا يوجد حقول";

                return new BaseResponse<List<DynamicAttributeListVM>>(ResponseMessage, true, 204);
            }

            int TotalCount = await _DynamicAttributeRepository
                .GetCountAsync(x => x.DynamicAttributeSectionId == Request.SectionId);

            Pagination PaginationParameter = new Pagination(Request.page,
                Request.pageSize, TotalCount);

            return new BaseResponse<List<DynamicAttributeListVM>>(ResponseMessage, true, 200, DynamicAttributes, PaginationParameter);
        }
    }
}
