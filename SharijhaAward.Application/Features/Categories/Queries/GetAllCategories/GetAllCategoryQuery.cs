using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.Categories.Queries.GetAllCategories
{
    public class GetAllCategoryQuery : IRequest<List<CategoryListVM>>
    {
        public string lang { get; set; } = string.Empty;
    }
}
