using MediatR;
using SharijhaAward.Application.Features.Event.Queries.GetEventById;
using SharijhaAward.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.DynamicAttributeSectionsFeatures.Queries.GetDynamicAttributeSectionById
{
    public class DynamicAttributeSectionQuery : IRequest<BaseResponse<DynamicAttributeSectionDto>>
    {
        public int Id { get; set; }
        public string lang { get; set; } = string.Empty;
    }
}
