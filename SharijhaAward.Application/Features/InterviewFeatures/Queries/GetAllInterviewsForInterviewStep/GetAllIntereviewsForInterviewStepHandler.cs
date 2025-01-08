﻿using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Common;
using SharijhaAward.Domain.Entities.InterviewModel;

namespace SharijhaAward.Application.Features.InterviewFeatures.Queries.GetAllInterviewsForInterviewStep
{
    public class GetAllIntereviewsForInterviewStepHandler : IRequestHandler<GetAllInterviewsForInterviewStepQuery, BaseResponse<List<GetAllInterviewsForInterviewStepListVM>>>
    {
        private readonly IAsyncRepository<Interview> _InterviewRepository;
        private readonly IMapper _Mapper;
        public GetAllIntereviewsForInterviewStepHandler(IAsyncRepository<Interview> InterviewRepository,
            IMapper Mapper)
        {
            _InterviewRepository = InterviewRepository;
            _Mapper = Mapper;
        }

        public async Task<BaseResponse<List<GetAllInterviewsForInterviewStepListVM>>> Handle(GetAllInterviewsForInterviewStepQuery Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;
            FilterObject FilterObject = new FilterObject() { Filters = Request.filters };

            List<GetAllInterviewsForInterviewStepListVM> Meetings = await _InterviewRepository
                .OrderByDescending(FilterObject, x => x.CreatedAt, Request.page, Request.perPage)
                .Select(x => new GetAllInterviewsForInterviewStepListVM()
                {
                    StartDate = x.StartDate,
                    Description = Request.lang == "en"
                        ? x.EnglishDescription
                        : x.ArabicDescription,
                    Id = x.Id,
                    Name = Request.lang == "en"
                        ? x.EnglishName
                        : x.ArabicName,
                    Type = x.Type
                }).ToListAsync();

            int TotalCount = await _InterviewRepository.WhereThenFilter(x => true, FilterObject).CountAsync();

            Pagination PaginationParameter = new Pagination(Request.page,
                Request.perPage, TotalCount);

            return new BaseResponse<List<GetAllInterviewsForInterviewStepListVM>>(ResponseMessage, true, 200, Meetings, PaginationParameter);
        }
    }
}
