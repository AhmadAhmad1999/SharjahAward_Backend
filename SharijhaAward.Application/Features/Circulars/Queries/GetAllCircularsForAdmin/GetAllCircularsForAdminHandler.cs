using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Features.Circulars.Queries.GetAllCirculars;
using SharijhaAward.Application.Features.Circulars.Queries.GetCircularById;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Common;
using SharijhaAward.Domain.Entities.CircularModel;

namespace SharijhaAward.Application.Features.Circulars.Queries.GetAllCircularsForAdmin
{
    public class GetAllCircularsForAdminHandler : IRequestHandler<GetAllCircularsForAdminQuery, BaseResponse<CircularListVm>>
    {
        private readonly IAsyncRepository<Circular> _CircularRepository;
        private readonly IMapper _Mapper;

        public GetAllCircularsForAdminHandler(IAsyncRepository<Circular> CircularRepository,
            IMapper Mapper)
        {
            _CircularRepository = CircularRepository;
            _Mapper = Mapper;
        }

        public async Task<BaseResponse<CircularListVm>> Handle(GetAllCircularsForAdminQuery Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            FilterObject FilterObject = new FilterObject() { Filters = Request.filters };

            int TotalCount = 0;
            int NumberOfUnRead = 0;

            List<CircularDto> AllCirculars = _Mapper.Map<List<CircularDto>>(await _CircularRepository
                .OrderByDescending(FilterObject, x => x.Id, Request.page, Request.perPage)
                .ToListAsync());

            List<bool> AllCircularsEntities = await _CircularRepository
                .WhereThenFilter(x => true, FilterObject)
                .Select(x => x.IsRead)
                .ToListAsync();

            TotalCount = AllCircularsEntities.Count();
            NumberOfUnRead = AllCircularsEntities.Count(x => !x);

            CircularListVm Response = new CircularListVm()
            {
                Circulars = AllCirculars,
                NumberOfUnRead = NumberOfUnRead
            };

            Pagination Pagination = new Pagination(Request.page, Request.perPage, TotalCount);

            return new BaseResponse<CircularListVm>(ResponseMessage, true, 200, Response, Pagination);
        }
    }
}
