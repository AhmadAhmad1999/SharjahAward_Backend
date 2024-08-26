namespace SharijhaAward.Application.Features.LoggerFeatures.Queries.ExportToExcel
{
    public class LoggerDto
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int UserId { get; set; }
        public string UserArabicName { get; set; } = null!;
        public string UserEnglishName { get; set; } = null!;
        public string ControllerName { get; set; } = null!;
        public string FunctionName { get; set; } = null!;
        public string HttpMethod { get; set; } = null!;
        public string? BodyParameters { get; set; }
        public string? HeaderParameters { get; set; }
        public string ResponseStatus { get; set; } = null!;
        public string Result { get; set; } = null!;
        public Guid ActivityId { get; set; }
        public int? RecordId { get; set; }
    }
}
