using MediatR;
using SharijhaAward.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.User.Queries.GetUserById
{
    public class GetUserByIdQuery : IRequest<BaseResponse<UserDto>>
    {
        public int? Id {  get; set; }
        public string token {  get; set; } = string.Empty;
        public string? lang { get; set; }
    }
}
