using MediatR;
using SharijhaAward.Application.Helpers.EmailValidationHelper;
using SharijhaAward.Application.Helpers.PhoneNumberValidationAttributeHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.InviteeForm.Personal.Command.UpdatePersonalInvitee
{
    public class UpdatePersonalInviteeCommand : IRequest<Unit>
    {
        public int Id { get; set; }
        public string? Name { get; set; } = string.Empty;
        [PhoneNumberValidation]
        public string? PhoneNumber { get; set; } = string.Empty;
        [EmailValidation]
        public string? Email { get; set; } = string.Empty;
        public string? Employer { get; set; } = string.Empty;
        public string? JobTitle { get; set; } = string.Empty;
        public string? TypeOfInvitee { get; set; } = string.Empty;
    }
}
