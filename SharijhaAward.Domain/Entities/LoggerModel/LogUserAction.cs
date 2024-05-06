using SharijhaAward.Domain.Common;

namespace SharijhaAward.Domain.Entities.LoggerModel
{
    public class LogUserAction : AuditableEntity
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int UserId { get; set; }
        public string ControllerName { get; set; } = null!;
        public string FunctionName { get; set; } = null!;
        public string? BodyParameters { get; set; }
        public string? HeaderParameters { get; set; }
        public string ResponseStatus { get; set; } = null!;
        public string Result { get; set; } = null!;
    }
}
