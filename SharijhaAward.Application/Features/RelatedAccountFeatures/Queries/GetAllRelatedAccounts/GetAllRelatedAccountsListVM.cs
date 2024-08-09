using SharijhaAward.Application.Helpers.EmailValidationHelper;
using SharijhaAward.Domain.Constants;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.RelatedAccountFeatures.Queries.GetAllRelatedAccounts
{
    public class GetAllRelatedAccountsListVM
    {
        public int Id { get; set; }
        [EmailValidation]
        public string Email { get; set; } = null!;
        public string Name { get; set; } = null!;
        public Gender Gender { get; set; }
        public string? ImageURL { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
