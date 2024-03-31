using SharijhaAward.Application.Features.DynamicAttributeSectionsFeatures.Queries.GetAllDynamicAttributeSectionForAddAdminDashboard;

namespace SharijhaAward.Application.Features.Arbitrators.Queries.GetArbitratorById
{
    public class GetArbitratorByIdResponse
    {
        public ArbitratorDto ArbitratorDto { get; set; } = new ArbitratorDto();
        public List<GetAllDynamicAttributeSectionsForAddListVMAdminDashboard> DynamicAttributesSections { get; set; } =
            new List<GetAllDynamicAttributeSectionsForAddListVMAdminDashboard>();
    }
}
