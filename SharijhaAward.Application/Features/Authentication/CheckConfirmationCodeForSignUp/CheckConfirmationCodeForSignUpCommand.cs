using MediatR;
using SharijhaAward.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.Authentication.CheckConfirmationCodeForSignUp
{
    public class CheckConfirmationCodeForSignUpCommand : IRequest<BaseResponse<object>>
    {
        public Guid Id { get; set; }
        public int ConfirmationCode { get; set; }
        public string lang { get; set; } = string.Empty;
    }
}
