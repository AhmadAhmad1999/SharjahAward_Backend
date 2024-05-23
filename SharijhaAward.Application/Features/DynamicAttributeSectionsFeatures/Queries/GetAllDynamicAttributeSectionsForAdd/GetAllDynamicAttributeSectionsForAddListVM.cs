﻿namespace SharijhaAward.Application.Features.DynamicAttributeSectionsFeatures.Queries.GetAllDynamicAttributeSectionsForAdd
{
    public class GetAllDynamicAttributeSectionsForAddListVM
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public bool TableTypeSection { get; set; }
        public List<DynamicAttributeListWithListValuesVM> DynamicAttributes { get; set; } = new List<DynamicAttributeListWithListValuesVM>();
    }
}
