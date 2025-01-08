namespace SharijhaAward.Application.Features.ProvidedForm.Queries.GetAllFilesByFormId
{
    public class GetAllFilesByFormIdDto
    {
        public List<string> PersonalInformations { get; set; } = new List<string>();
        public List<FilesInfoDto> SpecialConditions { get; set; } = new List<FilesInfoDto>();
        public List<FilesInfoDto> GeneralConditions { get; set; } = new List<FilesInfoDto>();
        public List<FilesInfoDto> ExtraAttachments { get; set; } = new List<FilesInfoDto>();
        public List<MainCriterionFilesDto> MainCriterionFilesDto { get; set; } = new List<MainCriterionFilesDto>();
    }
}
