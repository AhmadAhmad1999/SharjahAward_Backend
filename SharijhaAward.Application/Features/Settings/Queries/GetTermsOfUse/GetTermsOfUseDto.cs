using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.Settings.Queries.GetTermsOfUse
{
    public class GetTermsOfUseDto
    {
        [MaxLength]
        public string? Text { get; set; }
    }
}
