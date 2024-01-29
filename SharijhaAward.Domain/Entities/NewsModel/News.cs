using SharijhaAward.Domain.Constants.Common;
using SharijhaAward.Domain.Model.Common;
using SharijhaAward.Domain.Model.CycleModel;
using SharijhaAward.Domain.Model.IdentityModels;

namespace SharijhaAward.Domain.Model.NewsModel; 

public class News : AuditInformation<User> {
    public Guid Id { get; set; }
    // arabic title of the news 
    public string ArabicTitle { get; set; } = string.Empty;
    // english title of the news
    public string EnglishTitle { get; set; } = string.Empty;
    // arabic description of the news
    public string? ArabicDescription { get; set;}
    // english description of the news
    public string? EnglishDescription { get; set; }
    // the image of the news (attachment)
    public string? Image { get; set; }
    // the full date of the news
    public DateTime Date { get; set; }
    // the visibility of the news (visible, invisible)
    public Visibility Visible { get; set; }
    
    // navigation property to the cycle table
    public Cycle Cycle { get; set; } = null!;
    public Guid CycleId { get; set; }
}