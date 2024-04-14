﻿using SharijhaAward.Domain.Constants.AttachmentConstant;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.CycleConditions.Queries.GetCycleConditionById
{
    public class CycleConditionDto
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string ArabicTitle { get; set; } = string.Empty;
        public string EnglishTitle { get; set; } = string.Empty;
        public string ArabicDescription { get; set; } = string.Empty;
        public string EnglishDescription { get; set; } = string.Empty;
        public bool NeedAttachment { get; set; } = false;
        public int? RequiredAttachmentNumber { get; set; }
        public int? SizeOfAttachmentInKB { get; set; }
        public AttachmentType? AttachmentType { get; set; }

        public int CycleId { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
