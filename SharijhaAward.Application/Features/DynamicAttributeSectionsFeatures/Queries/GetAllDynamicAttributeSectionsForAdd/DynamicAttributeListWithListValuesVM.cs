using Microsoft.AspNetCore.Http;
using SharijhaAward.Application.Features.DynamicAttributeFeatures.Queries.GetDynamicAttributeById;
using SharijhaAward.Domain.Entities.DynamicAttributeModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.DynamicAttributeSectionsFeatures.Queries.GetAllDynamicAttributeSectionsForAdd
{
    public class DynamicAttributeListWithListValuesVM
    {
        public int Id { get; set; }
        public string Key { get; set; } = null!;
        public string Label { get; set; } = null!;
        public string PlaceHolder { get; set; } = null!;
        public int AttributeDataTypeId { get; set; }
        public string AttributeDataTypeName { get; set; } = null!;
        public bool isRequired { get; set; }
        public string? InsertedValueAsString { get; set; }
        public IFormFile? InsertedValueAsBinaryFile { get; set; }
        public List<DynamicAttributeListValueListVM>? DynamicAttributeListValues { get; set; }
    }
}
