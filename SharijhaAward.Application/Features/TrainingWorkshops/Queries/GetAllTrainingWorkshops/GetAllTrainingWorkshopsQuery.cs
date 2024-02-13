using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.TrainingWorkshops.Queries.GetAllTrainingWorkshops
{
    public class GetAllTrainingWorkshopsQuery : IRequest<List<TrainingWorkshopListVm>>
    {
        public string lang { get; set; }=string.Empty;

    }
}
