namespace SharijhaAward.Application.Features.PageStructures.Pages.Queries.GetMainPagesWithSubPages
{
    public class GetMainPagesWithSubPagesResponse
    {
        public List<MainPageWithSubPageListVM> InsideCells { get; set; } = new List<MainPageWithSubPageListVM>();
        public List<MainPageWithSubPageListVM> OutsideCells { get; set; } = new List<MainPageWithSubPageListVM>();
    }
}
