using SharijhaAward.Application.Features.DynamicAttributeFeatures.Queries.GetAllDynamicAttributesBySectionId;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.DynamicAttributeSectionsFeatures.Queries.GetAllDynamicAttributeSectionsForAdd
{
    public class GetAllDynamicAttributeSectionsForAddListVM
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public List<DynamicAttributeListWithListValuesVM> DynamicAttributes { get; set; } = new List<DynamicAttributeListWithListValuesVM>();
    }
}
