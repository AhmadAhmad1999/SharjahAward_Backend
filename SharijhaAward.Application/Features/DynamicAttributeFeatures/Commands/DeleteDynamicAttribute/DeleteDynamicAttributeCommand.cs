using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.DynamicAttributeFeatures.Commands.DeleteDynamicAttribute
{
    public class DeleteDynamicAttributeCommand : IRequest<Unit>
    {
        public int Id { get; set; }
        public string? lang { get; set; }
    }
}
