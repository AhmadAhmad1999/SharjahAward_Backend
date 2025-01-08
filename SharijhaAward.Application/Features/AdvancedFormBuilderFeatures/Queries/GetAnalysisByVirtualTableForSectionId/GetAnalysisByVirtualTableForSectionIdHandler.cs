using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.AdvancedFormBuilderModel;

namespace SharijhaAward.Application.Features.AdvancedFormBuilderFeatures.Queries.GetAnalysisByVirtualTableForSectionId
{
    public class GetAnalysisByVirtualTableForSectionIdHandler 
        : IRequestHandler<GetAnalysisByVirtualTableForSectionIdQuery, BaseResponse<List<GetAnalysisByVirtualTableForSectionIdListVM>>>
    {
        private readonly IAsyncRepository<AdvancedFormBuilder> _AdvancedFormBuilderRepository;
        private readonly IAsyncRepository<AdvancedFormBuilderListValue> _AdvancedFormBuilderListValueRepository;
        private readonly IAsyncRepository<AdvancedFormBuilderValue> _AdvancedFormBuilderValueRepository;

        public GetAnalysisByVirtualTableForSectionIdHandler(IAsyncRepository<AdvancedFormBuilder> _AdvancedFormBuilderRepository,
            IAsyncRepository<AdvancedFormBuilderListValue> _AdvancedFormBuilderListValueRepository,
            IAsyncRepository<AdvancedFormBuilderValue> _AdvancedFormBuilderValueRepository)
        {
            this._AdvancedFormBuilderRepository = _AdvancedFormBuilderRepository;
            this._AdvancedFormBuilderListValueRepository = _AdvancedFormBuilderListValueRepository;
            this._AdvancedFormBuilderValueRepository = _AdvancedFormBuilderValueRepository;
        }

        public async Task<BaseResponse<List<GetAnalysisByVirtualTableForSectionIdListVM>>> 
            Handle(GetAnalysisByVirtualTableForSectionIdQuery Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            IEnumerable<AdvancedFormBuilder> AdvancedFormBuilderAsListEntities = await _AdvancedFormBuilderRepository
                .Where(x => x.AdvancedFormBuilderSection!.VirtualTableForSectionId == Request.VirtualTableForSectionId &&
                    x.AttributeDataType!.Name == "List" && x.AttributeDataType!.ArabicName == "قائمة منسدلة")
                .ToListAsync();
            
            IEnumerable<AdvancedFormBuilderListValue> AdvancedFormBuilderListValueEntities = await _AdvancedFormBuilderListValueRepository
                .Where(x => AdvancedFormBuilderAsListEntities.Select(y => y.Id).Contains(x.AdvancedFormBuilderId))
                .ToListAsync();

            IEnumerable<AdvancedFormBuilderValue> AdvancedFormBuilderValueEntities = await _AdvancedFormBuilderValueRepository
                .Where(x => AdvancedFormBuilderAsListEntities.Select(y => y.Id).Contains(x.AdvancedFormBuilderId))
            .ToListAsync();

            List<GetAnalysisByVirtualTableForSectionIdListVM> Response = AdvancedFormBuilderAsListEntities
                .Select(x => new GetAnalysisByVirtualTableForSectionIdListVM()
                {
                    Id = x.Id,
                    MainDropDownName = Request.lang == "en"
                        ? x.EnglishLabel
                        : x.ArabicLabel,
                    MainDropDownTotalCount = AdvancedFormBuilderListValueEntities
                        .Count(y => y.AdvancedFormBuilderId == x.Id),
                    EachDropDownDataDto = AdvancedFormBuilderListValueEntities
                        .Where(y => y.AdvancedFormBuilderId == x.Id)
                        .Select(y => new EachDropDownDataDto()
                        {
                            SelectedName = Request.lang == "en"
                                ? y.EnglishValue
                                : y.ArabicValue,
                            Count = AdvancedFormBuilderValueEntities
                                .Count(z => z.Value == y.Id.ToString()),
                            Percentage = AdvancedFormBuilderListValueEntities
                                .Count(z => z.AdvancedFormBuilderId == x.Id) > 0
                                    ? ((float.Parse(AdvancedFormBuilderValueEntities
                                        .Count(z => z.Value == y.Id.ToString()).ToString()) / float.Parse(AdvancedFormBuilderListValueEntities
                                            .Count(z => z.AdvancedFormBuilderId == x.Id).ToString())) * 100)
                                    : 0
                        }).ToList()
                }).ToList();

            return new BaseResponse<List<GetAnalysisByVirtualTableForSectionIdListVM>>(ResponseMessage, true, 200, Response.ToList());
        }
    }
}
