using SharijhaAward.Domain.Common;
using SharijhaAward.Domain.Entities.CategoryModel;
using SharijhaAward.Domain.Entities.CommitteeModel;

namespace SharijhaAward.Domain.Entities.CategoryCommitteeModel; 

public class CategoryCommittee : AuditableEntity
{
    public int Id { get; set; }
    public int CategoriesId { get; set; }
    public Category? Category { get; set; }
    public int CommitteesId { get; set; }
    public Committee? Committee { get; set; }
}