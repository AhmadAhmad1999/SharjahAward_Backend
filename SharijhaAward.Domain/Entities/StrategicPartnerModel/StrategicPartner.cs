using SharijhaAward.Domain.Common;
using SharijhaAward.Domain.Entities.PageStructureModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Domain.Entities.StrategicPartnerModel
{
    public class StrategicPartner : AuditableEntity
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string LogoUrl { get; set; } = string.Empty;
        public string? Url { get; set; }
        public int orderId { get; set; }
        public bool IsHide {  get; set; }
        public PageStructure PageStructure { get; set; } = null!;

        [ForeignKey(nameof(PageStructure))]
        public int PageId { get; set; }
    }
}
