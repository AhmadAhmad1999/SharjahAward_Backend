using SharijhaAward.Application.Features.DynamicAttributeFeatures.Queries.GetAllDynamicAttributes;
using SharijhaAward.Domain.Entities.DynamicAttributeModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.DynamicAttributeSectionsFeatures.Queries.GetAllDynamicAttributeSections
{
    public class DynamicAttributeSectionListVM
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public List<DynamicAttributeListVM> DynamicAttributes { get; set; } = new List<DynamicAttributeListVM>();
    }
}
