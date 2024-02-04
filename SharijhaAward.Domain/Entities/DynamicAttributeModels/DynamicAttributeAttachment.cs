using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Domain.Entities.DynamicAttributeModels
{
    public class DynamicAttributeAttachment
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Type { get; set; }= string.Empty;
        public float Size { get; set; }
        public string Description { get; set; } = string.Empty;
        public string Note {  get; set; } = string.Empty;
        public DateTime UpdateDate { get; set; }

        public DynamicAttributeTableName TableName { get; set; } = null!;
        [ForeignKey(nameof(TableName))]
        public int TableNameId {  get; set; }

        //Virtual ForeignKey
        public int RecordId { get; set; }

    }
}
