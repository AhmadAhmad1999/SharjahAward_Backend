using System.ComponentModel.DataAnnotations.Schema;
using SharijhaAward.Domain.Constants.CommitteeConstants;
using SharijhaAward.Domain.Entities.CategoryCommitteeModel;
using SharijhaAward.Domain.Entities.CategoryModel;
using SharijhaAward.Domain.Entities.Common;
using SharijhaAward.Domain.Entities.IdentityModels;

namespace SharijhaAward.Domain.Entities.CommitteeModel; 

public class Committee : AuditInformation<User> {
    public Guid Id { get; set; }
    
    // arabic name of the committee
    public string ArabicName { get; set; } = string.Empty;
    
    // english name of the committee
    public string EnglishName { get; set; } = string.Empty;
    
    // the status of the committee
    public CommitteeStatus Status { get; set; } = CommitteeStatus.InActive;
    
    // navigation property to the user table.
    // the chairman of the committee
    public User Chairman { get; set; } = null!;
    [ForeignKey(nameof(Chairman))]
    public Guid ChairmanId { get; set; }
    
    // navigation property to the category table.
    public  List<CategoryCommittee> CategoryCommittees { get; set; } = new();
    public virtual List<Category> Categories { get; set; } = new();
}