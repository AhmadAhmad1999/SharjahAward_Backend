using MediatR;
using SharijhaAward.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.Categories.Queries.GatCategoryById
{
    public class GetCategoryByIdQuery : IRequest<BaseResponse<CategoryDto>>
    {
        public Guid Id { get; set; }
        public string lang { get; set; }=string.Empty;
    }
}
