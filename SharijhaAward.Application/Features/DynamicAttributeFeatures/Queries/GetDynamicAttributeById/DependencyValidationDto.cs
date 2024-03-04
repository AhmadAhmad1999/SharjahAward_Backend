using SharijhaAward.Application.Features.DynamicAttributeFeaturesFeatures.Commands.CreateDynamicAttribute;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.DynamicAttributeFeatures.Queries.GetDynamicAttributeById
{
    public class DependencyValidationDto
    {
        public int Id { get; set; }
        public string Value { get; set; } = null!;
        public string Operation { get; set; } = null!;
        public List<DependencyDto> Dependencies { get; set; } = null!;
    }
}
