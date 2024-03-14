using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.EducationalInstitutions.Queries.GetAllEducationalInstitutions
{
    public class EducationalInstitutionListVM
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string ArabicName { get; set; } = string.Empty;
        public string EnglishName { get; set; } = string.Empty;
    }
}
