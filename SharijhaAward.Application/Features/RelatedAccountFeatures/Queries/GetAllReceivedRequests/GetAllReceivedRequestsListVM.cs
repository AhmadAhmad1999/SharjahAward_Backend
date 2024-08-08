﻿using SharijhaAward.Domain.Constants;
using System.ComponentModel.DataAnnotations;

namespace SharijhaAward.Application.Features.RelatedAccountFeatures.Queries.GetAllReceivedRequests
{
    public class GetAllReceivedRequestsListVM
    {
        public int Id { get; set; }
        [EmailAddress(ErrorMessage = "Invalid email address")]
        public string Email { get; set; } = null!;
        public string Name { get; set; } = null!;
        public Gender Gender { get; set; }
        public string? ImageURL { get; set; }
    }
}
