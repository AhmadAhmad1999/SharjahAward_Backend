using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Domain.Entities.DynamicAttributeModel;

namespace SharijhaAward.Persistence.Repositories
{
    public class DynamicAttributeRepository: BaseRepository<DynamicAttribute>, IDynamicAttributeRepository
    {
        public DynamicAttributeRepository(SharijhaAwardDbContext dbContext) : base(dbContext)
        {
        }
    }
}
