using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.ProvidedForm.Queries.GetFormsWithArbitrators
{
    public class FormsWithArbitratorsDto
    {
        public int Id { get; set; }
        public int CycleNumber { get; set; }
        public string CategoryName { get; set; } = string.Empty;
        public string SubCategoryName { get; set; } = string.Empty;
        public List<string>? ArbitratorsNames { get; set; }
    }
}
