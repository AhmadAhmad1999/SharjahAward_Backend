using MediatR;
using SharijhaAward.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.EducationalInstitutions.Queries.GetAllEducationalInstitutions
{
    public class GetAllEducationalInstitutionsQuery : IRequest<BaseResponse<List<EducationalInstitutionListVM>>>
    {
        public string lang { get; set; } = string.Empty;
        public Guid? EducationalEntityId {  get; set; }
    }
}
