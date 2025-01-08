namespace SharijhaAward.Application.Features.AdvancedFormBuilderFeatures.Queries.GetAnalysisByVirtualTableForSectionId
{
    public class GetAnalysisByVirtualTableForSectionIdListVM
    {
        public int Id { get; set; }
        public string MainDropDownName { get; set; } = null!;
        public int MainDropDownTotalCount { get; set; }
        public List<EachDropDownDataDto> EachDropDownDataDto { get; set; } = new List<EachDropDownDataDto>();
    }
}
