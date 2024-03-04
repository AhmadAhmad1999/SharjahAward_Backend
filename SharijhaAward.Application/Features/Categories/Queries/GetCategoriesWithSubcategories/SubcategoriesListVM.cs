using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.Categories.Queries.GetCategoriesWithSubcategories
{
    public class SubcategoriesListVM
    {
        public Guid Id {  get; set; }
        public string Icon { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
    }
}
