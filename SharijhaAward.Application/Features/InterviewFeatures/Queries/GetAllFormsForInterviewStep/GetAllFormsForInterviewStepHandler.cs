using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Common;
using SharijhaAward.Domain.Entities.InterviewModel;

namespace SharijhaAward.Application.Features.InterviewFeatures.Queries.GetAllFormsForInterviewStep
{
    public class GetAllFormsForInterviewStepHandler : IRequestHandler<GetAllFormsForInterviewStepQuery, BaseResponse<List<GetAllFormsForInterviewStepListVM>>>
    {
        private readonly IAsyncRepository<Interview> _InterviewRepository;
        private readonly IMapper _Mapper;
        public GetAllFormsForInterviewStepHandler(IAsyncRepository<Interview> InterviewRepository,
            IMapper Mapper)
        {
            _InterviewRepository = InterviewRepository;
            _Mapper = Mapper;
        }

        public async Task<BaseResponse<List<GetAllFormsForInterviewStepListVM>>> Handle(GetAllFormsForInterviewStepQuery Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;
            FilterObject filterObject = new FilterObject() { Filters = Request.filters };

            if (Request.isCanceled is not null)
            {
                List<GetAllFormsForInterviewStepListVM> Meetings = _Mapper.Map<List<GetAllFormsForInterviewStepListVM>>(await _InterviewRepository
                    .WhereThenFilter(x => x.isCanceled == Request.isCanceled, filterObject)
                    .OrderByDescending(x => x.CreatedAt)
                    .ToListAsync());

                int TotalCount = await _InterviewRepository.GetCountAsync(null);

                Pagination PaginationParameter = new Pagination(Request.page,
                    Request.pageSize, TotalCount);

                return new BaseResponse<List<GetAllFormsForInterviewStepListVM>>(ResponseMessage, true, 200, Meetings, PaginationParameter);
            }
            else if (Request.isImplemented is not null)
            {
                List<GetAllFormsForInterviewStepListVM> Meetings = _Mapper.Map<List<GetAllFormsForInterviewStepListVM>>(await _InterviewRepository
                    .WhereThenFilter(x => x.isImplemented == Request.isImplemented, filterObject)
                    .OrderByDescending(x => x.CreatedAt)
                    .ToListAsync());

                int TotalCount = await _InterviewRepository.GetCountAsync(null);

                Pagination PaginationParameter = new Pagination(Request.page,
                    Request.pageSize, TotalCount);

                return new BaseResponse<List<GetAllFormsForInterviewStepListVM>>(ResponseMessage, true, 200, Meetings, PaginationParameter);
            }
            else
            {
                List<GetAllFormsForInterviewStepListVM> Meetings = _Mapper.Map<List<GetAllFormsForInterviewStepListVM>>(await _InterviewRepository
                    .OrderByDescending(filterObject, x => x.CreatedAt, Request.page, Request.pageSize).ToListAsync());

                int TotalCount = await _InterviewRepository.GetCountAsync(null);

                Pagination PaginationParameter = new Pagination(Request.page,
                    Request.pageSize, TotalCount);

                return new BaseResponse<List<GetAllFormsForInterviewStepListVM>>(ResponseMessage, true, 200, Meetings, PaginationParameter);
            }
        }
    }
}
