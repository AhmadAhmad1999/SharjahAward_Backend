using SharijhaAward.Domain.Constants.NotificationConstant;
using SharijhaAward.Domain.Model.Common;
using SharijhaAward.Domain.Model.IdentityModels;

namespace SharijhaAward.Domain.Model.NotificationModel; 

public class Notification : AuditInformation<User> {
    public Guid Id { get; set; }
    public string ArabicTitle { get; set; } = string.Empty;
    public string EnglishTitle { get; set; } = string.Empty;
    public NotificationReceiver Receiver { get; set; }
}