using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.AdvanceReports.Queries.GetPropertyNames
{
    public class CategoryPropertyDto
    {
        public List<string> CatgegoryProperties { get; set; } = null!;
        public ProvidedFormPropertyDto ProvidedForms { get; set; } = null!;
    }
}
