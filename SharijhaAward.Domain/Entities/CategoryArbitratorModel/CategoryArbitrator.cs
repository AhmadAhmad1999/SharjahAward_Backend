using SharijhaAward.Domain.Entities.ArbitratorModel;
using SharijhaAward.Domain.Entities.CategoryModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Domain.Entities.CategoryArbitratorModel
{
    public class CategoryArbitrator
    {
        public int Id { get; set; } 

        public Category Category { get; set; } = null!;
        
        [ForeignKey(nameof(Category))]
        public Guid CategoryId { get; set; }

        public Arbitrator Arbitrator { get; set; } = null!;

        [ForeignKey(nameof(Arbitrator))]
        public Guid ArbitratorId { get; set; }
    }
}
