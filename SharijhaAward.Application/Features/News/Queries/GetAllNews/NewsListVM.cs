﻿using SharijhaAward.Application.Features.News.Queries.GetNewsById;

namespace SharijhaAward.Application.Features.News.Queries.GetAllNews
{
    public class NewsListVM
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string? Description { get; set; } 
        public string? Image { get; set; }
        public string ArabicTitle { get; set; } = string.Empty;
        public string EnglishTitle { get; set; } = string.Empty;
        public string? ArabicDescription { get; set; }
        public string? EnglishDescription { get; set; }
        public DateTime NewsDate { get; set; }
        public bool IsHidden { get; set; }
        public List<NewsImagesDto>? Images { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
