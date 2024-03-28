using SharijhaAward.Application.Features.Coordinators.Queries.GetCoordinatorById;

namespace SharijhaAward.Application.Features.Coordinators.Queries.GetAllCoordinators
{
    public class GetAllCoordinatorsListVM
    {
        public Guid Id { get; set; }
        public string ArabicName { get; set; } = string.Empty;
        public string EnglishName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public List<EduEntitiesCoordinatorDto> EducationalEntities { get; set; } = new List<EduEntitiesCoordinatorDto>();
    }
}
