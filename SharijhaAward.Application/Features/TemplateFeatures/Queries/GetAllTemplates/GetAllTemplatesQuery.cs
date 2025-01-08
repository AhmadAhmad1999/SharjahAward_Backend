using MediatR;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Common;
using SharijhaAward.Domain.Entities.TemplateModel;

namespace SharijhaAward.Application.Features.TemplateFeatures.Queries.GetAllTemplates
{
    public class GetAllTemplatesQuery : IRequest<BaseResponse<List<GetAllTemplatesListVM>>>
    {
        public string? lang { get; set; }
        public List<Filter>? filters { get; set; }
        public int page { get; set; } = 1;
        public int perPage { get; set; } = 10;
        public bool? isActive { get; set; }
        public TemplateTypes? TemplateType { get; set; }
    }
}
