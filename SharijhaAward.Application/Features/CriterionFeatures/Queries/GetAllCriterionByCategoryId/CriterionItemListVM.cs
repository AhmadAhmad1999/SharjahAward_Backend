using SharijhaAward.Application.Features.TermsAndConditions.Queries.GetAllTermsByCategoryId;
using SharijhaAward.Domain.Entities.CriterionModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.CriterionFeatures.Queries.GetAllCriterionByCategoryId
{
    public class CriterionItemListVM
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public List<AttachmentListVM> CriterionItemAttachments { get; set; } = new List<AttachmentListVM>();
    }
}
