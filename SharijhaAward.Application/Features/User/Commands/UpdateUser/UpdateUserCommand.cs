using MediatR;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.User.Commands.UpdateUser
{
    public class UpdateUserCommand : IRequest<BaseResponse<object>>
    {
        public string lang { get; set; } = string.Empty;
        public Guid? Id { get; set; }
        public Gender Gender { get; set; }
        public string PhoneNumber { get; set; } = null!;
    }
}
