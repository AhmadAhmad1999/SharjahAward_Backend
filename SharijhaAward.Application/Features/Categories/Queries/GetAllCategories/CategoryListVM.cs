using SharijhaAward.Domain.Constants.CategoryConstants;
using SharijhaAward.Domain.Constants.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.Categories.Queries.GetAllCategories
{
    public class CategoryListVM
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Icon { get; set; } = string.Empty;
        public CategoryClassification CategoryClassification { get; set; }
        public DateTime? SubscriberPortalClosingDate { get; set; }
        public DateTime? InitialArbitrationStartDate { get; set; }
        public DateTime? InitialArbitrationEndDate { get; set; }
        public DateTime? FinalArbitrationStartDate { get; set; }
        public DateTime? FinalArbitrationEndDate { get; set; }
        public int FinalArbitrationQualificationMark { get; set; }
        public int WinningScore { get; set; }
        public Status Status { get; set; } = Status.InActive;
        public bool RelatedToClasses { get; set; }
        public int ExpectedNumberOfWinners { get; set; }
    }
}
