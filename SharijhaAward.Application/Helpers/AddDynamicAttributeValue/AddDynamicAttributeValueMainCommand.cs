using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Helpers.AddDynamicAttributeValue
{
    public class AddDynamicAttributeValueMainCommand
    {
        public int DynamicAttributeId { get; set; }
        public string? ValueAsString { get; set; } = null!;
        public IFormFile? ValueAsBinaryFile { get; set; } = null!;
    }
}
