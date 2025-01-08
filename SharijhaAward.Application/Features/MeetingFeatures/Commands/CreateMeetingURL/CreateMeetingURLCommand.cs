using MediatR;
using Microsoft.Graph;
using Microsoft.Graph.Models;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.MeetingFeatures.Commands.CreateMeetingURL
{
    public class CreateMeetingURLCommand : IRequest<BaseResponse<OnlineMeeting>>
    {
        public int MeetingId { get; set; }
        public string? lang { get; set; }
        public string TenantId { get; set; } = null!;
        public string ClientId { get; set; } = null!;
        public string ClientSecret { get; set; } = null!;
    }
}
