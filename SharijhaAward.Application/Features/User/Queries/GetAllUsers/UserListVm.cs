using SharijhaAward.Domain.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.User.Queries.GetAllUsers
{
    public class UserListVm
    {
        public int Id { get; set; }
        public string? SubscriberId { get; set; }
        public string ArabicName { get; set; } = string.Empty;
        public string EnglishName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public Gender Gender { get; set; }
        public string PhoneNumber { get; set; } = null!;
        public DateTime CreatedAt { get; set; }
        public string? ImageURL { get; set; }
        public bool isValidAccount { get; set; }

    }
}
