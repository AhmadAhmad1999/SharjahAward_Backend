using MediatR;
using SharijhaAward.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.Categories.Queries.GetCategoriesWithSubcategories
{
    public class GetCategoriesWithSubcategoriesQuery :IRequest<BaseResponse<List<CategoriesSubcategoriesDto>>>
    {
        public string lang { get; set; } = string.Empty;
    }
}
