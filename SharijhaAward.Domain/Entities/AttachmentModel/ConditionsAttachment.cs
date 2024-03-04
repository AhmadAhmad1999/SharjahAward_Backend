using SharijhaAward.Domain.Common;
using SharijhaAward.Domain.Constants.AttachmentConstant;
using SharijhaAward.Domain.Entities.TermsAndConditionsModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Domain.Entities.AttachmentModel
{
    public class ConditionsAttachment : AuditableEntity
    {
        public Guid Id { get; set; }
        public string Attached { get; set; } = string.Empty;
        public int SizeOfAttachmentInKB {  get; set; }
        public AttachmentType Type {  get; set; }

        public TermAndCondition TermAndCondition { get; set; } = null!;
        [ForeignKey(nameof(TermAndCondition))]
        public Guid TermAndConditionId {  get; set; }
    }
}
