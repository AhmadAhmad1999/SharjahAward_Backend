﻿using SharijhaAward.Domain.Constants;
using SharijhaAward.Domain.Constants.CustomPageConstants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.PageStructures.Pages.Queries.GetMainPagesWithSubPages
{
    public class SubPageListVM
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string EnglishTitle { get; set; } = string.Empty;
        public string ArabicTitle { get; set; } = string.Empty;
        public int ParentId { get; set; }
        public string Slug { get; set; } = string.Empty;
        public string? RefUrl { get; set; }
        public bool IsHide { get; set; }
        public PageType PageType { get; set; }
        public PagePostion PagePostion { get; set; }
        public int orderId { get; set; }
        public bool Deletable { get; set; }
    }
}
