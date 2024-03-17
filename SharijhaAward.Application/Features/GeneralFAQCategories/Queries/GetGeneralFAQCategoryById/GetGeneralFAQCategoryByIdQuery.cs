using MediatR;
using SharijhaAward.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.GeneralFAQCategories.Queries.GetGeneralFAQCategoryById
{
    public class GetGeneralFAQCategoryByIdQuery : IRequest<BaseResponse<GetGeneralFAQCategoryByIdDto>>
    {
        public int Id { get; set; }
        public string? lang { get; set; }
    }
}
