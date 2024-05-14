using SharijhaAward.Domain.Constants.CommitteeConstants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.CommitteeFeatures.Queries.ExportToExcel
{
    public class CommitteeExportDto
    {
        public int Id { get; set; }
        public string ArabicName { get; set; } = string.Empty;
        public string EnglishName { get; set; } = string.Empty;
        public CommitteeStatus Status { get; set; } = CommitteeStatus.InActive;
        public int ChairmanId { get; set; }
        public string ChairmanArabicName { get; set; } = string.Empty;
        public string ChairmanEnglishName { get; set; } = string.Empty;
    }
}
