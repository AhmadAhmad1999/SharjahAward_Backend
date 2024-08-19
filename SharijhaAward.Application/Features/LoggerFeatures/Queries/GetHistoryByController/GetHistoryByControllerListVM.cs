namespace SharijhaAward.Application.Features.LoggerFeatures.Queries.GetHistoryByController
{
    public class GetHistoryByControllerListVM
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int UserId { get; set; }
        public string UserName { get; set; } = null!;
        public ActionsTypes? ActionType { get; set; }
        public string Result { get; set; } = null!;
        public int? RecordId { get; set; }
    }
}
