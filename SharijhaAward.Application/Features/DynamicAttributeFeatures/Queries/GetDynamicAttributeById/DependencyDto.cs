using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.DynamicAttributeFeatures.Queries.GetDynamicAttributeById
{
    public class DependencyDto
    {
        public int Id { get; set; }
        public string Value { get; set; } = null!;
        public string? AttributeLabel { get; set; }
        public string Operation { get; set; } = null!;
    }
}
