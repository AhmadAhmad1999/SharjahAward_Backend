using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Features.News.Queries.GetAllNews;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Common;
using SharijhaAward.Domain.Entities.CycleModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.Cycles.Queries.GetAllCycles
{
    public class GetAllCyclesQueryHandler
        : IRequestHandler<GetAllCyclesQuery, BaseResponse<List<CycleListVM>>>
    {
        private readonly IAsyncRepository<Cycle> _cycleRepository;
        private readonly IMapper _mapper;

        public GetAllCyclesQueryHandler(IAsyncRepository<Cycle> cycleRepository, IMapper mapper)
        {
            _cycleRepository = cycleRepository;
            _mapper = mapper;
        }

        public async Task<BaseResponse<List<CycleListVM>>> Handle(GetAllCyclesQuery request, CancellationToken cancellationToken)
        {
            var CycleList = await _cycleRepository
                .OrderByDescending(x => x.CreatedAt, request.page, request.pageSize)
                .ToListAsync();

            var data = _mapper.Map<List<CycleListVM>>(CycleList);
            if (CycleList.Count != 0)
            {
                for (int i = 0; i < data.Count; i++)
                {
                    data[i].Name = request.lang == "en"
                    ? data[i].EnglishName
                    : data[i].ArabicName;
                }
            }
            int count = _cycleRepository.GetCount(c => c.isDeleted == false);
            
            Pagination pagination =new Pagination(request.page, request.pageSize, count);
           
            return new BaseResponse<List<CycleListVM>>("",true,200, data,pagination);
        }
    }
}
