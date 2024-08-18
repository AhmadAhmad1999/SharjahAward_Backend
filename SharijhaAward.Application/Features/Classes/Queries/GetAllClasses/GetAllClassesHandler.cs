using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Common;
using SharijhaAward.Domain.Entities.EducationalClassModel;

namespace SharijhaAward.Application.Features.Classes.Queries.GetAllClasses
{
    public class GetAllClassesHandler : IRequestHandler<GetAllClassesQuery, BaseResponse<List<GetAllClassesListVM>>>
    {
        private readonly IAsyncRepository<EducationalClass> _EducationalClassRepository;
        private readonly IMapper _Mapper;
        public GetAllClassesHandler(IAsyncRepository<EducationalClass> EducationalClassRepository,
            IMapper Mapper)
        {
            _EducationalClassRepository = EducationalClassRepository;
            _Mapper = Mapper;
        }

        public async Task<BaseResponse<List<GetAllClassesListVM>>> Handle(GetAllClassesQuery Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            var filterObject = new FilterObject() { Filters = Request.filters };

            List<GetAllClassesListVM> Classes = _Mapper.Map<List<GetAllClassesListVM>>(await _EducationalClassRepository
                .OrderByDescending(filterObject, x => x.CreatedAt, Request.page, Request.perPage).ToListAsync());

            int TotalCount = await _EducationalClassRepository.GetCountAsync(null);

            Pagination PaginationParameter = new Pagination(Request.page,
                Request.perPage, TotalCount);

            return new BaseResponse<List<GetAllClassesListVM>>(ResponseMessage, true, 200, Classes, PaginationParameter);
        }
    }
}
