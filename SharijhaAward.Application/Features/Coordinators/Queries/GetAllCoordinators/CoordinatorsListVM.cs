using SharijhaAward.Application.Features.Coordinators.Queries.GetCoordinatorById;

namespace SharijhaAward.Application.Features.Coordinators.Queries.GetAllCoordinators
{
    public class CoordinatorsListVM
    {
        public int Id { get; set; }
        public string ArabicName { get; set; } = null!;
        public string EnglishName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string PhoneNumber { get; set; } = null!;
        public List<EduEntitiesCoordinatorDto> EducationalEntities { get; set; } = new List<EduEntitiesCoordinatorDto>();
    }
}
