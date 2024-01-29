using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Domain.Model.DynamicAttributeModels
{
    public class DynamicAttributeValue
    {
        public int Id { get; set; }

        public string Value { get; set; }=string.Empty;

        //Virtual ForeignKey
        public int RecordId { get; set; }

        public DynamicAttribute DynamicAttribute { get; set; } = null!;
        [ForeignKey(nameof(DynamicAttribute))]
        public int DynamicAttributeId { get; set; }

    }
}
