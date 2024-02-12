using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.TrainingWorkshops.Queries.GetTrainingWorkshopById
{
    public class GetTrainingWorkshopByIdQuery : IRequest<TrainingWorkshopDto>
    {
        public Guid Id { get; set; }
        public string lang { get; set; }=string.Empty;
    }
}
