using Microsoft.AspNetCore.Http;
using SharijhaAward.Domain.Common;
using SharijhaAward.Domain.Constants.AttachmentConstant;
using SharijhaAward.Domain.Entities.TrainingWorkshopModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Domain.Entities.TrainingWrokshopeAttachments
{
    public class TrainingWrokshopeAttachment : AuditableEntity
    {
        public int Id { get; set; }
        public string EnglishName { get; set; } = string.Empty;
        public string ArabicName { get; set; } = string.Empty;
        public string AttachementPath { get; set; } = string.Empty;
        public int SizeOfAttachmentInKB { get; set; }
        public AttachmentType AttachmentType { get; set; }

        public TrainingWorkshop TrainingWorkshop { get; set; } = null!;
        [ForeignKey(nameof(TrainingWorkshop))]
        public int WorkshopeId { get; set; }
    }
}
