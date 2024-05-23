using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
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

            List<GetAllClassesListVM> Classes = _Mapper.Map<List<GetAllClassesListVM>>(await _EducationalClassRepository
                .OrderByDescending(x => x.CreatedAt, Request.page, Request.pageSize).ToListAsync());

            int TotalCount = await _EducationalClassRepository.GetCountAsync(null);

            Pagination PaginationParameter = new Pagination(Request.page,
                Request.pageSize, TotalCount);

            return new BaseResponse<List<GetAllClassesListVM>>(ResponseMessage, true, 200, Classes, PaginationParameter);
        }
    }
}
