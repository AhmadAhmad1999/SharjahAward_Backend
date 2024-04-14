using MediatR;
using SharijhaAward.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.Coordinators.Queries.AddCordinatorToEduEntity
{
    public class AddCoordinatorToEduEntityQuery : IRequest<BaseResponse<int>>
    {
        public int CoordinatorId { get; set; }
        public int EducationalEntityId { get; set; }
        public DateTime RelatedDate { get; set; }
    }
}
