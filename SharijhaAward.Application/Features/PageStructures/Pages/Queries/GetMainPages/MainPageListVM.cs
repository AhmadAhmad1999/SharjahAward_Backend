using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.PageStructures.Pages.Queries.GetMainPages
{
    public class MainPageListVM
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string EnglishTitle { get; set; } = string.Empty;
        public string ArabicTitle { get; set; } = string.Empty;
        public int numberOfSubPages { get; set; }
        public bool IsHide { get; set; }
    }
}
