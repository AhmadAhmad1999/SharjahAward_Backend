﻿using MediatR;
using SharijhaAward.Application.Helpers.EmailValidationHelper;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.Authentication.ForgetPassword
{
    public class ForgetPasswordCommand : IRequest<BaseResponse<int>>
    {
        [EmailValidation]
        public string Email { get; set; } = null!;
        public string? lang { get; set; }
        public string? WWWRootFilePath { get; set; }
        public bool intoAdminDashboard { get; set; } = false;
    }
}
