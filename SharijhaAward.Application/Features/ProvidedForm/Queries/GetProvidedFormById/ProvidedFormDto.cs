using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.ProvidedForm.Queries.GetProvidedFormById
{
    public class ProvidedFormDto
    {
        public int Id { get; set; }
        public Guid categoryId { get; set; }
        public int CurrentStep { get; set; }
        public int TotalStep { get; set; }
    }
}
