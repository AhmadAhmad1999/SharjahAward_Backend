using System.ComponentModel.DataAnnotations;

namespace SharijhaAward.Application.Features.AppVersioningFeatures.Query.GetLastAppVersion
{
    public class GetLastAppVersionDto
    {
        public int Id { get; set; }
        public string VersionNumber { get; set; } = null!;
        public string GooglePlayLink { get; set; } = null!;
        public string AppleLink { get; set; } = null!;
        public DateTime VersionDate { get; set; }
        public bool isRequired { get; set; }
        [MaxLength]
        public string UpdatesOnVersion { get; set; } = null!;
    }
}
