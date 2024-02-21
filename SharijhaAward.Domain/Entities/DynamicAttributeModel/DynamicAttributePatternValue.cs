using SharijhaAward.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Domain.Entities.DynamicAttributeModel
{
    public class DynamicAttributePatternValue : AuditableEntity
    {
        public int Id { get; set; }
        public string Value { get; set; } = null!;
        public int DynamicAttributePatternId { get; set; }
        public DynamicAttributePattern? DynamicAttributePattern { get; set; }
    }
}
