﻿using MediatR;
using SharijhaAward.Application.Helpers.ArabicNameValidationAttributeHelper;
using SharijhaAward.Application.Helpers.EnglishNameValidationAttributeHelper;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Constants.CommitteeConstants;

namespace SharijhaAward.Application.Features.CommitteeFeatures.Commands.CreateCommittee
{
    public class CreateCommitteeCommand : IRequest<BaseResponse<object>>
    {
        [ArabicNameValidation]
        public string ArabicName { get; set; } = string.Empty;
        [EnglishNameValidation]
        public string EnglishName { get; set; } = string.Empty;
        public CommitteeStatus Status { get; set; } = CommitteeStatus.InActive;
        public int ChairmanId { get; set; }
        public List<int> CategoriesIds { get; set; } = new List<int>();
        public List<int> ArbitratorsIds { get; set; } = new List<int>();
        public List<int> OfficersIds { get; set; } = new List<int>();
        public string? lang { get; set; }
    }
}
