using SharijhaAward.Application.Features.DynamicAttributeSectionsFeatures.Queries.GetAllDynamicAttributeSectionsForAdd;

namespace SharijhaAward.Application.Features.DynamicAttributeSectionsFeatures.Queries.GetAllDynamicAttributeSectionsForAddForUser
{
    public class RolesListVM
    {
        public int RoleId { get; set; }
        public string RoleName { get; set; } = null!;
        public List<GetAllDynamicAttributeSectionsForAddListVM> DynamicAttributes { get; set; } = new List<GetAllDynamicAttributeSectionsForAddListVM>();
    }
}
