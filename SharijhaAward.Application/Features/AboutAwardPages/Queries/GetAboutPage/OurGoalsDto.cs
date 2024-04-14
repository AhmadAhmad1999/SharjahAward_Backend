using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.AboutAwardPages.Queries.GetAboutPage
{
    public class OurGoalsDto
    {
        public int Id { get; set; }
        public string Goal {  get; set; } = string.Empty;   
        public string ArabicGoal { get; set; } = string.Empty;
        public string EnglishGoal { get; set; } = string.Empty;
    }
}
