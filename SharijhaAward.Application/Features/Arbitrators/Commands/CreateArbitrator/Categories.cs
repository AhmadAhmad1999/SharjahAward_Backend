using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.Arbitrators.Commands.CreateArbitrator
{
    public class Categories
    {
        public int SubCategoryId {  get; set; }
        public List<int>? ArbitratorClasses { get; set; }
    }
}
