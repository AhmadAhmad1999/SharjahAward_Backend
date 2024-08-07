namespace SharijhaAward.Application.Features.HomePageFeatures.Queries.GetAllHomePageData
{
    public class GetAllHomePageDataDto
    {
        public int SubscribersNumber { get; set; } // 

        public int FormsNumber { get; set; } // 

        public int ContactUsNumber { get; set; } // 

        public int AllCompletedFormsAsNumber { get; set; } // 
        public float AllCompletedFormsAsPercentage { get; set; } //

        public int AllUnCompletedFormsAsNumber { get; set; } // 
        public float AllUnCompletedFormsAsPercentage { get; set; } // 

        public int AllAcceptedFormsAsNumber { get; set; } // 
        public float AllAcceptedFormsAsPercentage { get; set; } //

        public int AllUnAcceptedFormsAsNumber { get; set; } // 
        public float AllUnAcceptedFormsAsPercentage { get; set; } //

        public int AssigedFormsNumber { get; set; } //

        public int FormsInInitialArbitrationAsNumber { get; set; } // 
        public float FormsInInitialArbitrationAsPercentage { get; set; } //

        public int FormsInArbitrationAuditAsNumber { get; set; } //
        public float FormsInArbitrationAuditAsPercentage { get; set; } //

        public int FormsInFinalArbitrationAsNumber { get; set; } // 
        public float FormsInFinalArbitrationAsPercentage { get; set; } //

        public List<FormsInCategories>? FormsInCategories { get; set; } //
    }
}
