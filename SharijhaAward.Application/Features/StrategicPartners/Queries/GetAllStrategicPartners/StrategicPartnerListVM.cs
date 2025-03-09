namespace SharijhaAward.Application.Features.StrategicPartners.Queries.GetAllStrategicPartners
{
    public class StrategicPartnerListVM
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string LogoUrl { get; set; } = string.Empty;
        public string? Url { get; set; }
        public int orderId { get; set; }
        public bool IsHide { get; set; }
        public int PageId { get; set; }
    }
}
