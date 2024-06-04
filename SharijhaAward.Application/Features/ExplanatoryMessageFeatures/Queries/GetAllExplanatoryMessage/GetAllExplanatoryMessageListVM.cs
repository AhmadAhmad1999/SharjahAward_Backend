using SharijhaAward.Domain.Entities.ExplanatoryMessageModel;

namespace SharijhaAward.Application.Features.ExplanatoryMessageFeatures.Queries.GetAllExplanatoryMessage
{
    public class GetAllExplanatoryMessageListVM
    {
        public int Id { get; set; }
        public TypeOfExplantoryMessage Type { get; set; }
    }
}
