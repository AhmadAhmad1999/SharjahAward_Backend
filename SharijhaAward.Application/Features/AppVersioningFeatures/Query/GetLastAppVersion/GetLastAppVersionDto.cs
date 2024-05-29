using SharijhaAward.Domain.Constants;
using System.ComponentModel.DataAnnotations;

namespace SharijhaAward.Application.Features.AppVersioningFeatures.Query.GetLastAppVersion
{
    public class GetLastAppVersionDto
    {
        public int Id { get; set; }
        public string VersionNumber { get; set; } = null!;
        public string AppLink { get; set; } = null!;
        public AppType AppType { get; set; }
        public DateTime VersionDate { get; set; }
        public bool isRequired { get; set; }
        [MaxLength]
        public string UpdatesOnVersion { get; set; } = null!;
    }
}
