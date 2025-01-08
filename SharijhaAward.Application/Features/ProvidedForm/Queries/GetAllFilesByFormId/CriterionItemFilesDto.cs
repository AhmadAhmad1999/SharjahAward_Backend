namespace SharijhaAward.Application.Features.ProvidedForm.Queries.GetAllFilesByFormId
{
    public class CriterionItemFilesDto
    {
        public string Name { get; set; } = null!;
        public List<FilesInfoDto> CriterionItemsFilesPaths { get; set; } = new List<FilesInfoDto>();
    }
}
