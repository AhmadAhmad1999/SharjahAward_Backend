using SharijhaAward.Domain.Constants.AttachmentConstant;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.CycleConditions.Queries.ExportToExcel
{
    public class CycleConditionExportDto
    {
        public int Id { get; set; }
        public string ArabicTitle { get; set; } = string.Empty;
        public string EnglishTitle { get; set; } = string.Empty;
        public string ArabicDescription { get; set; } = string.Empty;
        public string EnglishDescription { get; set; } = string.Empty;
        public bool NeedAttachment { get; set; } = false;
        public int? RequiredAttachmentNumber { get; set; }
        public int? SizeOfAttachmentInKB { get; set; }
        public AttachmentType? AttachmentType { get; set; }
    }
}
