﻿using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.NotificationFeatures.Commands.CreateNotification
{
    public class CreateNotificationCommand : IRequest<BaseResponse<object>>
    {
        public string ArabicTitle { get; set; } = null!;
        public string EnglishTitle { get; set; } = null!;
        public string ArabicBody { get; set; } = null!;
        public string EnglishBody { get; set; } = null!;
        public List<int> UsersIds { get; set; } = new List<int>();
        public bool ToAllRoles { get; set; }
        public List<int> RolesIds { get; set; } = new List<int>();
        public string? lang { get; set; }
    }
}
