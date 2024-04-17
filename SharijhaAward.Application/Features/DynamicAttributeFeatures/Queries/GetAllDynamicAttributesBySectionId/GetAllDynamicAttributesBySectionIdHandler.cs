using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.DynamicAttributeModel;
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
        public async Task<BaseResponse<List<DynamicAttributeListVM>>> Handle(GetAllDynamicAttributesBySectionIdQuery Request, 
            CancellationToken cancellationToken)
        {
            string Language = !string.IsNullOrEmpty(Request.lang)
                ? Request.lang.ToLower() : "ar";

            List<DynamicAttributeListVM> DynamicAttributes = new List<DynamicAttributeListVM>();

            if (Request.page != 0 && Request.pageSize != -1)
                DynamicAttributes = await _DynamicAttributeRepository
                    .Where(x => x.DynamicAttributeSectionId == Request.SectionId)
                    .OrderByDescending(x => x.CreatedAt)
                    .Skip((Request.page - 1) * Request.pageSize)
                    .Take(Request.pageSize)
                    .Include(x => x.AttributeDataType!)
                    .Select(x => new DynamicAttributeListVM()
                    {
                        Id = x.Id,
                        AttributeDataTypeName = x.AttributeDataType!.Name,
                        Label = Language == "ar"
                            ? x.ArabicLabel
                            : x.EnglishLabel,
                        PlaceHolder = Language == "ar"
                            ? x.ArabicPlaceHolder
                            : x.EnglishPlaceHolder,
                        Status = x.Status.ToString()
                    }).ToListAsync();

            else
                DynamicAttributes = await _DynamicAttributeRepository
                    .Where(x => x.DynamicAttributeSectionId == Request.SectionId)
                    .OrderByDescending(x => x.CreatedAt)
                    .Include(x => x.AttributeDataType!)
                    .Select(x => new DynamicAttributeListVM()
                    {
                        Id = x.Id,
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

            int TotalCount = await _DynamicAttributeRepository
                .GetCountAsync(x => x.DynamicAttributeSectionId == Request.SectionId);

            Pagination PaginationParameter = new Pagination(Request.page,
                Request.pageSize, TotalCount);

            return new BaseResponse<List<DynamicAttributeListVM>>(ResponseMessage, true, 200, DynamicAttributes, PaginationParameter);
        }
    }
}
