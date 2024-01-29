using SharijhaAward.Domain.Model.ProvidedFormModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Domain.Model.FormConditionModel
{
    public class FormCondition
    {
        public int Id { get; set; }

        public string ArabicTitle { get; set; }=string.Empty;
        public string EnglishTitle { get; set; }=string.Empty;
        public DateTime AgreeDate { get; set; }

        public bool IsSpecial { get; set; }

        public ProvidedForm ProvidedForm { get; set; } = null!;


    }
}
