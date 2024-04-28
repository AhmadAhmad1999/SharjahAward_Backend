﻿using SharijhaAward.Domain.Constants.CommitteeConstants;

namespace SharijhaAward.Application.Features.CommitteeFeatures.Queries.GetAllCommittees
{
    public class GetAllCommitteesListVM
    {
        public int Id { get; set; }
        public string ArabicName { get; set; } = null!;
        public string EnglishName { get; set; } = null!;
        public CommitteeStatus Status { get; set; } = CommitteeStatus.InActive;
        public int ChairmanId { get; set; }
        public string ChairmanName { get; set; } = null!;
        public DateTime CreatedAt { get; set; }
    }
}
