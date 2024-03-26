using SharijhaAward.Application.Features.DynamicAttributeSectionsFeatures.Queries.GetAllDynamicAttributeSectionForAddAdminDashboard;
namespace SharijhaAward.Application.Features.Coordinators.Queries.GetCoordinatorById
{
    public class GetCoordinatorByIdRespnse
    {
        public CoordinatorDto CoordinatorDto { get; set; } = new CoordinatorDto();
        public List<GetAllDynamicAttributeSectionsForAddListVMAdminDashboard> DynamicAttributesSections { get; set; } = 
            new List<GetAllDynamicAttributeSectionsForAddListVMAdminDashboard>();
    }
}
