namespace SharijhaAward.Application.Features.ProvidedForm.Queries.GetAllFilesByFormId
{
    public class GetAllFilesByFormIdMainResponse
    {
        public string Name { get; set; } = null!;
        public List<FilesInfoDto> Files { get; set; } = new List<FilesInfoDto>();
        public List<GetAllFilesByFormIdMainResponse> SubFolders { get; set; } = new List<GetAllFilesByFormIdMainResponse>();
    }
}
