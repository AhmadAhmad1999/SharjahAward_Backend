namespace SharijhaAward.Application.Features.ProvidedForm.Queries.GetAllFilesByFormId
{
    public class MainCriterionFilesDto
    {
        public string Name { get; set; } = null!;
        public List<SubCriterionFilesDto> SubCriterionFilesDto { get; set; } = new List<SubCriterionFilesDto>();
    }
}
