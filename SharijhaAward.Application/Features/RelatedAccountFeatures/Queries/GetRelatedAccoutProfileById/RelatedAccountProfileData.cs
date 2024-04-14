
using SharijhaAward.Domain.Constants;

namespace SharijhaAward.Application.Features.RelatedAccountFeatures.Queries.GetRelatedAccoutProfileById
{
    public class RelatedAccountProfileData
    {
        public int Id { get; set; }
        public string Email { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string? ImageURL { get; set; }
        public string PhoneNumber { get; set; } = null!;
        public Gender Gender { get; set; }
    }
}
