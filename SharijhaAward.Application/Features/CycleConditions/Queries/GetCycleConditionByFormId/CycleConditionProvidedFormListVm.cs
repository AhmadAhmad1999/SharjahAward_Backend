using SharijhaAward.Application.Features.TermsAndConditions.Queries.GetAllTermsByCategoryId;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.CycleConditions.Queries.GetCycleConditionByCycleId
{
    public class CycleConditionProvidedFormListVm
    {
        public bool IsAgree { get; set; } = false;
        public int CycleConditionId { get; set; }
        public int ProvidedFormId { get; set; }
        public List<CycleConditionAttachmentListVm> Attachments { get; set; } = null!;
    }
}
