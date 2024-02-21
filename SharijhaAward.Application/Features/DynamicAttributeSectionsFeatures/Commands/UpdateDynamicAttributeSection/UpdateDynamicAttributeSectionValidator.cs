using FluentValidation;
using SharijhaAward.Application.Features.Event.Commands.UpdateEvent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.DynamicAttributeSectionsFeatures.Commands.UpdateDynamicAttributeSection
{
    public class UpdateDynamicAttributeSectionValidator : AbstractValidator<UpdateDynamicAttributeSectionCommand>
    {
        public UpdateDynamicAttributeSectionValidator()
        {
            
        }
    }
}
