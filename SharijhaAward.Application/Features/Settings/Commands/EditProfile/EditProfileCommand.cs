﻿using MediatR;
using Microsoft.AspNetCore.Http;
using SharijhaAward.Application.Helpers.PhoneNumberValidationAttributeHelper;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Constants;

namespace SharijhaAward.Application.Features.Settings.Commands.EditProfile
{
    public class EditProfileCommand : IRequest<BaseResponse<object>>
    {
        [PhoneNumberValidation]
        public string PhoneNumber { get; set; } = null!;
        public IFormFile? ProfileImage { get; set; }
        public string? WWWRootFilePath { get; set; }
        public Gender Gender { get; set; }
        public string? Token { get; set; }
        public string? lang { get; set; }
    }
}
