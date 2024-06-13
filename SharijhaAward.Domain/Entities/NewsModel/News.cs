using SharijhaAward.Domain.Common;
using SharijhaAward.Domain.Constants.Common;
using SharijhaAward.Domain.Entities.Common;
using SharijhaAward.Domain.Entities.CycleModel;
using SharijhaAward.Domain.Entities.IdentityModels;

namespace SharijhaAward.Domain.Entities.NewsModel; 

public class News : AuditableEntity
{
    public int Id { get; set; }
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
    public DateTime NewsDate { get; set; }

    // navigation property to the cycle table
    public Cycle Cycle { get; set; } = null!;
    public int CycleId { get; set; }

    public List<NewsImage>? NewsImages { get; set; }

}