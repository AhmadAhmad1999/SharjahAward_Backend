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
        public int Id { get; set; }
        public string Email { get; set; } = string.Empty;
        public List<string> UserRoles {  get; set; } = new List<string>();
        public string PhoneNumber { get; set; } = null!;
        public Gender Gender { get; set; }
        public string? ImageURL { get; set; }
    }
}
