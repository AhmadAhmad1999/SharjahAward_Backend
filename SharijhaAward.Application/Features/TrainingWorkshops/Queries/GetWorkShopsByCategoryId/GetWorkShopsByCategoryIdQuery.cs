using MediatR;
using SharijhaAward.Application.Features.TrainingWorkshops.Queries.GetAllTrainingWorkshops;
using SharijhaAward.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.TrainingWorkshops.Queries.GetWorkShopsByCategoryId
{
    public class GetWorkShopsByCategoryIdQuery : IRequest<BaseResponse<List<TrainingWorkshopListVm>>>
    {
        public int page { get; set; }
        public int pageSize {  get; set; }
        public Guid CategoryId { get; set; }
        public string lang { get; set; } = string.Empty;
    }
}
