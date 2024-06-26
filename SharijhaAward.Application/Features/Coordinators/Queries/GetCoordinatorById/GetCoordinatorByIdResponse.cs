using SharijhaAward.Application.Features.DynamicAttributeSectionsFeatures.Queries.GetAllDynamicAttributeSectionForAddAdminDashboard;
using SharijhaAward.Application.Features.Responsibilities.Queries.GetAllResponsibilities;
namespace SharijhaAward.Application.Features.Coordinators.Queries.GetCoordinatorById
{
    public class GetCoordinatorByIdResponse
    {
        public CoordinatorDto CoordinatorDto { get; set; } = new CoordinatorDto();
        public List<GetAllDynamicAttributeSectionsForAddListVMAdminDashboard> DynamicAttributesSections { get; set; } = 
            new List<GetAllDynamicAttributeSectionsForAddListVMAdminDashboard>();
        public List<ResponsibilityUserDto>? ResponsibilityUsers { get; set; }
    }
}
