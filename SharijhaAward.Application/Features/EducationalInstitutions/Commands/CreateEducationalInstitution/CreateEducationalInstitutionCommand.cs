﻿using MediatR;
using SharijhaAward.Application.Helpers.ArabicNameValidationAttributeHelper;
using SharijhaAward.Application.Helpers.EnglishNameValidationAttributeHelper;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Constants;

namespace SharijhaAward.Application.Features.EducationalInstitutions.Commands.CreateEducationalInstitution
{
    public class CreateEducationalInstitutionCommand 
    {
        [EnglishNameValidation]
        public string EnglishName { get; set; } = string.Empty;
        [ArabicNameValidation]
        public string ArabicName { get; set; } = string.Empty;
        public EducationType EducationType { get; set; }
        public Emirates Emirates { get; set; }
    }
}
