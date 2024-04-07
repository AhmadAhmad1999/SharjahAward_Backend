using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.CycleModel;
using SharijhaAward.Domain.Entities.EducationalClassModel;

namespace SharijhaAward.Application.Features.Classes.Queries.GetAllClasses
{
    public class GetAllClassesHandler : IRequestHandler<GetAllClassesQuery, BaseResponse<List<GetAllClassesListVM>>>
    {
        private readonly IAsyncRepository<EducationalClass> _EducationalClassRepository;
        private readonly IAsyncRepository<Cycle> _CycleRepository;
        private readonly IMapper _Mapper;
        public GetAllClassesHandler(IAsyncRepository<EducationalClass> EducationalClassRepository,
            IAsyncRepository<Cycle> CycleRepository,
            IMapper Mapper)
        {
            _EducationalClassRepository = EducationalClassRepository;
            _CycleRepository = CycleRepository;
            _Mapper = Mapper;
        }

        public async Task<BaseResponse<List<GetAllClassesListVM>>> Handle(GetAllClassesQuery Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            if (Request.CycleId is null)
            {
                Cycle? CheckIfThereIsAnActiveCycle = await _CycleRepository
                    .FirstOrDefaultAsync(x => x.Status == Domain.Constants.Common.Status.Active);

                if (CheckIfThereIsAnActiveCycle is not null)
                    Request.CycleId = CheckIfThereIsAnActiveCycle.Id;

                else
                {
                    ResponseMessage = Request.lang == "en"
                        ? "There is no active cycle"
                        : "لا يوجد دورة فعالة";

                    return new BaseResponse<List<GetAllClassesListVM>>(ResponseMessage, false, 404);
                }
            }

            List<GetAllClassesListVM> Classes = _Mapper.Map<List<GetAllClassesListVM>>(await _EducationalClassRepository
                .GetWhereThenPagedReponseAsync(x => x.CycleId == Request.CycleId,
                    Request.page, Request.pageSize));

            int TotalCount = await _EducationalClassRepository.GetCountAsync(x => x.CycleId == Request.CycleId);

            Pagination PaginationParameter = new Pagination(Request.page,
                Request.pageSize, TotalCount);

            return new BaseResponse<List<GetAllClassesListVM>>(ResponseMessage, true, 200, Classes, PaginationParameter);
        }
    }
}
