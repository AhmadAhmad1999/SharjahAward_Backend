using SharijhaAward.Application.Helpers.EmailValidationHelper;
using System.ComponentModel.DataAnnotations;

namespace SharijhaAward.Application.Features.MeetingFeatures.Queries.GetAllSubscribersInfoByCategoryId
{
    public class GetAllSubscribersInfoByCategoryIdListVM
    {
        public int FormId { get; set; }
        public string Name { get; set; } = null!;
        [EmailValidation]
        public string Email { get; set; } = null!;
    }
}
