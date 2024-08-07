namespace SharijhaAward.Application.Features.DynamicAttributeSectionsFeatures.Queries.GetAllDynamicAttributeSectionsForAdd
{
    public class GetAllDynamicAttributeSectionsForAddListVM
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public bool TableTypeSection { get; set; }
        public bool rejected { get; set; } = false;
        public List<DynamicAttributeListWithListValuesVM> BaseDynamicAttributes { get; set; } = new List<DynamicAttributeListWithListValuesVM>();
        public List<DynamicAttributeListWithListValuesVM> DynamicAttributes { get; set; } = new List<DynamicAttributeListWithListValuesVM>();
        public List<ViewWhenForAddDto> ViewWhenForAddDtos { get; set; } = new List<ViewWhenForAddDto>();
    }
}
