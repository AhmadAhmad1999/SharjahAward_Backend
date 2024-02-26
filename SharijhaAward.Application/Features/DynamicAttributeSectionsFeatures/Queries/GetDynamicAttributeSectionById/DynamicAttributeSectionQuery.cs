using MediatR;
using SharijhaAward.Application.Features.Event.Queries.GetEventById;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.DynamicAttributeSectionsFeatures.Queries.GetDynamicAttributeSectionById
{
    public class DynamicAttributeSectionQuery : IRequest<DynamicAttributeSectionDto>
    {
        public Guid Id { get; set; }
        public string lang { get; set; } = string.Empty;
    }
}
