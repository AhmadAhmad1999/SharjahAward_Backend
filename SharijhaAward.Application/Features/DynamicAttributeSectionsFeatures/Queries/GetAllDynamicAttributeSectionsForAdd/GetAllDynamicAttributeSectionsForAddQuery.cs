using MediatR;
using SharijhaAward.Application.Features.DynamicAttributeSectionsFeatures.Queries.GetAllDynamicAttributeSectionsForView;
using SharijhaAward.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.DynamicAttributeSectionsFeatures.Queries.GetAllDynamicAttributeSectionsForAdd
{
    public class GetAllDynamicAttributeSectionsForAddQuery : IRequest<BaseResponse<List<GetAllDynamicAttributeSectionsForAddListVM>>>
    {
        public Guid CategoryId { get; set; }
        public string lang { get; set; } = string.Empty;
    }
}
