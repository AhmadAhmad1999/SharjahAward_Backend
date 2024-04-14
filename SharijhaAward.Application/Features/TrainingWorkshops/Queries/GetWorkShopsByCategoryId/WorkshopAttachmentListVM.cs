using SharijhaAward.Domain.Constants.AttachmentConstant;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.TrainingWorkshops.Queries.GetWorkShopsByCategoryId
{
    public  class WorkshopAttachmentListVM
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string EnglishName { get; set; } = string.Empty;
        public string ArabicName { get; set; } = string.Empty;
        public string AttachementURl { get; set; } = string.Empty;
        public int SizeOfAttachmentInKB { get; set; }
        public AttachmentType AttachmentType { get; set; }
    }
}
