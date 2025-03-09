using SharijhaAward.Application.Features.TrainingWorkshops.Queries.GetWorkShopsByCategoryId;

namespace SharijhaAward.Application.Features.TrainingWorkshops.Queries.GetTrainingWorkshopById
{
    public class TrainingWorkshopDto
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string WorkshopAttachment { get; set; } = string.Empty;
        public string Thumbnail { get; set; } = string.Empty;
        public string ArabicTitle { get; set; } = string.Empty;
        public string EnglishTitle { get; set; } = string.Empty;
        public string ArabicWorkshopAttachment { get; set; } = string.Empty;
        public string EnglishWorkshopAttachment { get; set; } = string.Empty;
        public List<WorkshopAttachmentListVM> Attachments { get; set; } = null!;
    }
}
