using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.TrainingWorkshops.Command.DeleteTrainingWorkshop
{
    public class DeleteTrainingWorkshopCommand :IRequest<Unit>
    {
        public Guid Id { get; set; }
    }
}
