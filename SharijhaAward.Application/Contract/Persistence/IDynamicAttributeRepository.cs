using SharijhaAward.Domain.Entities.CategoryModel;
using SharijhaAward.Domain.Entities.DynamicAttributeModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Contract.Persistence
{
    public interface IDynamicAttributeRepository : IAsyncRepository<DynamicAttribute>
    {
    }
}
