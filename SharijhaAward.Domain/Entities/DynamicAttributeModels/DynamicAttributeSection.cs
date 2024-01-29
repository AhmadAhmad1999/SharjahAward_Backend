using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Domain.Model.DynamicAttributeModels
{
    public class DynamicAttributeSection
    {
        public int Id { get; set; }

        public DynamicAttributeTableName TableName { get; set; }
        [ForeignKey(nameof(TableName))]
        public int TableNameId { get; set; }
    }
}
