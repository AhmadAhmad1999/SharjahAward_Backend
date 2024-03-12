using SharijhaAward.Application.Features.TermsAndConditions.Queries.GetAllTermsByCategoryId;
using SharijhaAward.Domain.Entities.CategoryModel;
using SharijhaAward.Domain.Entities.CriterionModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.CriterionFeatures.Queries.GetAllCriterionByCategoryId
{
    public class SubCriterionListVM
    {
        public Guid Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public List<AttachmentListVM> SubCriterionAttachments { get; set; } = new List<AttachmentListVM>();
        public List<CriterionItemListVM> CriterionItemListVM { get; set; } = new List<CriterionItemListVM>();
    }
}
