using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.AdvancedFormBuilderModel;

namespace SharijhaAward.Application.Features.AdvancedFormBuilderFeatures.Queries.GetAllAdvancedFormBuildersBySectionId
{
    public class GetAllAdvancedFormBuildersBySectionIdHandler : IRequestHandler<GetAllAdvancedFormBuildersBySectionIdQuery,
        BaseResponse<List<AdvancedFormBuilderListVM>>>
    {
        private readonly IAsyncRepository<AdvancedFormBuilder> _AdvancedFormBuilderRepository;

        public GetAllAdvancedFormBuildersBySectionIdHandler(IAsyncRepository<AdvancedFormBuilder> AdvancedFormBuilderRepository)
        {
            _AdvancedFormBuilderRepository = AdvancedFormBuilderRepository;
        }

        public async Task<BaseResponse<List<AdvancedFormBuilderListVM>>> Handle(GetAllAdvancedFormBuildersBySectionIdQuery Request, CancellationToken cancellationToken)
        {
            string Language = !string.IsNullOrEmpty(Request.lang)
                ? Request.lang.ToLower() : "ar";

            List<AdvancedFormBuilderListVM> AdvancedFormBuilders = new List<AdvancedFormBuilderListVM>();

            if (Request.page != 0 && Request.pageSize != -1)
                AdvancedFormBuilders = await _AdvancedFormBuilderRepository
                    .Where(x => x.AdvancedFormBuilderSectionId == Request.SectionId)
                    .OrderByDescending(x => x.CreatedAt)
                    .Skip((Request.page - 1) * Request.pageSize)
                    .Take(Request.pageSize)
                    .Include(x => x.AttributeDataType!)
                    .Select(x => new AdvancedFormBuilderListVM()
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
                AdvancedFormBuilders = await _AdvancedFormBuilderRepository
                    .Where(x => x.AdvancedFormBuilderSectionId == Request.SectionId)
                    .OrderByDescending(x => x.CreatedAt)
                    .Skip((Request.page - 1) * Request.pageSize)
                    .Take(Request.pageSize)
                    .Include(x => x.AttributeDataType!)
                    .Select(x => new AdvancedFormBuilderListVM()
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

            int TotalCount = await _AdvancedFormBuilderRepository
                .GetCountAsync(x => x.AdvancedFormBuilderSectionId == Request.SectionId);

            Pagination PaginationParameter = new Pagination(Request.page,
                Request.pageSize, TotalCount);

            return new BaseResponse<List<AdvancedFormBuilderListVM>>(ResponseMessage, true, 200, AdvancedFormBuilders, PaginationParameter);
        }
    }
}
