using SharijhaAward.Application.Features.Arbitrators.Queries.GetArbitratorById;
using SharijhaAward.Application.Features.Categories.Queries.GetCategoryById;
using SharijhaAward.Domain.Constants.CommitteeConstants;

namespace SharijhaAward.Application.Features.CommitteeFeatures.Queries.GetCommitteeById
{
    public class GetCommitteeByIdDto
    {
        public int Id { get; set; }
        public string ArabicName { get; set; } = null!;
        public string EnglishName { get; set; } = null!;
        public CommitteeStatus Status { get; set; } = CommitteeStatus.InActive;
        public List<ArbitratorDto> Arbitrators { get; set; } = new List<ArbitratorDto>();
        public List<CategoryDto> Categories { get; set; } = new List<CategoryDto>();
    }
}
