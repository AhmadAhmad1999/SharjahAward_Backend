﻿using SharijhaAward.Application.Helpers.EmailValidationHelper;
using SharijhaAward.Application.Helpers.PhoneNumberValidationAttributeHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.InviteeForm.Group.Queries.GetGroupByInviteeNumber
{
    public class GroupDto
    {
        public int Id { get; set; }
        public int UniqueIntegerId { get; set; }
        public string Name { get; set; } = string.Empty;
        [PhoneNumberValidation]
        public string PhoneNumber { get; set; } = string.Empty;
        [EmailValidation]
        public string Email { get; set; } = string.Empty;
        public string SchoolName { get; set; } = string.Empty;
        public string JobTitle { get; set; } = string.Empty;
        public int ExpectedNumberOfAttendees { get; set; }
        public int ActualNumberOfAttendees { get; set; }
    }
}
