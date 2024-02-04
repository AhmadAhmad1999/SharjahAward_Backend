using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using SharijhaAward.Domain.Entities.CategoryModel;
using SharijhaAward.Domain.Entities.CommitteeModel;
using SharijhaAward.Domain.Entities.Common;
using SharijhaAward.Domain.Entities.IdentityModels;

namespace SharijhaAward.Domain.Entities.CategoryCommitteeModel; 

public class CategoryCommittee : AuditInformation<User>{

    [Key]
    public int Id { get; set; }
    // navigation to the Category
    [ForeignKey(nameof(Category))]
    public Guid CategoriesId { get; set; }
    public Category Category = new();
    
   // navigation to the Committee 
   [ForeignKey(nameof(Committee))]
   public Guid CommitteesId { get; set; }
   public Committee Committee { get; set; } = new();
}