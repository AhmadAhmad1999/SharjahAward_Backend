using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using SharijhaAward.Domain.Model.CategoryModel;
using SharijhaAward.Domain.Model.CommitteeModel;
using SharijhaAward.Domain.Model.Common;
using SharijhaAward.Domain.Model.IdentityModels;

namespace SharijhaAward.Domain.Model.CategoryCommitteeModel; 

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