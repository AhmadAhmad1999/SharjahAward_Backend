﻿using SharijhaAward.Application.Features.TermsAndConditions.Queries.GetAllTermsByCategoryId;
using SharijhaAward.Domain.Constants.AttachmentConstant;
using SharijhaAward.Domain.Entities.AttachmentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.TermsAndConditions.Queries.GetAllTermAndCondition
{
    public class TermAndConditionListVM
    {
        public Guid Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string ArabicTitle { get; set; } = string.Empty;
        public string EnglishTitle { get; set; } = string.Empty;
        public string ArabicDescription { get; set; } = string.Empty;
        public string EnglishDescription { get; set; } = string.Empty;
        public bool NeedAttachment { get; set; } = false;
        public int? RequiredAttachmentNumber { get; set; }
        public int? SizeOfAttachmentInKB { get; set; }
        public AttachmentType? Type { get; set; }
        public bool IsAgree { get; set; }
        public bool? IsSpecial { get; set; } = false;
        public Guid CategoryId { get; set; }
        public List<AttachmentListVM>? ConditionAttachments { get; set; }
    }
}
