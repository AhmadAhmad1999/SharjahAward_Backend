﻿using MediatR;
using SharijhaAward.Application.Features.MeetingFeatures.Commands.CreateMeeting;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.MeetingFeatures.Commands.SendEmailToUsersInMeeting
{
    public class SendEmailToUsersInMeetingCommand : IRequest<BaseResponse<object>>
    {
        public int MeetingId { get; set; }
        public string? lang { get; set; }
        public string? WWWRootFilePath { get; set; }
    }
}
