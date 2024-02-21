using SharijhaAward.Domain.Constants.DynamicAttribute;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.DynamicAttributeFeatures.Queries.GetAllDynamicAttributes
{
    public class DynamicAttributeListVM
    {
        public int Id { get; set; }
        public string Key { get; set; } = null!;
        public string Label { get; set; } = null!;
        public string PlaceHolder { get; set; } = null!;
        public string Status { get; set; } = null!;
        public string AttributeDataTypeName { get; set; } = null!;
    }
}
