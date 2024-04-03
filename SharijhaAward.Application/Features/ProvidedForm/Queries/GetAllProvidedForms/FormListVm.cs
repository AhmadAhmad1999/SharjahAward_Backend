using SharijhaAward.Domain.Constants.ProvidedFromConstants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.ProvidedForm.Queries.GetAllProvidedForms
{
    public class FormListVm
    {
        public int Id { get; set; }
        public int PercentCompletion { get; set; }
        public int CycleNumber { get; set; }
        public string CycleYear { get; set; } = string.Empty;
        public ProvidedFormType Type { get; set; }
        public ProvidedFormStatus Status { get; set; }
        public SubscriberType SubscriberType { get; set; }
        public int CurrentStep { get; set; }
        public int TotalStep {  get; set; }
        public string CategoryName { get; set; } = string.Empty;
        public float FinalScore { get; set; }
        public Guid categoryId { get; set; }
        public DateTime CreatedAt { get; set; }

    }
}
