﻿namespace SharijhaAward.Application.Features.Categories.Queries.GetAllSubCategories
{
    public class GetAllSubCategoriesListVM 
    {
        public int Id { get; set; }
        public string CategoryName { get; set; } = null!;
        public DateTime? SortingFormsStartDate { get; set; }
        public DateTime? SortingFormsEndDate { get; set; }
        public DateTime? InitialArbitrationStartDate { get; set; }
        public DateTime? InitialArbitrationEndDate { get; set; }
        public DateTime? ArbitrationAuditStartDate { get; set; }
        public DateTime? ArbitrationAuditEndDate { get; set; }
        public DateTime? FinalArbitrationStartDate { get; set; }
        public DateTime? FinalArbitrationEndDate { get; set; }
        public int MarginOfDifferenceBetweenArbitrators { get; set; }
    }
}