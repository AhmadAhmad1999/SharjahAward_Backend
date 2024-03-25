using AutoMapper;
using MediatR;
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
            var termsAndConditions = await _termAndConditionRepository.ListAllAsync();
            
            if (request.CategoryId != null)
                termsAndConditions = _termAndConditionRepository.Where(t => t.CategoryId == request.CategoryId).ToList();
            else
               termsAndConditions = await _termAndConditionRepository.GetPagedReponseAsync(request.page, request.pageSize);
            
            var data = _mapper.Map<List<TermAndConditionListVM>>(termsAndConditions);
            if(data.Count != 0)
            {
           
                for(int i = 0; i < data.Count; i++)
                {
                    data[i].Title = request.lang == "en" ? data[i].EnglishTitle : data[i].ArabicTitle;
                    data[i].Description = request.lang == "en" ? data[i].EnglishDescription : data[i].ArabicDescription;
                }
            }
            var count = await  _termAndConditionRepository.GetCountAsync(t => t.isDeleted == false);
            Pagination pagination = new Pagination(request.page, request.pageSize, count);
            return new BaseResponse<List<TermAndConditionListVM>>("", true, 200, data, pagination);    
            
        }
    }
}
