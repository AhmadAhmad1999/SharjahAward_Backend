using MediatR;
using SharijhaAward.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.Cycles.Queries.CycleImportLastData
{
    public class CycleImportLastDataQuery : IRequest<BaseResponse<object>>
    {
        public int newCycleId { get; set; }
        public int CycleId { get; set; }
        public bool? ImportCycleConditions { get; set; }
        public bool? ReplaceCycleConditions { get; set; }
        public List<int>? CycleConditionIds { get; set; }
        public bool? ImportCategories { get; set; }
        public bool? ReplaceCategories { get; set; }
        public List<int>? CategoryIds { get; set; } 
        public List<int>? SubCategoryIds { get; set; }
        public bool? ImportExplanatoryGuide { get; set; }
        public bool? ImportFAQs { get; set; }
        public List<int>? FAQIds { get; set; } 
        public bool? ImportSpecialConditions { get; set; }
        public List<int>? SpecialConditionIds { get; set; } 
        public bool? ImportCriterions { get; set; }
        public List<int>? CriterionIds { get; set; }
        public bool? ImportRewards { get; set; }
        public List<int>? RewardIds { get; set; } 
        public bool? ImportTrainingWorkshop { get; set; }
        public List<int>? TrainingWorkshopIds { get; set; } 
        public bool Replace { get; set; }
        public string? lang {  get; set; }

    }
}
