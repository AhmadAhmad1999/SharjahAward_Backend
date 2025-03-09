using SharijhaAward.Domain.Common;

namespace SharijhaAward.Domain.Entities.WebSiteResponseModel
{
    public class WebSiteResponseAttachment : AuditableEntity
    {
        public int Id { get; set; }
        public string FilePath { get; set; } = null!;
        public int WebSiteResponseId { get; set; }
        public WebSiteResponse? WebSiteResponse { get; set; }
    }
}
