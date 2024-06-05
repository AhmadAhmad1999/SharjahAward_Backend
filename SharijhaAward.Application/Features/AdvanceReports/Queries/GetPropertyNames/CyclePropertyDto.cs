using SharijhaAward.Domain.Entities.CategoryModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.AdvanceReports.Queries.GetPropertyNames
{
    public class CyclePropertyDto
    {
        public List<string> CycleProperties { get; set; } = null!;
        public CategoryPropertyDto Category { get; set; } = null!;
    }
}
