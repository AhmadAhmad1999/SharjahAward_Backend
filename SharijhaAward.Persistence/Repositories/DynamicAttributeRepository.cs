using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Domain.Entities.CategoryModel;
using SharijhaAward.Domain.Entities.DynamicAttributeModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Persistence.Repositories
{
    public class DynamicAttributeRepository: BaseRepository<DynamicAttribute>, IDynamicAttributeRepository
    {
        public DynamicAttributeRepository(SharijhaAwardDbContext dbContext) : base(dbContext)
        {
        }
    }
}
