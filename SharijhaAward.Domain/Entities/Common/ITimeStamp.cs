using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SharijhaAward.Domain.Entities.Common; 

public interface ITimeStamp {
   // created at timestamp
   [Column("CreatedAt")]
   public DateTime CreatedAt { get; set; }
   // updated at timestamp
   [Column("UpdatedAt")]
   public DateTime UpdatedAt { get; set; }
   // deleted at timestamp
   [Column("DeletedAt")]
   public DateTime? DeletedAt { get; set; }
}