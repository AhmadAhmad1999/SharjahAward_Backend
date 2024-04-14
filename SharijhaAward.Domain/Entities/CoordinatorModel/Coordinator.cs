﻿using SharijhaAward.Domain.Common;
using SharijhaAward.Domain.Constants;
using SharijhaAward.Domain.Entities.EducationCoordinatorModel;
using SharijhaAward.Domain.Entities.EduInstitutionCoordinatorModel;

namespace SharijhaAward.Domain.Entities.CoordinatorModel
{
    public class Coordinator : AuditableEntity
    {
        public int Id { get; set; }
        public string ArabicName { get; set; } = string.Empty;
        public string EnglishName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public EducationType EducationType { get; set; }
        public Emirates Emirates { get; set; }
        public string PersonalPhoto { get; set; } = string.Empty;

        public List<EduEntitiesCoordinator>? EducationCoordinators { get; set; } 
        public List<EduInstitutionCoordinator>? InstitutionCoordinators {  get; set; } 
    }
}
