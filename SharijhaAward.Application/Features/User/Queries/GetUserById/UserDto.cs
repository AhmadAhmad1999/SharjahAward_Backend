using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.User.Queries.GetUserById
{
    public class UserDto
    {
        public Guid UserId { get; set; }
        public string ArabicName { get; set; }=string.Empty;
        public string EnglishName {  get; set; }=string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Role {  get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = null!;
        public string? ImageURL { get; set; }
    }
}
