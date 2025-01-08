using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Domain.Entities.CategoryModel;

namespace SharijhaAward.Persistence.Repositories
{
    public class CategoryRepository : BaseRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(SharijhaAwardDbContext dbContext) : base(dbContext)
        {
        }
    }
}
