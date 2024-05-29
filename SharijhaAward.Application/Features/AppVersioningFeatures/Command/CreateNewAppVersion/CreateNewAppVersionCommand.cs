using MediatR;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Constants;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace SharijhaAward.Application.Features.AppVersioningFeatures.Command.CreateNewAppVersion
{
    public class CreateNewAppVersionCommand : IRequest<BaseResponse<object>>
    {
        public string VersionNumber { get; set; } = null!;
        public string AppLink { get; set; } = null!;
        public AppType AppType { get; set; }
        public DateTime VersionDate { get; set; }
        public bool isRequired { get; set; }
        [MaxLength]
        public string UpdatesOnVersion { get; set; } = null!;
        public string? lang { get; set; }
    }
}
