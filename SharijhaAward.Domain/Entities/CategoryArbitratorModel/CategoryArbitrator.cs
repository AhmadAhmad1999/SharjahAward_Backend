using SharijhaAward.Domain.Model.ArbitratorModel;
using SharijhaAward.Domain.Model.CategoryModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Domain.Model.CategoryArbitratorModel
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
