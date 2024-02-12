using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.TrainingWorkshops.Command.UpdateTrainingWrokshop
{
    public class UpdateTrainingWorkshopCommand : IRequest<Unit>
    {
        public Guid Id { get; set; }
        public string ArabicTitle { get; set; } = string.Empty;
        public string EnglishTitle { get; set; } = string.Empty;
        public string ArabicWorkshopAttachment { get; set; } = string.Empty;
        public string EnglishWorkshopAttachment { get; set; } = string.Empty;
        public string Thumbnail { get; set; } = string.Empty;
        public Guid CategoryId { get; set; }
    }
}
