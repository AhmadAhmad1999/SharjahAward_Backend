using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.TermsAndConditionsModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.TermsAndConditions.Queries.GetAllTermAndCondition
{
    public class GetAllTermAndConditionQueryHandler
        : IRequestHandler<GetAllTermAndConditionQuery, BaseResponse<List<TermAndConditionListVM>>>
    {
        private readonly IAsyncRepository<TermAndCondition> _termAndConditionRepository;
        private readonly IMapper _mapper;

        public GetAllTermAndConditionQueryHandler(IAsyncRepository<TermAndCondition> termAndConditionRepository, IMapper mapper)
        {
            _termAndConditionRepository = termAndConditionRepository;
            _mapper = mapper;
        }

        public async Task<BaseResponse<List<TermAndConditionListVM>>> Handle(GetAllTermAndConditionQuery request, CancellationToken cancellationToken)
        {
            var termsAndConditions = await _termAndConditionRepository
                .OrderByDescending(x => x.CreatedAt, request.page, request.perPage)
                .Where(x => request.CategoryId != null 
                    ? x.CategoryId == request.CategoryId
                    : true)
                .ToListAsync();
            
            var data = _mapper.Map<List<TermAndConditionListVM>>(termsAndConditions);
            if(data.Count != 0)
            {
           
                for(int i = 0; i < data.Count; i++)
                {
                    data[i].Title = request.lang == "en" ? data[i].EnglishTitle : data[i].ArabicTitle;
                    data[i].Description = request.lang == "en" ? data[i].EnglishDescription : data[i].ArabicDescription;
                }
            }
            var count = request.CategoryId == null
                ? await _termAndConditionRepository.GetCountAsync(t => t.isDeleted == false)
                : await _termAndConditionRepository.GetCountAsync(t => t.CategoryId == request.CategoryId);

            Pagination pagination = new Pagination(request.page, request.perPage, count);
            return new BaseResponse<List<TermAndConditionListVM>>("", true, 200, data, pagination);    
            
        }
    }
}
