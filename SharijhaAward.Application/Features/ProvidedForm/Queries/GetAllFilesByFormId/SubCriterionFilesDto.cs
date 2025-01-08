namespace SharijhaAward.Application.Features.ProvidedForm.Queries.GetAllFilesByFormId
{
    public class SubCriterionFilesDto
    {
        public string Name { get; set; } = null!;
        public List<FilesInfoDto> SubCriterionsFilesPaths { get; set; } = new List<FilesInfoDto>();
        public List<CriterionItemFilesDto> CriterionItemFilesDto { get; set; } = new List<CriterionItemFilesDto>();
    }
}
