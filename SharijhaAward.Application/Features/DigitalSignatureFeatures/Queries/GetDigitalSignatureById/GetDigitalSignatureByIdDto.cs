namespace SharijhaAward.Application.Features.DigitalSignatureFeatures.Queries.GetDigitalSignatureById
{
    public class GetDigitalSignatureByIdDto
    {
        public int Id { get; set; }
        public string ImageUrl { get; set; } = null!;
        public string UserName { get; set; } = null!;
        public string ArabicFullName { get; set; } = null!;
        public string EnglishFullName { get; set; } = null!;
        public string EnglishOccupation { get; set; } = null!;
        public string ArabicOccupation { get; set; } = null!;
    }
}
