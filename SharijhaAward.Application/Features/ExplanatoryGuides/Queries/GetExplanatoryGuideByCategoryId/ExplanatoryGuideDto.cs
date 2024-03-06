using MimeKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.ExplanatoryGuides.Queries.GetExplanatoryGuideByCategoryId
{
    public class ExplanatoryGuideDto
    {

        public byte[] fileContent {  get; set; }
        public string fileContentType { get; set; } = null;
        public string fileFileName { get; set; }
    }
}
