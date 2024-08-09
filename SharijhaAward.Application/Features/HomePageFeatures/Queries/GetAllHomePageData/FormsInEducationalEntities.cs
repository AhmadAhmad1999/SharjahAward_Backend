namespace SharijhaAward.Application.Features.HomePageFeatures.Queries.GetAllHomePageData
{
    public class FormsInEducationalEntities
    {
        public int EducationalEntityId { get; set; }// 
        public string EducationalEntityName { get; set; } = null!;// 
        public int FormsNumberInEducationalEntity { get; set; }// 
        public float FormsNumberInEducationalEntityAsPercentage { get; set; } // 
        public int AcceptedFormsNumberInEducationalEntityAsNumber { get; set; } //
        public float AcceptedFormsNumberInEducationalEntityAsPercentage { get; set; }// 
        public int RejectedFormsNumberInEducationalEntityAsNumber { get; set; } //
        public float RejectedFormsNumberInEducationalEntityAsPercentage { get; set; } //
        public int NotAcceptedNorRejectedFormsNumberInEducationalEntityAsNumber { get; set; }
        public float NotAcceptedNorRejectedFormsNumberInEducationalEntityAsPercentage { get; set; }
    }
}
