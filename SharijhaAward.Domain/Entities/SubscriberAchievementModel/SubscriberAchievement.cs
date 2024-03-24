using System.ComponentModel.DataAnnotations.Schema;
using SharijhaAward.Domain.Constants.SubscriberAchievementConstants;
using SharijhaAward.Domain.Entities.AchievementClassificationModel;
using SharijhaAward.Domain.Entities.Common;
using SharijhaAward.Domain.Entities.IdentityModels;

namespace SharijhaAward.Domain.Entities.SubscriberAchievementModel; 

/*
 *
 * Note
 * This model need configuration inside the infra layer in configuration directory
 * configuration for the fluent api.
 * 
 */
public class SubscriberAchievement: AuditInformation<User> {
   public Guid Id { get; set; }
   // the arabic title of the achievement
   public string ArabicTitle { get; set; } = string.Empty;
   // the english title of the achievement
   public string EnglishTitle { get; set; } = string.Empty;
   // the attachment (file) of the achievement
   public string Attachment { get; set; } = string.Empty;
   
   // the date of the achievement
   public DateOnly Date { get; set; }
   
   // the status of the achievement => (accepted, rejected)
   public AchievementStatus Status { get; set; }
   
   // navigation property to the achievement classification 
   public AchievementClassification AchievementClassification { get; set; } = null!;
   [ForeignKey(nameof(AchievementClassification))]
   public Guid AchievementClassificationId { get; set; }

   
   
   public User User { get; set; } = null!;
   [ForeignKey(nameof(User))]
   public Guid UserId { get; set; }
}