using SharijhaAward.Domain.Entities.ExplanatoryMessageModel;
using System.ComponentModel.DataAnnotations;

namespace SharijhaAward.Application.Features.ExplanatoryMessageFeatures.Queries.GetExplanatoryMessageById
{
    public class GetExplanatoryMessageByIdDto
    {
        public int Id { get; set; }
        [MaxLength]
        public string ArabicText { get; set; } = null!;
        [MaxLength]
        public string EnglishText { get; set; } = null!;
        public TypeOfExplantoryMessage Type { get; set; }
    }
}
