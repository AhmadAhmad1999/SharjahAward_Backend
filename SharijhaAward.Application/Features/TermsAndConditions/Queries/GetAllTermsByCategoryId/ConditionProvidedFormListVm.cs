using SharijhaAward.Domain.Entities.AttachmentModel;
using SharijhaAward.Domain.Entities.TermsAndConditionsModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.TermsAndConditions.Queries.GetAllTermsByCategoryId
{
    public class ConditionProvidedFormListVm
    {
        public bool IsAgree { get; set; } = false;
        public List<AttachmentListVM> Attachments { get; set; } = null!;
        public int TermAndConditionId { get; set; }
        public int ProvidedFormId { get; set; }
    }
}
