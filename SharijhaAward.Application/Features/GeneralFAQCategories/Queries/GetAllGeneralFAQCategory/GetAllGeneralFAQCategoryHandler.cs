﻿using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Features.Classes.Queries.GetAllClasses;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Common;
using SharijhaAward.Domain.Entities.GeneralFrequentlyAskedQuestionModel;
using System.Linq;

namespace SharijhaAward.Application.Features.GeneralFAQCategories.Queries.GetAllGeneralFAQCategory
{
    public class GetAllGeneralFAQCategoryHandler : IRequestHandler<GetAllGeneralFAQCategoryQuery, 
        BaseResponse<List<GetAllGeneralFAQCategoryListVM>>>
    {
        private readonly IAsyncRepository<GeneralFAQ> _GeneralFAQRepository;
        private readonly IAsyncRepository<GeneralFAQCategory> _GeneralFAQCategoryRepository;

        public GetAllGeneralFAQCategoryHandler(IAsyncRepository<GeneralFAQ> GeneralFAQRepository,
            IAsyncRepository<GeneralFAQCategory> GeneralFAQCategoryRepository)
        {
            _GeneralFAQRepository = GeneralFAQRepository;
            _GeneralFAQCategoryRepository = GeneralFAQCategoryRepository;
        }

        public async Task<BaseResponse<List<GetAllGeneralFAQCategoryListVM>>> Handle(GetAllGeneralFAQCategoryQuery Request,
            CancellationToken cancellationToken)
        {
            FilterObject filterObject = new FilterObject() { Filters = Request.filters };

            string ResponseMessage = string.Empty;

            List<GetAllGeneralFAQCategoryListVM> GeneralFAQCategories = await _GeneralFAQCategoryRepository
                .OrderByDescending(filterObject, x => x.CreatedAt, Request.page, Request.perPage)
                .Select(x => new GetAllGeneralFAQCategoryListVM()
                {
                    Id = x.Id,
                    Name = Request.lang == "ar"
                        ? x.ArabicName
                        : x.EnglishName
                }).ToListAsync();

            foreach (GetAllGeneralFAQCategoryListVM GeneralFAQCategory in GeneralFAQCategories)
            {
                GeneralFAQCategory.GeneralFAQListVM =  Request.searchQuery != null

                    ? await _GeneralFAQRepository
                    .Where(x => x.GeneralFrequentlyAskedQuestionCategoryId == GeneralFAQCategory.Id)
                    .Where(x=>x.ArabicQuestion.Contains(Request.searchQuery!) 
                    || x.ArabicAnswer.Contains(Request.searchQuery!)
                    || x.EnglishQuestion.Contains(Request.searchQuery!)
                    || x.EnglishAnswer.Contains(Request.searchQuery!))
                    .OrderByDescending(x => x.CreatedAt)
                    .Select(x => new GetAllGeneralFAQListVM()
                    {
                        Id = x.Id,
                        Answer = Request.lang == "ar"
                            ? x.ArabicAnswer
                            : x.EnglishAnswer,
                        Question = Request.lang == "ar"
                            ? x.ArabicQuestion
                            : x.EnglishQuestion
                    }).ToListAsync()

                    : await _GeneralFAQRepository
                    .Where(x => x.GeneralFrequentlyAskedQuestionCategoryId == GeneralFAQCategory.Id)
                    .OrderByDescending(x => x.CreatedAt)
                    .Select(x => new GetAllGeneralFAQListVM()
                    {
                        Id = x.Id,
                        Answer = Request.lang == "ar"
                            ? x.ArabicAnswer
                            : x.EnglishAnswer,
                        Question = Request.lang == "ar"
                            ? x.ArabicQuestion
                            : x.EnglishQuestion
                    }).ToListAsync();

            }

            GeneralFAQCategories = GeneralFAQCategories
                .Where(x => x.GeneralFAQListVM.Any())
                .ToList();

            int TotalCount = await _GeneralFAQCategoryRepository.GetCountAsync(null);

            Pagination PaginationParameter = new Pagination(Request.page,
                Request.perPage, TotalCount);

            return new BaseResponse<List<GetAllGeneralFAQCategoryListVM>>(ResponseMessage, true, 200, GeneralFAQCategories, PaginationParameter);
        }
    }
}
