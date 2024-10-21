using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Common;
using SharijhaAward.Domain.Entities.TemplateModel;

namespace SharijhaAward.Application.Features.TemplateFeatures.Queries.GetAllTemplates
{
    public class GetAllTemplatesHandler : IRequestHandler<GetAllTemplatesQuery, BaseResponse<List<GetAllTemplatesListVM>>>
    {
        private readonly IAsyncRepository<Template> _TemplateRepository;
        private readonly IMapper _Mapper;

        public GetAllTemplatesHandler(IAsyncRepository<Template> _TemplateRepository,
            IMapper Mapper)
        {
            this._TemplateRepository = _TemplateRepository;
            _Mapper = Mapper;
        }

        public async Task<BaseResponse<List<GetAllTemplatesListVM>>> Handle(GetAllTemplatesQuery Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            FilterObject FilterObject = new FilterObject() { Filters = Request.filters };

            List<GetAllTemplatesListVM> GetAllTemplatesListVM = _Mapper.Map<List<GetAllTemplatesListVM>>(await _TemplateRepository
                .OrderByDescending(FilterObject, x => x.CreatedAt, Request.page, Request.perPage)
                .ToListAsync());

            int TotalCount = await _TemplateRepository
                .Filter(FilterObject)
                .CountAsync();

            Pagination PaginationParameter = new Pagination(Request.page,
                Request.perPage, TotalCount);

            return new BaseResponse<List<GetAllTemplatesListVM>>(ResponseMessage, true, 200, GetAllTemplatesListVM, PaginationParameter);
        }
    }
}
