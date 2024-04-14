
namespace SharijhaAward.Application.Features.GeneralFAQs.Queries.GetGeneralFAQById
{
    public class GeneralFAQDto
    {
        public int Id { get; set; }
        public string Question { get; set; } = null!;
        public string Answer { get; set; } = null!;
    }
}
