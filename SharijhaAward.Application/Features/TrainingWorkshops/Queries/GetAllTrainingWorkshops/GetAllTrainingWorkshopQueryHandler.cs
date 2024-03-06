using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Domain.Entities.TrainingWorkshopModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.TrainingWorkshops.Queries.GetAllTrainingWorkshops
{
    public class GetAllTrainingWorkshopQueryHandler
        : IRequestHandler<GetAllTrainingWorkshopsQuery, List<TrainingWorkshopListVm>>
    {
        private readonly IAsyncRepository<TrainingWorkshop> _trainingWorkshopRepository;
        private readonly IMapper _mapper;

        public GetAllTrainingWorkshopQueryHandler(IAsyncRepository<TrainingWorkshop> trainingWorkshopRepository, IMapper mapper)
        {
            _trainingWorkshopRepository = trainingWorkshopRepository;
            _mapper = mapper;
        }

        public async Task<List<TrainingWorkshopListVm>> Handle(GetAllTrainingWorkshopsQuery request, CancellationToken cancellationToken)
        {
            var workShops = await _trainingWorkshopRepository.ListAllAsync();
            if (workShops.Count == 0)
            {
                return _mapper.Map<List<TrainingWorkshopListVm>>(workShops);
            }
            List<TrainingWorkshopListVm> trainingWorkshops = new List<TrainingWorkshopListVm>();
            for(int i = 0 ; i < workShops.Count ; i++)
            {
                TrainingWorkshopListVm listVm = new TrainingWorkshopListVm()
                {
                    Id = workShops[i].Id,
                    ArabicTitle = workShops[i].ArabicTitle,
                    EnglishTitle = workShops[i].EnglishTitle,
                   
                    Thumbnail = workShops[i].Thumbnail,

                    Title = request.lang=="ar"?
                    workShops[i].ArabicTitle :
                    workShops[i].EnglishTitle,

                    
                   
                };
                trainingWorkshops.Add(listVm);
            }
            return _mapper.Map<List<TrainingWorkshopListVm>>(trainingWorkshops);
        }
    }
}
