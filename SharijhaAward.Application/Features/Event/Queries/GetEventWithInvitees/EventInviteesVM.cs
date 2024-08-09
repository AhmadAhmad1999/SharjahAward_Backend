using SharijhaAward.Application.Helpers.ArabicNameValidationAttributeHelper;
using SharijhaAward.Application.Helpers.EnglishNameValidationAttributeHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.Event.Queries.GetEventWithInvitees
{
    public class EventInviteesVM
    {
        public int Id { get; set; }
        // [EnglishNameValidation(ErrorMessage = "English name must only contain English characters.")]
        public string EnglishName { get; set; } = string.Empty;
        // [ArabicNameValidation(ErrorMessage = "Arabic name must only contain Arabic characters.")]
        public string ArabicName { get; set; } = string.Empty;
        public string EnglishDescription { get; set; } = string.Empty;
        public string ArabicDescription { get; set; } = string.Empty;
        public List<EventInvitessDto>? PersonalInvitees { get; set; }
    }
}
