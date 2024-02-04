using Microsoft.EntityFrameworkCore;

namespace SharijhaAward.Domain.Entities.Common; 

public class AuditInformation<TModel> : ITimeStamp {
    public Guid CreatedById { get; set; }
    [DeleteBehavior(DeleteBehavior.NoAction)]
    public TModel CreatedBy { get; set; } = default!;
    public Guid UpdatedById { get; set; }
    [DeleteBehavior(DeleteBehavior.NoAction)]
    public TModel UpdatedBy { get; set; } = default!;

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
    public DateTime? DeletedAt { get; set; } = DateTime.UtcNow;
}