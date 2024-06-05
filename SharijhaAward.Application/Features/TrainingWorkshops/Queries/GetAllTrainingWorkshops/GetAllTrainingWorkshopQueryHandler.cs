using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.TrainingWorkshopModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.TrainingWorkshops.Queries.GetAllTrainingWorkshops
{
    public class GetAllTrainingWorkshopQueryHandler
        : IRequestHandler<GetAllTrainingWorkshopsQuery, BaseResponse<List<TrainingWorkshopListVm>>>
    {
        private readonly IAsyncRepository<TrainingWorkshop> _trainingWorkshopRepository;
        private readonly IMapper _mapper;

        public GetAllTrainingWorkshopQueryHandler(IAsyncRepository<TrainingWorkshop> trainingWorkshopRepository, IMapper mapper)
        {
            _trainingWorkshopRepository = trainingWorkshopRepository;
            _mapper = mapper;
        }

        public async Task<BaseResponse<List<TrainingWorkshopListVm>>> Handle(GetAllTrainingWorkshopsQuery request, CancellationToken cancellationToken)
        {
            var workShops = await _trainingWorkshopRepository.OrderByDescending(x => x.CreatedAt, request.page, request.perPage)
                .ToListAsync();

            if (workShops.Count == 0)
            {
                return new BaseResponse<List<TrainingWorkshopListVm>>("", true, 200);
            }
            var data = _mapper.Map<List<TrainingWorkshopListVm>>(workShops);
            for(int i = 0 ; i < data.Count ; i++)
            {
                data[i].Title = request.lang == "ar" ?
                 data[i].ArabicTitle :
                 data[i].EnglishTitle;
            }
            int count = _trainingWorkshopRepository.GetCount(t =>!t.isDeleted);
            var pagenation = new Pagination(request.page, request.perPage, count);
            return new BaseResponse<List<TrainingWorkshopListVm>>("", true, 200,data,pagenation);
        }
    }
}
