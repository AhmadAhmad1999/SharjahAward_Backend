using MediatR;
using SharijhaAward.Application.Responses;
using System.ComponentModel.DataAnnotations;

namespace SharijhaAward.Application.Features.AppVersioningFeatures.Command.CreateNewAppVersion
{
    public class CreateNewAppVersionCommand : IRequest<BaseResponse<object>>
    {
        public string VersionNumber { get; set; } = null!;
        public string GooglePlayLink { get; set; } = null!;
        public string AppleLink { get; set; } = null!;
        public DateTime VersionDate { get; set; }
        public bool isRequired { get; set; }
        [MaxLength]
        public string UpdatesOnVersion { get; set; } = null!;
        public string? lang { get; set; }
    }
}
