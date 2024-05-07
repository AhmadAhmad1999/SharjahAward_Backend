using Newtonsoft.Json;
using SharijhaAward.Application.Helpers.DateTimeConverter;

namespace SharijhaAward.Application.Features.Classes.Queries.GetAllClasses
{
    public class GetAllClassesListVM
    {
        public int Id { get; set; }
        public string ArabicName { get; set; } = null!;
        public string EnglishName { get; set; } = null!;
        public DateTime CreatedAt { get; set; }
    }
}
