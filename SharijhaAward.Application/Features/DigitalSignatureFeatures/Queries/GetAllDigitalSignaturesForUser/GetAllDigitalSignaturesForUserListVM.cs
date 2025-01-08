namespace SharijhaAward.Application.Features.DigitalSignatureFeatures.Queries.GetAllDigitalSignaturesForUser
{
    public class GetAllDigitalSignaturesForUserListVM
    {
        public int Id { get; set; }
        public string ImageUrl { get; set; } = null!;
        public string UserName { get; set; } = null!;
        public string FullName { get; set; } = null!;
        public string Occupation { get; set; } = null!;
    }
}
