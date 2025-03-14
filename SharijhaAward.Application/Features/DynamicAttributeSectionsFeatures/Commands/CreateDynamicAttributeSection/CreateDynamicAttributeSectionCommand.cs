﻿using MediatR;
using SharijhaAward.Application.Helpers.ArabicNameValidationAttributeHelper;
using SharijhaAward.Application.Helpers.EnglishNameValidationAttributeHelper;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Constants;

namespace SharijhaAward.Application.Features.DynamicAttributeSectionsFeatures.Commands.CreateDynamicAttributeSection
{
    public class CreateDynamicAttributeSectionCommand : IRequest<BaseResponse<CreateDynamicAttributeSectionResponse>>
    {
        [ArabicNameValidation]
        public string ArabicName { get; set; } = null!;
        [EnglishNameValidation]
        public string EnglishName { get; set; } = null!;
        public int AttributeTableNameId { get; set; }
        public int? RecordIdOnRelation { get; set; }
        public bool TableTypeSection { get; set; }
        public int? MinNumberOfRows { get; set; }
        public int? MaxNumberOfRows { get; set; }
        public InviteeTypes? InviteeType { get; set; }
        public string? lang { get; set; }
    }
}
