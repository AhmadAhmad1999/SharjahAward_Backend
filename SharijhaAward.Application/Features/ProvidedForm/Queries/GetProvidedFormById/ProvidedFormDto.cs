using SharijhaAward.Domain.Constants.ProvidedFromConstants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.ProvidedForm.Queries.GetProvidedFormById
{
    public class ProvidedFormDto
    {
        public int Id { get; set; }
        public int PercentCompletion { get; set; }
        public int CycleNumber { get; set; }
        public string CycleYear { get; set; } = string.Empty;
        public ProvidedFormType Type { get; set; }
        public ProvidedFormStatus Status { get; set; }
        public SubscriberType SubscriberType { get; set; }
        public int CurrentStep { get; set; }
        public int TotalStep { get; set; }
        public string MainCategoryName { get; set; } = string.Empty;
        public string SubCategoryName { get; set; } = string.Empty;
        public float FirstArbitrationScore { get; set; }
        public float SecondArbitrationScore { get; set; }
        public float FinalScore { get; set; }
        public int categoryId { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
