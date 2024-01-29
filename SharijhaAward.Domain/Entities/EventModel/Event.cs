using SharijhaAward.Domain.Common;
using SharijhaAward.Domain.Entities.InvitationModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Domain.Entities.EventModel
{
    public class Event 
    {
        public Guid Id { get; set; }
        public string EnglishName { get; set; } = string.Empty;
        public string ArabicName { get; set; } = string.Empty;
        public string EnglishDescription { get; set; } = string.Empty;
        public string ArabicDescription { get; set; } = string.Empty;
        public string EnglishLocation {  get; set; } = string.Empty;
        public string ArabicLocation {  get; set; } = string.Empty;
        public string EnglishSiteName {  get; set; } = string.Empty;
        public string ArabicSiteName { get; set; } = string.Empty;
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public List<PersonalInvitee>? PersonalInvitees { get; set; }
    }
}
