﻿namespace SharijhaAward.Application.Features.DynamicAttributePatterns.Queries.GetDynamicAttributePatternById
{
    public class GetDynamicAttributePatternByIdDto
    {
        public int Id { get; set; }
        public string ArabicLabel { get; set; } = null!;
        public string EnglishLabel { get; set; } = null!;
        public string ArabicPlaceHolder { get; set; } = null!;
        public string EnglishPlaceHolder { get; set; } = null!;
        public bool IsRequired { get; set; } = false;
        public bool IsUnique { get; set; } = false;
        public List<GetDynamicAttributePatternByIdValues> Values { get; set; } = new List<GetDynamicAttributePatternByIdValues>();
    }
}
