﻿using SharijhaAward.Domain.Constants;

namespace SharijhaAward.Application.Features.Coordinators.Queries.GetCoordinatorById
{
    public class CoordinatorDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string ArabicName { get; set; } = string.Empty;
        public string EnglishName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public EducationType EducationType { get; set; }
        public Emirates Emirates { get; set; }
        public string PersonalPhoto { get; set; } = string.Empty;
        public List<EduEntitiesCoordinatorDto>? EducationalEntities { get; set; }
        public List<EduInstitutionCoordinatorDto>? InstitutionEntities { get; set; }
    }
}
