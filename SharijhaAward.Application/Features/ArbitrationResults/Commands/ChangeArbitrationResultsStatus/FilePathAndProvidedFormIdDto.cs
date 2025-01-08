using SharijhaAward.Domain.Entities.TemplateModel;

namespace SharijhaAward.Application.Features.ArbitrationResults.Commands.ChangeArbitrationResultsStatus
{
    public class FilePathAndProvidedFormIdDto
    {
        public int ProvidedFormId { get; set; }
        public string FilePath { get; set; } = null!;
        public TemplateTypes TemplateType { get; set; }
    }
}
