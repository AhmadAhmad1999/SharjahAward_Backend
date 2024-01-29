using SharijhaAward.Domain.Constants.DynamicAttribute;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Domain.Model.DynamicAttributeModels
{
    public class DynamicAttributeView
    {
        public int Id { get; set; }

        public string ViewName { get; set; } = string.Empty;

        public DynamicAttributeStatus Status { get; set; }

        public StaticAttribute StaticAttribute { get; set; } = null!;
        [ForeignKey(nameof(StaticAttribute))]
        public int StaticAttributeId { get; set; }

        public DynamicAttribute DynamicAttribute { get; set; }=null!;
        [ForeignKey(nameof(DynamicAttribute))]
        public int DynamicAttributeId { get; set;}
    }
}
