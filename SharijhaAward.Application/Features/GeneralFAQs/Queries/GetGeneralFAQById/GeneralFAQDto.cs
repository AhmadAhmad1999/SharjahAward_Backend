
namespace SharijhaAward.Application.Features.GeneralFAQs.Queries.GetGeneralFAQById
{
    public class GeneralFAQDto
    {
        public int Id { get; set; }
        public string ArabicQuestion { get; set; } = null!;
        public string EnglishQuestion { get; set; } = null!;
        public string ArabicAnswer { get; set; } = null!;
        public string EnglishAnswer { get; set; } = null!;
        public int GeneralFrequentlyAskedQuestionCategoryId { get; set; }
    }
}
