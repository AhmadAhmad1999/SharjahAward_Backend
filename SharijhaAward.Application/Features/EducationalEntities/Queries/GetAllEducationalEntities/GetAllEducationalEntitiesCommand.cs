using MediatR;
using SharijhaAward.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.EducationalEntities.Queries.GetAllEducationalEntities
{
    public class GetAllEducationalEntitiesCommand :IRequest<BaseResponse<List<EducationalEntitiesListVm>>>
    {
        public string? ArabicName { get; set; } = string.Empty;
        public string? EnglishName { get; set; } = string.Empty;
    }
}
