using SharijhaAward.Domain.Entities.ProvidedFormModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Domain.Entities.FormConditionModel
{
    public class FormCondition
    {
        public int Id { get; set; }

        public string ArabicTitle { get; set; } = string.Empty;
        public string EnglishTitle { get; set; } = string.Empty;
        public bool? IsAgree { get; set; }
        public bool? IsSpecial { get; set; } = false;
        public bool? IshaveAttchment { get; set; } = false;
        public ProvidedForm ProvidedForm { get; set; } = null!;


    }
}
