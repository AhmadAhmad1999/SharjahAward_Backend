using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System.ComponentModel.DataAnnotations;

namespace SharijhaAward.Domain.Constants
{
    public class EducationType
    {
        [Key]
        public int Id {  get; set; }
        public string EnglishTypeName { get; set; } = string.Empty;
        public string ArabicTypeName { get; set; } = string.Empty;
    }
}
