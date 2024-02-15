﻿using SharijhaAward.Application.Features.DynamicAttributeFeaturesFeatures.Commands.CreateDynamicAttribute;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.DynamicAttributeFeatures.Commands.CreateDynamicAttribute
{
    public class CreateDependencyValidation
    {
        public string Value { get; set; } = null!;
        public int AttributeOperationId { get; set; }
        public List<CreateDependency> Dependencies { get; set; } = null!;
    }
}
