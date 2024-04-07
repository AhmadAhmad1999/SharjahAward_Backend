using SharijhaAward.Domain.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.User.Queries.GetUserById
{
    public class UserDto
    {
        public Guid Id { get; set; }
        public string Email { get; set; } = string.Empty;
        public string Role {  get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = null!;
        public Gender Gender { get; set; }
        public string? ImageURL { get; set; }
    }
}
