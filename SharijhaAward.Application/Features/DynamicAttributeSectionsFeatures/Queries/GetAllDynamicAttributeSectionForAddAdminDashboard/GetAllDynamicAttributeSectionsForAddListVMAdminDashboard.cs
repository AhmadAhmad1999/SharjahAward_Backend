namespace SharijhaAward.Application.Features.DynamicAttributeSectionsFeatures.Queries.GetAllDynamicAttributeSectionForAddAdminDashboard
{
    public class GetAllDynamicAttributeSectionsForAddListVMAdminDashboard
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public List<DynamicAttributeListWithListValuesVMAdminDashboard> DynamicAttributes { get; set; } = new List<DynamicAttributeListWithListValuesVMAdminDashboard>();
    }
}
