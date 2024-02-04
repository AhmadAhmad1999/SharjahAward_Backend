using SharijhaAward.Domain.Constants.NotificationConstant;
using SharijhaAward.Domain.Entities.Common;
using SharijhaAward.Domain.Entities.IdentityModels;

namespace SharijhaAward.Domain.Entities.NotificationModel; 

public class Notification : AuditInformation<User> {
    public Guid Id { get; set; }
    public string ArabicTitle { get; set; } = string.Empty;
    public string EnglishTitle { get; set; } = string.Empty;
    public NotificationReceiver Receiver { get; set; }
}