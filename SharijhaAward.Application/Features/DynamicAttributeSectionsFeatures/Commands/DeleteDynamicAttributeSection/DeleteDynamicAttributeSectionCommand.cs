using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.DynamicAttributeSectionsFeatures.Commands.DeleteDynamicAttributeSection
{
    public class DeleteDynamicAttributeSectionCommand : IRequest<Unit>
    {
        public int Id { get; set; }
    }
}
