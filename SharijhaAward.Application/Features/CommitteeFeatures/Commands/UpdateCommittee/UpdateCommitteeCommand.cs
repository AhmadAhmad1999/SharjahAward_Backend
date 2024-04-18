﻿using MediatR;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Constants.CommitteeConstants;

namespace SharijhaAward.Application.Features.CommitteeFeatures.Commands.UpdateCommittee
{
    public class UpdateCommitteeCommand : IRequest<BaseResponse<object>>
    {
        public int Id { get; set; }
        public string ArabicName { get; set; } = string.Empty;
        public string EnglishName { get; set; } = string.Empty;
        public CommitteeStatus Status { get; set; } = CommitteeStatus.InActive;
        public int ChairmanId { get; set; }
        public List<int> CategoriesIds { get; set; } = new List<int>();
        public List<int> ArbitratorsIds { get; set; } = new List<int>();
        public string? lang { get; set; }
    }
}
