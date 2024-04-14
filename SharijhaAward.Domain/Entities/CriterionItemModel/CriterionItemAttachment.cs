using SharijhaAward.Domain.Common;
using SharijhaAward.Domain.Entities.ConditionsProvidedFormsModel;
using SharijhaAward.Domain.Entities.ProvidedFormModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Domain.Entities.CriterionItemModel
{
    public class CriterionItemAttachment : AuditableEntity
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string AttachementPath { get; set; } = string.Empty;
        public int CriterionItemId { get; set; }
        public CriterionItem? CriterionItem { get; set; }
        public int ProvidedFormId { get; set; }
        public ProvidedForm? ProvidedForm { get; set; }
    }
}
