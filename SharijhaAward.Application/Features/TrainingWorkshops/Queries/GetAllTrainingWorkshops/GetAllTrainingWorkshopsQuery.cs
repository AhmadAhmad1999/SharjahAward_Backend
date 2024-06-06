using MediatR;
using SharijhaAward.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.TrainingWorkshops.Queries.GetAllTrainingWorkshops
{
    public class GetAllTrainingWorkshopsQuery : IRequest<BaseResponse<List<TrainingWorkshopListVm>>>
    {
        public string lang { get; set; }=string.Empty;
        public int page {  get; set; }
        public int perPage { get; set; }

    }
}
