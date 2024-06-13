﻿using SharijhaAward.Domain.Constants.AttachmentConstant;

namespace SharijhaAward.Application.Features.CriterionFeatures.Queries.GetMainCriterionById
{
    public class CriterionItemListDto
    {
        public int Id { get; set; }
        public string ArabicName { get; set; } = string.Empty;
        public string EnglishName { get; set; } = string.Empty;
        public int Score { get; set; }
        public int? SizeOfAttachmentInKB { get; set; }
        public int MaxAttachmentNumber { get; set; }
        public AttachmentType AttachmentType { get; set; }
    }
}
