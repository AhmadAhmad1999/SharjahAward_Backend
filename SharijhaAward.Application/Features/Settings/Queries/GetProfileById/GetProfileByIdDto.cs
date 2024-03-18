using SharijhaAward.Domain.Constants;

namespace SharijhaAward.Application.Features.Settings.Queries.GetProfileById
{
    public class GetProfileByIdDto
    {
        public Guid Id { get; set; }
        public string Email { get; set; } = null!;
        public string PhoneNumber { get; set; } = null!;
        public Gender Gender { get; set; }
    }
}
