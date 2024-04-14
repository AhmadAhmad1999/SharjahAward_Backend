using SharijhaAward.Domain.Common;
using SharijhaAward.Domain.Constants.CommitteeConstants;
using SharijhaAward.Domain.Entities.ArbitratorModel;
using SharijhaAward.Domain.Entities.CategoryCommitteeModel;

namespace SharijhaAward.Domain.Entities.CommitteeModel; 

public class Committee : AuditableEntity
{
    public int Id { get; set; }
    public string ArabicName { get; set; } = string.Empty;
    public string EnglishName { get; set; } = string.Empty;
    public CommitteeStatus Status { get; set; } = CommitteeStatus.InActive;
    public int ChairmanId { get; set; }
    public Arbitrator Chairman { get; set; } = null!;
    public  List<CategoryCommittee> CategoryCommittees { get; set; } = new();
}