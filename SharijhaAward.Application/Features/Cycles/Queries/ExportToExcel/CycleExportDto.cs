using SharijhaAward.Domain.Constants.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.Cycles.Queries.ExportToExcel
{
    public class CycleExportDto
    {

        public int Id { get; set; }
        public int CycleNumber { get; set; }
        public string Year { get; set; } = string.Empty;
        public string ArabicName { get; set; } = string.Empty;
        public string EnglishName { get; set; } = string.Empty;
        public string StatusName { get; set; } = string.Empty;
        public Status Status { get; set; } = Status.Close;
        public DateTime RegistrationPortalOpeningDate { get; set; }
        public DateTime RegistrationPortalClosingDate { get; set; }
        public DateTime? SubscriberPortalClosingDate { get; set; }
        public DateTime? InitialArbitrationStartDate { get; set; }
        public DateTime? InitialArbitrationEndDate { get; set; }
        public DateTime? FinalArbitrationStartDate { get; set; }
        public DateTime? FinalArbitrationEndDate { get; set; }
        public int IndividualCategoryNumber { get; set; } = 0;
        public int TheUpperLimitForObtainingInformation { get; set; }
        public int MarginOfDifferenceBetweenArbitrators { get; set; }
        public int GroupCategoryNumber { get; set; } = 0;
    }
}
