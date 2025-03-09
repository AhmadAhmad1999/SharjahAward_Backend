using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Common;
using SharijhaAward.Domain.Entities.AdvancedFormBuilderModel;

namespace SharijhaAward.Application.Features.AdvancedFormBuilderFeatures.Queries.GetAllVirtualTables
{
    public class GetAllVirtualTablesHandler : IRequestHandler<GetAllVirtualTablesQuery, BaseResponse<List<GetAllVirtualTablesListVM>>>
    {
        private readonly IAsyncRepository<VirtualTableForSection> _VirtualTableForSectionRepository;
        private readonly IMapper _Mapper;
        public GetAllVirtualTablesHandler(IAsyncRepository<VirtualTableForSection> VirtualTableForSectionRepository,
            IMapper Mapper)
        {
            _VirtualTableForSectionRepository = VirtualTableForSectionRepository;
            _Mapper = Mapper;
        }

        public async Task<BaseResponse<List<GetAllVirtualTablesListVM>>> Handle(GetAllVirtualTablesQuery Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            var filterObject = new FilterObject() { Filters = Request.filters };

            var VirtualTableForSections = await _VirtualTableForSectionRepository
                .GetFilterThenPagedReponseAsync(filterObject, Request.page, Request.perPage);

            var data = _Mapper.Map<List<GetAllVirtualTablesListVM>>(VirtualTableForSections);

            int TotalCount = await _VirtualTableForSectionRepository.WhereThenFilter(x => true, filterObject)
                .CountAsync();

            Pagination PaginationParameter = new Pagination(Request.page,
                Request.perPage, TotalCount);

            return new BaseResponse<List<GetAllVirtualTablesListVM>>(ResponseMessage, true, 200, data, PaginationParameter);
        }
    }
}
