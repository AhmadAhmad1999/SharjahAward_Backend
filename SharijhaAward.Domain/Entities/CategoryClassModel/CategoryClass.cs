using SharijhaAward.Domain.Entities.CategoryModel;
using SharijhaAward.Domain.Entities.EducationalClassModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Domain.Entities.CategoryClassModel
{
    public class CategoryClass
    {
        public int Id { get; set; }

        public int WinnerNumber { get; set; }

        public Category Category { get; set; } = null!;

        [ForeignKey(nameof(Category))]
        public Guid CategoryId { get; set; }
    
        public EducationalClass EducationalClass { get; set; }=null!;

        [ForeignKey(nameof(EducationalClass))]
        public Guid EducationalClassId { get; set; }
    }
}
