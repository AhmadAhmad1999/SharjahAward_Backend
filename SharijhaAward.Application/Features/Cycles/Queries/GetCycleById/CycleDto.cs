using SharijhaAward.Domain.Constants.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.Cycles.Queries.GetCycleById
{
    public class CycleDto
    {
        public Guid Id { get; set; }
        public int CycleNumber { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Year { get; set; } = string.Empty;
        public string ArabicName { get; set; } = string.Empty;
        public string EnglishName { get; set; } = string.Empty;
        public Status Status { get; set; } = Status.InActive;
        public DateTime RegistrationPortalOpeningDate { get; set; }
        public DateTime RegistrationPortalClosingDate { get; set; }
        public int IndividualCategoryNumber { get; set; } = 0;
        public int GroupCategoryNumber { get; set; } = 0;
    }
}
