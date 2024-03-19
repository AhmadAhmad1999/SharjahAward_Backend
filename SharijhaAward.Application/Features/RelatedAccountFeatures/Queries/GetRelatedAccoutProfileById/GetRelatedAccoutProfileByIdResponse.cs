
namespace SharijhaAward.Application.Features.RelatedAccountFeatures.Queries.GetRelatedAccoutProfileById
{
    public class GetRelatedAccoutProfileByIdResponse
    {
        public RelatedAccountProfileData ProfileData { get; set; } = new RelatedAccountProfileData();
        public List<RelatedAccountProvidedForms> ProvidedForms { get; set; } = new List<RelatedAccountProvidedForms>();
    }
}
