using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.Cycles.Commands.ImportFromOldCycle
{
    public class ImportFromOldCycleCommand : IRequest<BaseResponse<object>>
    {
        public int NewCycleId { get; set; }
        public List<MainCategoryImport> MainCategoryImport { get; set; } = new List<MainCategoryImport>();
        public string? lang { get; set; }
    }
}
