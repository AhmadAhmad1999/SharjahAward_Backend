﻿using SharijhaAward.Domain.Entities.TemplateModel;

namespace SharijhaAward.Application.Features.TemplateFeatures.Queries.GetAllTemplates
{
    public class GetAllTemplatesListVM
    {
        public int Id { get; set; }
        public string BackgroundImageUrl { get; set; } = null!;
        public string TemplateVersion { get; set; } = null!;
        public string FontColor { get; set; } = null!;
        public TemplateTypes TemplateType { get; set; }
        public bool isActive { get; set; }
    }
}
