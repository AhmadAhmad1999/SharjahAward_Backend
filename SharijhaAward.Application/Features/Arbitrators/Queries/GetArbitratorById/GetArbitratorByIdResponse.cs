using SharijhaAward.Application.Features.Classes.Queries.GetAllClasses;
using SharijhaAward.Application.Features.DynamicAttributeSectionsFeatures.Queries.GetAllDynamicAttributeSectionForAddAdminDashboard;
using SharijhaAward.Application.Features.Responsibilities.Queries.GetAllResponsibilities;

namespace SharijhaAward.Application.Features.Arbitrators.Queries.GetArbitratorById
{
    public class GetArbitratorByIdResponse
    {
        public ArbitratorDto ArbitratorDto { get; set; } = new ArbitratorDto();
        public List<GetAllDynamicAttributeSectionsForAddListVMAdminDashboard> DynamicAttributesSections { get; set; } =
            new List<GetAllDynamicAttributeSectionsForAddListVMAdminDashboard>();
        public List<ResponsibilityUserDto>? ResponsibilityUsers { get; set; }        
    }
}
